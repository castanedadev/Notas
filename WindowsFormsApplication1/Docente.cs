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
    public partial class Docente : Form
    {
        Procesos call = new Procesos();
        private SqlConnection conectar;
        private SqlCommand cmd;
        private SqlDataAdapter adap;
        private SqlDataAdapter adap1;
        private SqlDataReader dr;
        private String ID = "", Nombre = "";
        private int num_ran, tutor, tutor2 = 0, tuaux = 0, sen = 0, nocambios = 0;
        private Random rd = new Random();
        private String telefono, direccion, grado1, seccion, USU, CONTRA, ids;
        private String[] grado2, materia2, seccion2;

        public Docente()
        {
            InitializeComponent();            
        }

        private void Docente_Load(object sender, EventArgs e)
        {
            call.LlenarGrados(ComBGrado2);
            call.LlenarGrados(comboG_B);
            call.LlenarGrados(comboG2_B);
            DGV_g_m.Columns.Add("suda", "Grado");
            DGV_g_m.Columns.Add("suda2", "Materia");
            DGV_g_m.Columns.Add("suda3", "Seccion");
            DGV2.Columns.Add("suda", "Grado");
            DGV2.Columns.Add("suda2", "Materia");
            DGV2.Columns.Add("suda3", "Seccion");
            ComBSeccion.Enabled = false;
            ComBMateria.Enabled = false;   
        }

        private void ChecBTutor_CheckedChanged(object sender, EventArgs e)
        {
            if (ChecBTutor.Checked == true)
            {
                GB_tutor.Visible = true;
                call.Limpiarcb(ComBGrado);
                call.LlenarGrados(ComBGrado);
                tutor = 1;
            }
            else
            {
                GB_tutor.Visible = false;
                call.Limpiarcb(ComBGrado);
                call.Limpiarcb(ComBSeccion);
                tutor = 0;
            }
        }

        private void ComBGrado_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComBSeccion.Enabled = true;
            call.Limpiarcb(ComBSeccion);
            call.LlenarSeccion(ComBSeccion, ComBGrado);
        }

        private void ComBGrado2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComBMateria.Enabled = true;
            call.Limpiarcb(ComBMateria);
            call.LlenarMaterias(ComBMateria, ComBGrado2);            
        }

        private void ComBMateria_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBNGS.Enabled = true;
            ComboBNGS.Items.Clear();
            call.Limpiarcb(ComboBNGS);
            call.LlenarSeccion(ComboBNGS, ComBGrado2);
        }

        private void cmb1seccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBNGS.Text != "" && ComBGrado2.Text != "" && ComBMateria.Text != "") 
            {
                if (MessageBox.Show("   ¿ Desea Agregar ?\n\n Grado:   " + ComBGrado2.Text + "\n Materia: " + ComBMateria.Text + "\n Seccion: " + ComboBNGS.Text, "Agregar Grado y materia", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DGV_g_m.Rows.Add(ComBGrado2.Text, ComBMateria.Text, ComboBNGS.Text);
                }
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (valido())
            {
                conseguirID();
                if (verificarTutor(ComBGrado, ComBSeccion, ChecBTutor))
                {
                    if (VerificarContra())
                    {
                        Verificar_Grado_Mateira(); 
                    }
                }
            }
            else MessageBox.Show("Por favor Ingrese todos los datos requeridos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private bool VerificarContra()
        {
            String contra1 = txtContra.Text.Trim(), contra2 = txtContraConfirmar.Text.Trim();
            if (contra1 == contra2) return true;
            else
            {
                MessageBox.Show("No coinciden las contraseñas\nVerficar...", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void conseguirID()
        {
            String apel1 = txtApellido1.Text.ToUpper(), apel2 = txtApellido2.Text.ToUpper();
            num_ran = rd.Next(0, 9999);
            ID = apel1[0].ToString() + apel2[0].ToString() + DateTime.Now.Year.ToString();
            if (num_ran < 10) ID = ID + num_ran + "000";
            if (num_ran < 100) ID = ID + num_ran + "00";
            if (num_ran < 1000) ID = ID + num_ran + "0";
            else ID = ID + num_ran;
            txtDui.Text = ID;
            Nombre = txtApellido1.Text + " " + txtApellido2.Text + " " + txtNombre.Text;
        }

        private void Verificar_Grado_Mateira()
        {
            String mjs = "", grado = "", materia = "", consulta, valor = "", seccion = "";
            //primero verificar
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
                    if (valor != "")
                    {
                        mjs = mjs + String.Format("Grado:   {0}\nMateria: {1}\nSeccion:  {2}\n\n", grado, materia,seccion);
                    }
                }
                conectar.Close();
            }
            if (valor != "") MessageBox.Show("Ya existen Docente/s impartiendo las siguientes materias:\n\n" + mjs + "\n\nPara eliminarlas haga Doble Click sobre la celda", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                //ingresar sus datos y ya despues
                //ingresar las materias y no habra pedo ya
                IngresarDocenteData();
            }
        }

        private void IngresarDocenteData()
        {
            conectar = Conexion.Cnn();
            String consulta = "IngresarDocente";
            cmd = new SqlCommand(consulta, conectar);
            cmd.Parameters.AddWithValue("@tutor", tutor);
            cmd.Parameters.AddWithValue("@idMaestro", ID);
            cmd.Parameters.AddWithValue("@Nombre", Nombre);
            cmd.Parameters.AddWithValue("@fecha", TimeFecha.Text);
            cmd.Parameters.AddWithValue("@telefono", txtTelefono.Text.Trim());
            cmd.Parameters.AddWithValue("@direccion", txtDireccion.Text.Trim());
            cmd.Parameters.AddWithValue("@Grado", ComBGrado.Text);
            cmd.Parameters.AddWithValue("@seccion", ComBSeccion.Text);
            cmd.Parameters.AddWithValue("@estado", 1);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            conectar.Close();
            MessageBox.Show("Datos Docente Validos");
            IngresarNGM();

            conectar = Conexion.Cnn();
            consulta = "insert into Usuarios values(@usu,@pass,@tipo)";
            cmd = new SqlCommand(consulta, conectar);
            cmd.Parameters.AddWithValue("@usu", ID);
            cmd.Parameters.AddWithValue("@pass", txtContra.Text.Trim());
            cmd.Parameters.AddWithValue("@tipo", 2);
            cmd.ExecuteNonQuery();
            conectar.Close();
            MessageBox.Show("Ha sido sido registrado\n\nUsuario:       " + ID + "\nContraseña:  " + txtContra.Text.Trim(), "Docente Registrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtDui.Clear();
            txtNombre.Clear();
            txtApellido1.Clear();
            txtApellido2.Clear();
            txtTelefono.Clear();
            txtDireccion.Clear();
            txtContra.Clear();
            txtContraConfirmar.Clear();
            ChecBTutor.Checked = false;
            DGV_g_m.Rows.Clear();
        }

        private void IngresarNGM()
        {
            String grado = "", materia = "", seccion = "";
            for (int i = 0; i < DGV_g_m.Rows.Count; i++)
            {
                grado = DGV_g_m[0, i].Value.ToString();
                materia = DGV_g_m[1, i].Value.ToString();
                seccion = DGV_g_m[2, i].Value.ToString();
                conectar = Conexion.Cnn();
                String consulta = "IngresarNGM";
                cmd = new SqlCommand(consulta, conectar);
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

        private bool verificarTutor(ComboBox ComBGrado, ComboBox ComBSeccion, CheckBox ChecBTutor)
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
                }
                conectar.Close();
                if (valor == "") return true;
                else
                {
                    MessageBox.Show("Ya existe un tutor para esa Grado y seccion", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else return true;
        }

        private bool valido()
        {
            if (txtNombre.Text != "" && txtApellido1.Text != "" && txtTelefono.Text != "" && txtDireccion.Text != "" && DGV_g_m.Rows.Count > 0 && txtContra.Text != "" && txtContraConfirmar.Text != "")
            {
                if (ChecBTutor.Checked == true)
                {
                    if (ComBGrado.Text != "" && ComBSeccion.Text != "")
                    {
                        return true;
                    }
                    else return false;
                }
                else return true;
            }
            else return false;
        }

        private void DGV_g_m_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (MessageBox.Show("Grado:    " + DGV_g_m.Rows[e.RowIndex].Cells[0].Value + "\nMateria: " + DGV_g_m.Rows[e.RowIndex].Cells[1].Value + "\nSeccion: " + DGV_g_m.Rows[e.RowIndex].Cells[2].Value + "\n\n¿Dese eliminar estos datos?", "ELIMINAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DGV_g_m.Rows.RemoveAt(e.RowIndex);
            }
            //DGV_g_m.CurrentCell.Value = "";
            //DGV_g_m.Rows[e.RowIndex].Cells[0].Value = "";
            //DGV_g_m.Rows[e.RowIndex].Cells[1].Value = "";
            //DGV_g_m.Rows.RemoveAt(e.RowIndex);
            //DGV_g_m.Rows.RemoveAt(DGV_g_m.CurrentCell);
            //MessageBox.Show(DGV_g_m.SelectedRows.IsReadOnly + "");
        }
        ////////////////////////////////////////////////////////////////
        //ver

        private void button1_Click_1(object sender, EventArgs e)
        {
            panel1.Visible = true;
            if (verficarID(txtUsuB.Text.Trim(), txtContraseña2.Text.Trim()))
            {
                Datos_Docente();
                MessageBox.Show("Datos cargados exitosamente", "Carga completa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                button1.Visible = false;
            }
            else MessageBox.Show("No existe ese ID  faliida", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private bool verficarID(String id,String contra)
        {
            conectar = Conexion.Cnn();
            String usuC = "", contraC = "", consulta = "select * from Usuarios where Usuario = '" + id + "' and Pass = '" + contra + "'";
            adap = new SqlDataAdapter(consulta, conectar);
            SqlParameter prm = new SqlParameter("Usuario", SqlDbType.VarChar);
            SqlParameter prm2 = new SqlParameter("Pass", SqlDbType.VarChar);//
            prm.Value = id;
            prm2.Value = contra;//
            adap.SelectCommand.Parameters.Add(prm);
            adap.SelectCommand.Parameters.Add(prm2);
            dr = adap.SelectCommand.ExecuteReader();
            while (dr.Read())
            {
                usuC = dr["Usuario"].ToString().Trim();
                contraC = dr["Pass"].ToString().Trim();
            }
            conectar.Close();
            USU = usuC; CONTRA = contraC;
            if (usuC != "" && contraC != "") { txtContraB.Text = CONTRA; panel1.Hide(); return true; }
            else { MessageBox.Show("Usuario o Contraseña invalidos"); return false; }
        }

        private void Datos_Docente()
        {
            ids = "";
            tutor2 = 0;
            String valor = "", id = txtUsuB.Text.Trim();
            valor = conocerEstado(valor, id);
            if (valor == "1")
            {
                chEstado.Checked = true;
                chEstado.Text = "Activo";
                inavilitar(1);
                valor = ConocerTipoTutor(valor, id);
                if (valor == "0")
                {
                    conectar = Conexion.Cnn();
                    String consulta2 = "select IdMaestro, Nombre, Fecha,Telefono, Direccion, Estado from Maestros where IdMaestro = '" + id + "'";
                    adap1 = new SqlDataAdapter(consulta2, conectar);
                    SqlParameter prm2 = new SqlParameter("IdMaestro", SqlDbType.VarChar);
                    prm2.Value = id;
                    adap1.SelectCommand.Parameters.Add(prm2);
                    dr = adap1.SelectCommand.ExecuteReader();
                    while (dr.Read())
                    {
                        chEstado.Checked = true;
                        chEstado.Text = "Activo";
                        chb_tu.Checked = false;
                        ids = dr["IdMaestro"].ToString();
                        txtN.Text = dr["Nombre"].ToString();
                        txtFec.Text = dr["Fecha"].ToString();
                        txtUser.Text = ids;
                        txtTeleB.Text = dr["Telefono"].ToString();
                        txtDirB.Text = dr["Direccion"].ToString();
                    }
                    conectar.Close();
                    sen = 0;
                }
                else
                {
                    conectar = Conexion.Cnn();
                    String consulta1 = "consultaMaestroData";
                    cmd = new SqlCommand(consulta1, conectar);
                    cmd.Parameters.AddWithValue("@id", txtUsuB.Text.Trim());
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.ExecuteNonQuery();
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        tutor2 = 1;
                        chEstado.Checked = true;
                        chEstado.Text = "Activo";
                        ids = dr["IdMaestro"].ToString();
                        txtN.Text = dr["Nombre"].ToString();
                        txtFec.Text = dr["Fecha"].ToString();
                        txtUser.Text = ids;
                        txtTeleB.Text = dr["Telefono"].ToString();
                        txtDirB.Text = dr["Direccion"].ToString();
                        chb_tu.Checked = true;
                        comboG_B.Text = dr["Grado"].ToString();
                        comboS_B.Text = dr["Seccion"].ToString();
                    }
                    conectar.Close();
                    sen = 1;
                }

                telefono = txtTeleB.Text;
                direccion = txtDirB.Text;
                if (tutor2 == 1)
                {
                    grado1 = comboG_B.Text;
                    seccion = comboS_B.Text;
                }
                VerNGM();
            }
            else
            {
                chEstado.Checked = false;
                chEstado.Text = "Inactivo";
                inavilitar(0);
                conectar = Conexion.Cnn();
                String consulta2 = "select IdMaestro, Nombre, Fecha,Telefono, Direccion from Maestros where IdMaestro = '" + id + "'";
                adap1 = new SqlDataAdapter(consulta2, conectar);
                SqlParameter prm2 = new SqlParameter("IdMaestro", SqlDbType.VarChar);
                prm2.Value = id;
                adap1.SelectCommand.Parameters.Add(prm2);
                dr = adap1.SelectCommand.ExecuteReader();
                while (dr.Read())
                {
                    ids = dr["IdMaestro"].ToString();
                    txtN.Text = dr["Nombre"].ToString();
                    txtFec.Text = dr["Fecha"].ToString();
                    txtUser.Text = ids;
                    txtTeleB.Text = dr["Telefono"].ToString();
                    txtDirB.Text = dr["Direccion"].ToString();
                }
                conectar.Close();
                telefono = txtTeleB.Text;
                direccion = txtDirB.Text;
            }
            
        }

        private void inavilitar(int v)
        {
            if (v == 0) 
            {
                chb_tu.Enabled = false;
                comboG_B.Enabled = false;
                comboS_B.Enabled = false;
                comboG2_B.Enabled = false;
                comboM_B.Enabled = false;
                ComboNGS_B.Enabled = false;
                chb_tu.Visible = false;
                groupBox1.Visible = false;
                groupBox3.Visible = false;
                
            }
            else
            {
                chb_tu.Enabled = true;
                comboG_B.Enabled = true;
                comboS_B.Enabled = true;
                comboG2_B.Enabled = true;
                comboM_B.Enabled = true;
                ComboNGS_B.Enabled = true;
                chb_tu.Visible = true;
                groupBox1.Visible = true;
                groupBox3.Visible = true;
            }
            
        }

        private string conocerEstado(string valor, string id)
        {
            conectar = Conexion.Cnn();
            String consulta = "select Estado from Maestros where IdMaestro = '" + id + "'";
            adap = new SqlDataAdapter(consulta, conectar);
            SqlParameter prm = new SqlParameter("IdMaestro", SqlDbType.VarChar);
            prm.Value = id;
            adap.SelectCommand.Parameters.Add(prm);
            dr = adap.SelectCommand.ExecuteReader();
            while (dr.Read())
            {
                valor = dr["Estado"].ToString().Trim();
            }
            MessageBox.Show(valor + "");
            conectar.Close();
            return valor;
        }

        private void VerNGM()
        {
            DGV2.Rows.Clear();
            conectar = Conexion.Cnn();
            String consulta1 = "VerNGM";
            cmd = new SqlCommand(consulta1, conectar);
            cmd.Parameters.AddWithValue("@id", ids);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                DGV2.Rows.Add(dr["Grado"].ToString(), dr["Materia"].ToString(),dr["Seccion"].ToString());
            }
            conectar.Close();
            grado2 = new String[DGV2.Rows.Count];
            materia2 = new String[DGV2.Rows.Count];
            seccion2 = new String[DGV2.Rows.Count];
            for (int i = 0; i < DGV2.Rows.Count; i++)
            {
                grado2[i] = DGV2[0, i].Value.ToString();
                materia2[i] = DGV2[1, i].Value.ToString();
                seccion2[i] = DGV2[2, i].Value.ToString();
            }
        }

        private String ConocerTipoTutor(String valor, String id)
        {
            conectar = Conexion.Cnn();
            String consulta = "select Tutor from Maestros where IdMaestro = '" + id + "'";
            adap = new SqlDataAdapter(consulta, conectar);
            SqlParameter prm = new SqlParameter("IdMaestro", SqlDbType.VarChar);
            prm.Value = id;
            adap.SelectCommand.Parameters.Add(prm);
            dr = adap.SelectCommand.ExecuteReader();
            while (dr.Read())
            {
                valor = dr["tutor"].ToString().Trim();
            }
            conectar.Close();
            return valor;
        }

        private void chb_tu_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chb_tu.Checked == true)
            {
                groupBox3.Show();
                call.Limpiarcb(comboG_B);
                call.LlenarGrados(comboG_B);
                tuaux = 1;
            }
            else
            {
                groupBox3.Hide();
                call.Limpiarcb(comboG_B);
                call.Limpiarcb(comboS_B);
                tuaux = 0;
            }
        }

        private void chEstado_CheckedChanged(object sender, EventArgs e)
        {
            if (chEstado.Checked == true) 
            {
                chEstado.Text = "Activo";
                inavilitar(1);
            }
            else
            {
                chEstado.Text = "Inactivo";
                inavilitar(0);
            }
        }

        //actualizar

        private void button2_Click(object sender, EventArgs e)
        {
            if (chEstado.Checked == false)
            {
                if (CONTRA != txtContraB.Text)
                {
                    if (txtContraB.Text == txtContra2B.Text)
                    {
                        updateSinestado();
                    }
                    else MessageBox.Show("Las contraseñas no coinciden", "Eror de contraseña", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    updateSinestado();
                }
            }
            else
            {
                if (DGV2.Rows.Count > 0)
                {
                    if (ExistenCambios())
                    {
                        if (verificarTutorUpdate(comboG_B, comboS_B, chb_tu))
                        {
                            if (verificar2_NGM())
                            {
                                if (CONTRA != txtContraB.Text)
                                {
                                    if (txtContraB.Text == txtContra2B.Text)
                                    {
                                        Realizar_Actualizacion();
                                    }
                                    else MessageBox.Show("Las contraseñas no coinciden", "Eror de contraseña", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                {
                                    Realizar_Actualizacion();
                                }
                            }
                            else
                            {
                                if (nocambios == 1)
                                {
                                    Limpiar();
                                    panel1.Show();
                                    txtUsuB.Clear();
                                    txtContraseña2.Clear();
                                    button1.Show();
                                }
                                else MessageBox.Show("No actualizado");
                            }
                        }
                    }
                    else
                    {
                        if ((sen == 1 && tuaux == 1) && (grado1 == comboG_B.Text && seccion == comboS_B.Text))
                        {
                            if (verificar2_NGM())
                            {
                                Realizar_Actualizacion();
                            }
                            else
                            {
                                if (nocambios == 1)
                                {
                                    Limpiar();
                                    panel1.Show();
                                    txtUsuB.Clear();
                                    txtContraseña2.Clear();
                                    button1.Show();
                                }
                                else MessageBox.Show("No hay cambio");
                            }
                        }
                        else
                        {
                            MessageBox.Show("No se realiazo ningún cambio");
                            Limpiar();
                            panel1.Show();
                            txtUsuB.Clear();
                            txtContraseña2.Clear();
                            button1.Show();
                        }
                    }
                }
                else MessageBox.Show("Debe Ingresar el Grado y la materia a impartir", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);       
            }
        }

        private void updateSinestado()
        {
            conectar = Conexion.Cnn();
            String consulta = "Update Usuarios set Pass = '" + txtContraB.Text.Trim() + "' where Usuario = '" + ids + "'";
            cmd = new SqlCommand(consulta, conectar);
            cmd.ExecuteNonQuery();
            conectar.Close();

            conectar = Conexion.Cnn();
            String consulta2 = "Update Maestros set Telefono = '" + txtTeleB.Text + "', Direccion = '" + txtDirB.Text + "',Estado = 2 where IdMaestro = '" + ids + "'";
            cmd = new SqlCommand(consulta2, conectar);
            cmd.ExecuteNonQuery();
            conectar.Close();

            conectar = Conexion.Cnn();
            String consulta3 = "Update NGM set Estado = 2 where Maestro = '" + ids + "'";
            cmd = new SqlCommand(consulta3, conectar);
            cmd.ExecuteNonQuery();
            conectar.Close();
            
            MessageBox.Show("Datos Docente Validos");
            MessageBox.Show("Docente Actualizado", "Actualizacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ids = "";
            Limpiar();
            panel1.Show();
            txtUsuB.Clear();
            txtContraseña2.Clear();
            button1.Show();
            LimpiarVectores();
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
                    MessageBox.Show(""+dr["Estado"].ToString());
                }
                conectar.Close();
                if (valor == "") return true;
                else
                {
                    if (valor == ids)
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

        private void Limpiar()
        {
            txtN.Clear();
            txtFec.Clear();
            txtUser.Clear();
            txtTeleB.Clear();
            txtDirB.Clear();
            txtContraB.Clear();
            txtContra2B.Clear();
            chb_tu.Checked = false;
            DGV2.Rows.Clear();
        }

        private void Realizar_Actualizacion()
        {
            conectar = Conexion.Cnn();
            String consulta = "UpdateDocente";
            cmd = new SqlCommand(consulta, conectar);
            cmd.Parameters.AddWithValue("@tutor", tuaux);
            cmd.Parameters.AddWithValue("@idMaestro", txtUsuB.Text);
            cmd.Parameters.AddWithValue("@telefono", txtTeleB.Text.Trim());
            cmd.Parameters.AddWithValue("@direccion", txtDirB.Text.Trim());
            cmd.Parameters.AddWithValue("@Grado", comboG_B.Text);
            cmd.Parameters.AddWithValue("@seccion", comboS_B.Text);
            cmd.Parameters.AddWithValue("@estado", 1);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            conectar.Close();
            MessageBox.Show("Datos Docente Validos");
            ActualizarNGM();
            ActualizarUsu();
            MessageBox.Show("Docente Actualizado", "Actualizacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ids = "";
            Limpiar();
            panel1.Show();
            txtUsuB.Clear();
            txtContraseña2.Clear();
            button1.Show();
            LimpiarVectores();
        }

        private void LimpiarVectores()
        {
            for (int i = 0; i < grado2.Length; i++) 
            {
                materia2[i] = null;
                grado2[i] = null;
                seccion2[i] = null;
            }
        }

        private void ActualizarUsu()
        {
            if (CONTRA != txtContraB.Text.Trim()) 
            {
                conectar = Conexion.Cnn();
                String consulta = "Update Usuarios set Pass = '" + txtContraB.Text.Trim() + "' where Usuario = '" + ids + "'";
                cmd = new SqlCommand(consulta, conectar);
                cmd.ExecuteNonQuery();
                conectar.Close();              
            }
        }

        private void ActualizarNGM()
        {
            conectar = Conexion.Cnn();
            String consulta = "DeletedNGM";
            cmd = new SqlCommand(consulta, conectar);
            cmd.Parameters.AddWithValue("@idMaestro", ids);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            conectar.Close();

            String grado = "", materia = "",seccion="";
            for (int i = 0; i < DGV2.Rows.Count; i++)
            {
                grado = DGV2[0, i].Value.ToString();
                materia = DGV2[1, i].Value.ToString();
                seccion = DGV2[2, i].Value.ToString();
                conectar = Conexion.Cnn();
                String consulta2 = "IngresarNGM";
                cmd = new SqlCommand(consulta2, conectar);
                cmd.Parameters.AddWithValue("@IdMaestro", ids);
                cmd.Parameters.AddWithValue("@Grado", grado);
                cmd.Parameters.AddWithValue("@Materia", materia);
                cmd.Parameters.AddWithValue("@seccion", seccion);
                cmd.Parameters.AddWithValue("@estado", 1);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();
                conectar.Close();
            }
        }

        private bool verificar2_NGM()
        {
            nocambios = 0;
            if (DGV2.Rows.Count != grado2.Length) señal2 = 1;
            else
            {
                for (int i = 0; i < DGV2.Rows.Count; i++)
                {
                    if (grado2[i] != DGV2[0, i].Value.ToString() || materia2[i] != DGV2[1, i].Value.ToString() || seccion2[i] != DGV2[2, i].Value.ToString())
                    {
                        señal2 = 1;
                    }
                    else señal2 = 0;
                }
            }

            if (señal2 == 0)
            {
                if (señal3 == 1)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("No hay cambios  de Grado Materia");
                    nocambios = 1;
                    return false;
                }
            }
            else
            {
                String mjs = "", grado = "", materia = "",seccion="" ,consulta, valor = "";
                for (int i = 0; i < DGV2.Rows.Count; i++)
                {
                    grado = DGV2[0, i].Value.ToString();
                    materia = DGV2[1, i].Value.ToString();
                    seccion = DGV2[2, i].Value.ToString();
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
                        if (valor != "" && valor != ids)
                        {
                            mjs = mjs + String.Format("Grado:   {0}\nMateria: {1}\nSeccion: {2}\n\n", grado, materia,seccion);
                        }
                    }
                    conectar.Close();
                }
                if (valor != "" && mjs != "")
                {
                    MessageBox.Show("Ya existen Docente/s impartiendo las siguientes materias:\n\n" + mjs + "\n\nPara eliminarlas haga Doble Click sobre la celda", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        int señal = 0, señal2 = 0, señal3 = 0;
        private bool ExistenCambios()
        {
            señal = 0;
            señal3 = 0;
            if (telefono != txtTeleB.Text || direccion != txtDirB.Text || CONTRA != txtContraB.Text || DGV2.Rows.Count != grado2.Length)
            {
                señal3 = 1;
                return true;
            }
            else if (sen == 1 && tuaux == 0)
            {
                señal3 = 1;
                return true;
            }
            else if ((sen == 1 && tuaux == 1) && (grado1 != comboG_B.Text || seccion != comboS_B.Text))
            {
                señal3 = 1;
                return true;
            }
            else if ((sen == 1 && tuaux == 1) && (grado1 == comboG_B.Text && seccion == comboS_B.Text))
            {
                return false;
            }
            else if (sen == 0 && tuaux == 1)
            {
                señal3 = 1;
                return true;
            }
            else
            {//caso 0-0
                if (DGV2.Rows.Count == grado2.Length)
                {
                    for (int i = 0; i < DGV2.Rows.Count; i++)
                    {
                        if (grado2[i] != DGV2[0, i].Value.ToString() || materia2[i] != DGV2[1, i].Value.ToString() || seccion2[i] != DGV2[2, i].Value.ToString())
                        {
                            señal = 1;
                        }
                        else señal = 0;
                    }
                }
                if (señal == 1)
                {
                    señal3 = 1;
                    return true;
                }
                else return false;
            }

        }

        private void comboG_B_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboS_B.Enabled = true;
            call.Limpiarcb(comboS_B);
            call.LlenarSeccion(comboS_B, comboG_B);
        }

        private void comboG2_B_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboM_B.Enabled = true;            
            call.Limpiarcb(comboM_B);
            call.LlenarMaterias(comboM_B, comboG2_B);            
        }

        private void comboM_B_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboNGS_B.Enabled = true;
            call.Limpiarcb(ComboNGS_B);
            call.LlenarSeccion(ComboNGS_B, comboG2_B);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (verficarID(txtIDBorrar.Text.Trim(), txtContrarBorrar.Text.Trim())) 
            {
                conectar = Conexion.Cnn();
                String consulta1 = "Delete from Usuarios where Usuario = '" + txtIDBorrar.Text + "'";
                cmd = new SqlCommand(consulta1, conectar);
                cmd.ExecuteNonQuery();
                conectar.Close();

                conectar = Conexion.Cnn();
                String consulta = "DeletedNGM";
                cmd = new SqlCommand(consulta, conectar);
                cmd.Parameters.AddWithValue("@idMaestro", txtIDBorrar.Text);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();
                conectar.Close();

                conectar = Conexion.Cnn();
                String consulta2 = "DeletedDocente";
                cmd = new SqlCommand(consulta2, conectar);
                cmd.Parameters.AddWithValue("@idMaestro", txtIDBorrar.Text);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();
                conectar.Close();
                MessageBox.Show("Docente: " + txtIDBorrar.Text + "\n\nHa sido Eliminado", "Docente Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtIDBorrar.Clear();
                txtContrarBorrar.Clear();
                panel1.Show();
            }
        }

        private void DGV2_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (MessageBox.Show("Grado:    " + DGV2.Rows[e.RowIndex].Cells[0].Value + "\nMateria: " + DGV2.Rows[e.RowIndex].Cells[1].Value + "\nSeccion: " + DGV2.Rows[e.RowIndex].Cells[2].Value + "\n\n¿Dese eliminar estos datos?", "ELIMINAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DGV2.Rows.RemoveAt(e.RowIndex);
            }
        }



        private void irALoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            Menu m = new Menu();
            l.Show();
            this.Close();
            m.Close();
        }


        private void cmbseccion2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboM_B.Text != "" && comboG2_B.Text != "" && ComboNGS_B.Text != "")
            {
                if (MessageBox.Show("   ¿ Desea Agregar ?\n\n Grado:   " + comboG2_B.Text + "\n Materia: " + comboM_B.Text + "\n Seccion: " + ComboNGS_B.Text, "Agregar Grado y materia", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) 
                {
                    DGV2.Rows.Add(comboG2_B.Text, comboM_B.Text,ComboNGS_B.Text);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            IngresarDocente call = new IngresarDocente();
            call.Show();
        }

        


        


        
    }
}
