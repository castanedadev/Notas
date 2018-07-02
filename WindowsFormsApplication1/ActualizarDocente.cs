using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class ActualizarDocente : Form
    {
        Procesos call = new Procesos();
        private SqlConnection conectar;
        private SqlCommand cmd;
        private SqlDataAdapter adap;
        //private SqlDataAdapter adap1;
        private SqlDataReader dr;

        private String Grado, Seccion, ID;
        private String[] G, M, S;
        private int Señal1, Señal2, a1 = 0, a2 = 0, a3 = 0;

        public ActualizarDocente()
        {
            InitializeComponent();
        }

        private void ActualizarDocente_Load(object sender, EventArgs e)
        {
            call.LlenarGrados(CB_TGrado);
            call.LlenarGrados(CB_Grado);
            llenado();
            orden();
        }

        private void CB_TGrado_SelectedIndexChanged(object sender, EventArgs e)
        {
            CB_TSeccion.Enabled = true;
            call.Limpiarcb(CB_TSeccion);
            call.LlenarSeccion(CB_TSeccion, CB_TGrado);
        }

        private void CB_Grado_SelectedIndexChanged(object sender, EventArgs e)
        {
            CB_TMateria.Enabled = true;
            call.Limpiarcb(CB_TMateria);
            call.LlenarMaterias(CB_TMateria, CB_Grado);
        }

        private void CB_TMateria_SelectedIndexChanged(object sender, EventArgs e)
        {
            CB_TNGMS.Enabled = true;
            call.Limpiarcb(CB_TNGMS);
            call.LlenarSeccion(CB_TNGMS, CB_Grado);
        }

        private void CB_TNGMS_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CB_TNGMS.Text != "" && CB_Grado.Text != "" && CB_TMateria.Text != "")
            {
                if (MessageBox.Show("   ¿ Desea Agregar ?\n\n Grado:   " + CB_Grado.Text + "\n Materia: " + CB_TMateria.Text + "\n Seccion: " + CB_TNGMS.Text, "Agregar Grado y materia", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DGV_g_m.Rows.Add(CB_Grado.Text, CB_TMateria.Text, CB_TNGMS.Text);
                }
            }
        }

        private void DGV_g_m_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (MessageBox.Show("Grado:    " + DGV_g_m.Rows[e.RowIndex].Cells[0].Value + "\nMateria: " + DGV_g_m.Rows[e.RowIndex].Cells[1].Value + "\nSeccion: " + DGV_g_m.Rows[e.RowIndex].Cells[2].Value + "\n\n¿Dese eliminar estos datos?", "ELIMINAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DGV_g_m.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void llenado()
        {
            try
            {
                DGV_g_m.Columns.Add("suda", "Grado");
                DGV_g_m.Columns.Add("suda2", "Materia");
                DGV_g_m.Columns.Add("suda3", "Seccion");
                int conteo = 0;
                conectar = Conexion.Cnn();
                String consulta2 = "select  Nombre from Maestros ";
                adap = new SqlDataAdapter(consulta2, conectar);
                dr = adap.SelectCommand.ExecuteReader();
                while (dr.Read())
                {
                    LBDocentes.Items.Add(dr["Nombre"].ToString()); conteo++;
                } conectar.Close();
                if (conteo == 0) MessageBox.Show("No hay Docentes registrados,", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "No se lograron cargar los Profesores", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void orden()
        {
            String[] nombre = new String[LBDocentes.Items.Count];
            for (int i = 0; i < nombre.Length; i++)
            {
                nombre[i] = LBDocentes.Items[i].ToString();
            }
            Array.Sort(nombre);
            LBDocentes.Items.Clear();
            for (int i = 0; i < nombre.Length; i++)
            {
                LBDocentes.Items.Add(nombre[i]);
            }
        }
        ////////////////////////////////////////////////////////////
        //////////////////////// VER DATOS
        private void LBDocentes_SelectedIndexChanged(object sender, EventArgs e)
        {
            mostrarDatos(LBDocentes.SelectedItem.ToString());
            btnUpdate.Enabled = true;
            btnEliminar.Enabled = true;
            MessageBox.Show("Datos del docente cargados\nExitosamente....", "DATOS DEL DOCENTE", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void mostrarDatos(String nombre)
        {
            String valor = ""; valor = conocerEstado(valor, nombre);
            coonocerID(nombre);
            //////////////////  ACTIVO-INACTIVO
            if (valor == "1")
            {
                Veractivo(1);
                Señal1 = 1;
                valor = ConocerTipoTutor(valor, nombre);
                //////////////////  TUTOR- NO TUTOR
                if (valor == "1")
                {
                    Señal2 = 1; tutor = 1;
                    chTutor.Checked = true;
                    GB_tutor.Visible = true;
                    conectar = Conexion.Cnn();
                    String consulta1 = "consultaMaestroData";
                    cmd = new SqlCommand(consulta1, conectar);
                    cmd.Parameters.AddWithValue("@id", ID);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.ExecuteNonQuery();
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        CB_TGrado.Text = dr["Grado"].ToString();
                        CB_TSeccion.Text = dr["Seccion"].ToString();
                    }
                    conectar.Close();
                    Grado = CB_TGrado.Text.Trim();
                    Seccion = CB_TSeccion.Text.Trim();
                }
                else
                {
                    Señal2 = 0; tutor = 0;
                    chTutor.Checked = false;
                    GB_tutor.Visible = false;
                }
                verNGM(nombre);
            }
            else
            {
                Veractivo(0);
                Señal1 = 0;
                G = new String[0];
                GB_tutor.Visible = false;
            }
        }

        private void coonocerID(String nombre)
        {
            ///////////////////////////////////
            ///// CONSEGUIR ID
            conectar = Conexion.Cnn();
            String consulta = "select IdMaestro from Maestros where Nombre = '" + nombre + "'";
            adap = new SqlDataAdapter(consulta, conectar);
            SqlParameter prm = new SqlParameter("Nombre", SqlDbType.VarChar);
            prm.Value = nombre;
            adap.SelectCommand.Parameters.Add(prm);
            dr = adap.SelectCommand.ExecuteReader();
            while (dr.Read())
            {
                ID = dr["IdMaestro"].ToString().Trim();
            }
            conectar.Close();
        }

        private void verNGM(String nombre)
        {
            ///////////////////////////////////
            ///// VER NGM
            DGV_g_m.Rows.Clear();
            conectar = Conexion.Cnn();
            String consulta1 = "VerNGM";
            cmd = new SqlCommand(consulta1, conectar);
            cmd.Parameters.AddWithValue("@id", ID);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                DGV_g_m.Rows.Add(dr["Grado"].ToString(), dr["Materia"].ToString(), dr["Seccion"].ToString());
            }
            conectar.Close();
            G = new String[DGV_g_m.Rows.Count];
            M = new String[G.Length];
            S = new String[M.Length];

            for (int i = 0; i < DGV_g_m.Rows.Count; i++)
            {
                G[i] = DGV_g_m[0, i].Value.ToString();
                M[i] = DGV_g_m[1, i].Value.ToString();
                S[i] = DGV_g_m[2, i].Value.ToString();
            }
        }

        private String ConocerTipoTutor(String valor, String nombre)
        {
            conectar = Conexion.Cnn();
            String consulta = "select Tutor from Maestros where Nombre = '" + nombre + "'";
            adap = new SqlDataAdapter(consulta, conectar);
            SqlParameter prm = new SqlParameter("Nombre", SqlDbType.VarChar);
            prm.Value = nombre;
            adap.SelectCommand.Parameters.Add(prm);
            dr = adap.SelectCommand.ExecuteReader();
            while (dr.Read())
            {
                valor = dr["tutor"].ToString().Trim();
            }
            conectar.Close();
            return valor;
        }

        private string conocerEstado(string valor, string nombre)
        {
            conectar = Conexion.Cnn();
            String consulta = "select Estado from Maestros where Nombre = '" + nombre + "'";
            adap = new SqlDataAdapter(consulta, conectar);
            SqlParameter prm = new SqlParameter("Nombre", SqlDbType.VarChar);
            prm.Value = nombre;
            adap.SelectCommand.Parameters.Add(prm);
            dr = adap.SelectCommand.ExecuteReader();
            while (dr.Read())
            {
                valor = dr["Estado"].ToString().Trim();
            }
            conectar.Close();
            return valor;
        }

        ////////////////////////////////////////////////////////////
        //////////////////////// CHECKBOX
        int tutor = 0;
        private void chTutor_CheckedChanged(object sender, EventArgs e)
        {
            if (chTutor.Checked == true)
            {
                GB_tutor.Visible = true;
                call.Limpiarcb(CB_TGrado);
                call.LlenarGrados(CB_TGrado);
                tutor = 1;
            }
            else
            {
                GB_tutor.Visible = false;
                call.Limpiarcb(CB_TGrado);
                call.Limpiarcb(CB_TSeccion);
                tutor = 0;
            }
        }

        int activo = 0;
        private void chEstado_CheckedChanged(object sender, EventArgs e)
        {
            if (chEstado.Checked == true)
            {
                Veractivo(1);
                activo = 1;
            }
            else
            {
                Veractivo(0);
                activo = 0;
            }
        }

        private void Veractivo(int p)
        {
            if (p == 0)
            {
                chEstado.Text = "INACTIVO";
                chEstado.Checked = false;
                chTutor.Visible = false;
                GB_tutor.Visible = false;
                GB_NGMS.Visible = false;
                activo = 0;
            }
            else
            {
                chEstado.Text = "ACTIVO";
                chEstado.Checked = true;
                chTutor.Visible = true;
                GB_tutor.Visible = false;
                GB_NGMS.Visible = true;
                activo = 1;
            }
        }

        ////////////////////////////////////////////////////////////
        //////////////////////// ACTUALIZAR
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            a1 = 0; a2 = 0; a3 = 0;
            Actualizar();
            if (a1 == 1)
            {
                Limpiar();
                btnUpdate.Enabled = false;
                btnEliminar.Enabled = true;
            }
        }

        private void Limpiar()
        {
            chTutor.Checked = false;
            CB_TGrado.Text = "";
            CB_TSeccion.Text = "";
            CB_Grado.Text = "";
            CB_TMateria.Text = "";
            CB_TNGMS.Text = "";
            GB_tutor.Visible = false;
            DGV_g_m.Rows.Clear();
            CB_TMateria.Enabled = false;
            CB_TNGMS.Enabled = false;
        }

        ////////////////////////////////////////////////////////////
        //////////////////////// PROCESO DE ACTUALIZACION

        private void Actualizar()
        {
            if (activo == 1) //es activo
            {
                if (DGV_g_m.Rows.Count > 0)
                {
                    if (Señal1 == 1) //ES Y era activo
                    {
                        if (tutor == 1) //es tutor
                        {
                            if (Señal2 == 1) //ES Y era tutor
                            {
                                if (Grado == CB_TGrado.Text && Seccion == CB_TSeccion.Text)//same tutor
                                {
                                    //mismo tutor//mjs de que es el mismo 
                                    //NO CAMBIRA TUTOR
                                    MessageBox.Show("No hay cambio de Tutor", "CAMBIOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    //VER lo NGM
                                    VerLodeNGMS();
                                    if (a3 != 0)
                                    {
                                        ///Cambair NGMS
                                        if (a3 == 1) { ActualizarNGM(); MessageBox.Show("DATOS ACTUALIZADOS", "ACTUALIZACION", MessageBoxButtons.OK, MessageBoxIcon.Information); a1 = 1; }
                                    }
                                }
                                else//DIFERENTE TUTOR
                                {
                                    //VER LO DE TUTOR
                                    VerloDeTutor();
                                    if (a2 == 1)
                                    {
                                        VerLodeNGMS();
                                        if (a3 != 0)
                                        {
                                            if (a3 == 2) { ActurTTutorYES(); }//solo tutor
                                            if (a3 == 1) { ActurTTutorYES(); ActualizarNGM(); }
                                            MessageBox.Show("DATOS ACTUALIZADOS", "ACTUALIZACION", MessageBoxButtons.OK, MessageBoxIcon.Information); a1 = 1;
                                        }
                                    }
                                }
                            }
                            else//ES Y no era tutor
                            {
                                //VER LO DE TUTOR
                                VerloDeTutor();
                                if (a2 == 1)
                                {
                                    VerLodeNGMS();
                                    if (a3 != 0)
                                    {
                                        //
                                        if (a3 == 2) { ActurTTutorYES(); }//solo tutor
                                        if (a3 == 1) { ActurTTutorYES(); ActualizarNGM(); }
                                        MessageBox.Show("DATOS ACTUALIZADOS", "ACTUALIZACION", MessageBoxButtons.OK, MessageBoxIcon.Information); a1 = 1;
                                    }
                                }
                            }
                        }
                        else// NO ES TUTOR
                        {
                            if (Señal2 == 1)//NO ES Y ERA TUTOR
                            {
                                //ACTUALIZAR LO DE DOCENTE DE QUE YA NO 
                                //Y DESPUED VER LO DE NGM
                                ActurTTutorNO();
                                VerLodeNGMS();
                                if (a3 != 0)
                                {
                                    ///Cambair NGMS
                                    if (a3 == 1) { ActualizarNGM(); MessageBox.Show("DATOS ACTUALIZADOS", "ACTUALIZACION", MessageBoxButtons.OK, MessageBoxIcon.Information); a1 = 1; }
                                }
                            }
                            else//NO ES TUTOR Y NO ERA TUTOR
                            {
                                //MJS DE QUE NO CAMBIO DE TUTOR
                                MessageBox.Show("No hay cambio de Tutor", "CAMBIOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                //VER LO DE NGMS
                                VerLodeNGMS();
                                if (a3 != 0)
                                {
                                    ///Cambair NGMS
                                    if (a3 == 1) { ActualizarNGM(); MessageBox.Show("DATOS ACTUALIZADOS", "ACTUALIZACION", MessageBoxButtons.OK, MessageBoxIcon.Information); a1 = 1; }
                                }
                            }
                        }
                    }//ES ACTIVO Y NO ERA
                    else
                    {
                        if (tutor == 1) //ES TUTOR
                        {
                            //VERIFICAR TUTOR
                            //yield DESPUE  VER NGM                                                
                            VerloDeTutor();
                            if (a2 == 1)
                            {
                                VerLodeNGMS();
                                if (a3 != 0)
                                {
                                    if (a3 == 2) { NActualizarTutorYES(); }//solo tutor
                                    if (a3 == 1) { NActualizarTutorYES(); NIngresarNGMS(); }
                                    MessageBox.Show("DATOS ACTUALIZADOS", "ACTUALIZACION", MessageBoxButtons.OK, MessageBoxIcon.Information); a1 = 1;
                                }
                            }
                        }
                        else//NO ES TUTOR
                        {
                            //VER LO DE NGM
                            NActualizarTutorNO();
                            VerLodeNGMS();
                            if (a3 != 0)
                            {
                                ///Cambair NGMS
                                if (a3 == 1) { NIngresarNGMS(); MessageBox.Show("DATOS ACTUALIZADOS", "ACTUALIZACION", MessageBoxButtons.OK, MessageBoxIcon.Information); a1 = 1; }
                            }
                        }
                    }
                }
                else MessageBox.Show("DEBE INGRESAR AL MENOS UNA MATRIA QUE IMPARTE EL DOCENTE", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {//ESCOGIO QUE SERA EL PROFE ------ INACTIVO
                //ACTUALIZAR TUTR
                //ACTULIZAR -DELTE NGMS
                //ACTUALIZAR DATOD EL WEY EN ESTADO
                if (MessageBox.Show("¿Desea pasar a Inactivo a este Docente?\n\nSus datos de Tutor y Materias que impartía seran eliminadas del Sistema", "ESTADO DOCENTE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Borrar();
                    MessageBox.Show("DATOS ACTUALIZADOS", "ACTUALIZACION", MessageBoxButtons.OK, MessageBoxIcon.Information); a1 = 1;
                }
            }
        }

        ////////////////////////////////////////////////////////////
        //////////////////////// PROCEDIMIENTOS

        private void Borrar()
        {
            conectar = Conexion.Cnn();
            String consulta = "Update Maestros set Tutor = 0, Grado_t = 1, Seccion_t = 1, Estado = 2  Where IdMaestro = '" + ID + "'";
            cmd = new SqlCommand(consulta, conectar);
            cmd.ExecuteNonQuery();
            conectar.Close();

            conectar = Conexion.Cnn();
            String consulta2 = "DeletedNGM";
            cmd = new SqlCommand(consulta2, conectar);
            cmd.Parameters.AddWithValue("@idMaestro", ID);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            conectar.Close();
        }

        private void NActualizarTutorNO()
        {
            conectar = Conexion.Cnn();
            String consulta = "Update Maestros set Tutor = 0, Grado_t = 1, Seccion_t = 1,Estado = 1  Where IdMaestro = '" + ID + "'";
            cmd = new SqlCommand(consulta, conectar);
            cmd.ExecuteNonQuery();
            conectar.Close();
        }

        private void NIngresarNGMS()
        {
            String grado = "", materia = "", seccion = "";
            for (int i = 0; i < DGV_g_m.Rows.Count; i++)
            {
                grado = DGV_g_m[0, i].Value.ToString();
                materia = DGV_g_m[1, i].Value.ToString();
                seccion = DGV_g_m[2, i].Value.ToString();
                conectar = Conexion.Cnn();
                String consulta2 = "IngresarNGM";
                cmd = new SqlCommand(consulta2, conectar);
                cmd.Parameters.AddWithValue("@IdMaestro", ID);
                cmd.Parameters.AddWithValue("@Grado", grado);
                cmd.Parameters.AddWithValue("@Materia", materia);
                cmd.Parameters.AddWithValue("@seccion", seccion);
                cmd.Parameters.AddWithValue("@estado", 1);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();
                conectar.Close();
            }
        }

        private void NActualizarTutorYES()
        {
            conectar = Conexion.Cnn();
            String consulta = "Update Maestros set Tutor = 1, Grado_t = (select GRADO.IdGrado from GRADO where Grado= '" + CB_TGrado.Text + "' ), Seccion_t = (select SECCION.IdSeccion from SECCION where Seccion= '" + CB_TSeccion.Text + "' ), Estado = 1 Where IdMaestro = '" + ID + "'";
            cmd = new SqlCommand(consulta, conectar);
            cmd.ExecuteNonQuery();
            conectar.Close();
        }

        private void ActurTTutorNO()
        {
            conectar = Conexion.Cnn();
            String consulta = "Update Maestros set Tutor = 0, Grado_t = 1, Seccion_t = 1 Where IdMaestro = '" + ID + "'";
            cmd = new SqlCommand(consulta, conectar);
            cmd.ExecuteNonQuery();
            conectar.Close();
        }

        private void ActurTTutorYES()
        {
            conectar = Conexion.Cnn();
            String consulta = "Update Maestros set Tutor = 1, Grado_t = (select GRADO.IdGrado from GRADO where Grado= '" + CB_TGrado.Text + "' ), Seccion_t = (select SECCION.IdSeccion from SECCION where Seccion= '" + CB_TSeccion.Text + "' ) Where IdMaestro = '" + ID + "'";
            cmd = new SqlCommand(consulta, conectar);
            cmd.ExecuteNonQuery();
            conectar.Close();
        }

        private void ActualizarNGM()
        {
            conectar = Conexion.Cnn();
            String consulta = "DeletedNGM";
            cmd = new SqlCommand(consulta, conectar);
            cmd.Parameters.AddWithValue("@idMaestro", ID);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            conectar.Close();

            String grado = "", materia = "", seccion = "";
            for (int i = 0; i < DGV_g_m.Rows.Count; i++)
            {
                grado = DGV_g_m[0, i].Value.ToString();
                materia = DGV_g_m[1, i].Value.ToString();
                seccion = DGV_g_m[2, i].Value.ToString();
                conectar = Conexion.Cnn();
                String consulta2 = "IngresarNGM";
                cmd = new SqlCommand(consulta2, conectar);
                cmd.Parameters.AddWithValue("@IdMaestro", ID);
                cmd.Parameters.AddWithValue("@Grado", grado);
                cmd.Parameters.AddWithValue("@Materia", materia);
                cmd.Parameters.AddWithValue("@seccion", seccion);
                cmd.Parameters.AddWithValue("@estado", 1);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();
                conectar.Close();
            }
        }

        ////////////////////////////////////////////////////////////
        //////////////////////// VALIDACIONES

        private void VerloDeTutor()
        {
            //verificar Tutor
            if (verificarTutorUpdate(CB_TGrado, CB_TSeccion, chTutor))//todo corecto
            {
                //ver lod e ngm
                a2 = 1;
                //CAMBIAR TUTOR
            }
            else
            {
                a2 = 0;
                //mjs de que hay otro
            }
        }

        private void VerLodeNGMS()
        {
            if (G.Length == DGV_g_m.Rows.Count)//misma cantidad
            {
                if (cambioNGMS())//si son iguales
                {
                    //no hay cambio d NGMS
                    MessageBox.Show("No hay cambio de Materias a impartir", "CAMBIOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    a3 = 2;
                }
                else
                {
                    //aqui verificar NGM
                    if (VerificarNGMS())//si todo correto
                    {
                        ////// SOLO CAMBIAR NGMS
                        a3 = 1;
                    }
                }
            }
            else//diferencte cantidad
            {
                //verificarNGM
                if (VerificarNGMS())//si todo corrcto update
                {
                    //
                    //CAMBIAR NGMS
                    a3 = 1;
                }
            }
        }

        private bool verificarTutorUpdate(ComboBox ComBGrado, ComboBox ComBSeccion, CheckBox ChecBTutor)
        {
            if (ChecBTutor.Checked == true)
            {
                conectar = Conexion.Cnn();
                String valor = "", consulta = "Ver_TutorExitst";
                cmd = new SqlCommand(consulta, conectar);
                cmd.Parameters.AddWithValue("@grado", ComBGrado.Text.Trim());
                cmd.Parameters.AddWithValue("@seccion", ComBSeccion.Text.Trim());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    valor = dr["IdMaestro"].ToString();
                    //MessageBox.Show("" + dr["Estado"].ToString());
                }
                conectar.Close();
                if (valor == "") return true;
                else
                {
                    if (valor == ID)
                    {
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Ya existe un tutor para esa Grado y seccion", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            else return true;
        }

        private bool VerificarNGMS()
        {
            String mjs = "", grado = "", materia = "", seccion = "", consulta, valor = "";
            for (int i = 0; i < DGV_g_m.Rows.Count; i++)
            {
                grado = DGV_g_m[0, i].Value.ToString();
                materia = DGV_g_m[1, i].Value.ToString();
                seccion = DGV_g_m[2, i].Value.ToString();
                conectar = Conexion.Cnn();
                consulta = "Verificar_NGM";
                cmd = new SqlCommand(consulta, conectar);
                cmd.Parameters.AddWithValue("@grado", grado);
                cmd.Parameters.AddWithValue("@materia ", materia);
                cmd.Parameters.AddWithValue("@seccion ", seccion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    valor = dr["Maestro"].ToString();
                    if (valor != "" && valor != ID)
                    {
                        mjs = mjs + String.Format("Grado:   {0}\nMateria: {1}\nSeccion: {2}\n\n", grado, materia, seccion);
                    }
                }
                conectar.Close();
            }
            if (valor != "" && mjs != "")
            {
                MessageBox.Show("Ya existen Docente/s impartiendo las siguientes materias:\n\n" + mjs + "\n\nPara eliminarlas haga Doble Click sobre la celda", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else return true;
        }

        private bool cambioNGMS()
        {
            if (G.Length > 0)
            {
                int señal = 0;
                for (int i = 0; i < G.Length; i++)
                {
                    if (G[i] != DGV_g_m[0, i].Value.ToString() || M[i] != DGV_g_m[1, i].Value.ToString() || S[i] != DGV_g_m[2, i].Value.ToString())
                    {
                        señal = 1;
                    }
                }
                if (señal == 0) return true;
                else return false;
            }
            else return false;
        }
        ////////////////////////////////////////////////////////////
        ////////////////////////////// ELIMINAR DOCENTE

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de eliminar a este Docente?", "ELIMNAR DOCENTE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                conectar = Conexion.Cnn();
                String consulta1 = "Delete from Usuarios where Usuario = '" + ID + "'";
                cmd = new SqlCommand(consulta1, conectar);
                cmd.ExecuteNonQuery();
                conectar.Close();

                conectar = Conexion.Cnn();
                String consulta = "DeletedNGM";
                cmd = new SqlCommand(consulta, conectar);
                cmd.Parameters.AddWithValue("@idMaestro", ID);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();
                conectar.Close();

                conectar = Conexion.Cnn();
                String consulta2 = "DeletedDocente";
                cmd = new SqlCommand(consulta2, conectar);
                cmd.Parameters.AddWithValue("@idMaestro", ID);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();
                conectar.Close();
                MessageBox.Show("El Docente... \n\nHa sido Eliminado", "Docente Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            LBDocentes.Items.Clear();
            llenado();
            orden();
            Limpiar();
        }

        //////////////////////////////
    }
}
