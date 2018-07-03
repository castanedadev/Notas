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
        private int Señal1, Señal2;

        public ActualizarDocente()
        {
            InitializeComponent();
        }

        private void ActualizarDocente_Load(object sender, EventArgs e)
        {
            LBDocentes.Items.Add("HOLA");
            llenado();
            orden();
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
        }

        private void mostrarDatos(String nombre)
        {
            String valor = ""; valor = conocerEstado(valor, nombre);
            //////////////////  ACTIVO-INACTIVO
            if (valor == "1")
            {
                Veractivo(1);
                Señal1 = 1;
                valor = ConocerTipoTutor(valor, nombre);
                //////////////////  TUTOR- NO TUTOR
                if (valor == "1")
                {
                    Señal2 = 1;
                    chTutor.Checked = true;
                    GB_tutor.Visible = true;
                }
                else
                {
                    Señal2 = 0;
                    chTutor.Checked = false;
                    GB_tutor.Visible = false;
                }
                verNGM(nombre);
            }
            else
            {
                Veractivo(0);
                Señal1 = 0;
            }
        }

        private void verNGM(String nombre)
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
            MessageBox.Show(valor + "");
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
                chTutor.Visible = false;
                GB_tutor.Visible = false;
                GB_NGMS.Visible = false;
            }
            else
            {
                chEstado.Text = "ACTIVO";
                chTutor.Visible = true;
                GB_tutor.Visible = true;
                GB_NGMS.Visible = true;
            }
        }

        ////////////////////////////////////////////////////////////
        //////////////////////// ACTUALIZAR
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void Actualizar()
        {
            if (activo == 1) //es activo
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
                                //VER lo NGM
                                VerLodeNGMS();
                                //NO CAMBIRA TUTOR
                            }
                            else//DIFERENTE TUTOR
                            {
                                //VER LO DE TUTOR
                                VerloDeTutor();
                            }
                        }
                        else//ES Y no era tutor
                        {
                            //VER LO DE TUTOR
                            VerloDeTutor();
                        }
                    }
                    else// NO ES TUTOR
                    {
                        if (Señal2 == 1)//NO ES Y ERA TUTOR
                        {
                            //ACTUALIZAR LO DE DOCENTE DE QUE YA NO 
                            //Y DESPUED VER LO DE NGM
                            VerLodeNGMS();
                        }
                        else//NO ES TUTOR Y NO ERA TUTOR
                        {
                            //MJS DE QUE NO CAMBIO DE TUTOR
                            //VER LO DE NGMS
                            VerLodeNGMS();
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
                        VerLodeNGMS();
                    }
                    else
                    {
                        //VER LO DE NGM
                        VerLodeNGMS();
                    }
                }
            }
            else
            {//ESCOGIO QUE SERA EL PROFE ------ INACTIVO
                //ACTUALIZAR TUTR
                //ACTULIZAR -DELTE NGMS
                //ACTUALIZAR DATOD EL WEY EN ESTADO
            }
        }

        private void VerloDeTutor()
        {
            //verificar Tutor
            if (true)//todo corecto
            {
                //ver lod e ngm
                VerLodeNGMS();
                //CAMBIAR TUTOR
            }
            else
            {
                //mjs de que hay otro
            }
        }

        private void VerLodeNGMS()
        {
            if (G.Length == DGV_g_m.Rows.Count)//misma cantidad
            {
                if (true)//si son iguales
                {
                    //no hay cambio d NGMS
                }
                else
                {
                    //aqui verificar NGM
                    if (true)//si todo correto
                    {
                        ////// SOLO CAMBIAR NGMS
                    }
                    else
                    {
                        //aqui hay otro profe dando esa maeria
                    }
                }
            }
            else//diferencte cantidad
            {
                //verificarNGM
                if (true)//si todo corrcto update
                {
                    //
                    //CAMBIAR NGMS
                    //
                }
                else
                {
                    //aqui hay otro profe dando esa maeria
                }
            }
        }

        //////////////////////////////
    }
}
