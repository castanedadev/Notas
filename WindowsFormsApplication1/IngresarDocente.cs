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
    public partial class IngresarDocente : Form
    {
        Procesos call = new Procesos();
        private SqlConnection conectar;
        private SqlCommand cmd;
        private SqlDataAdapter adap;
        private SqlDataReader dr;

        private int tutor = 0,num_ran;
        private String ID = "", Nombre = "";
        private Random rd = new Random();

        public IngresarDocente()
        {            
            InitializeComponent();            
            validacion();
        }

        private void validacion()
        {
            call.LlenarGrados(ComBGrado2);
            DGV_g_m.Columns.Add("suda", "Grado");
            DGV_g_m.Columns.Add("suda2", "Materia");
            DGV_g_m.Columns.Add("suda3", "Seccion");
            ComBSeccion.Enabled = false;
            ComBMateria.Enabled = false; 
        }

        //////////////////////////////////////////////////////////////////////
        //////////Opciones defecto

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
                if (MessageBox.Show("   ¿ Desea Agregar ?\n\n Grado:   " + ComBGrado2.Text + "\n Materia: " + ComBMateria.Text + "\n Seccion: " + ComboBNGS.Text, "Agregar Grado  Materia  Seccion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DGV_g_m.Rows.Add(ComBGrado2.Text, ComBMateria.Text, ComboBNGS.Text);
                }
            }
        }

        //////////////////////////////////////////////////////////////////////
        ////////// VALIDACION

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (valido())
            {
                conseguirID();
                if (VerificarNombre())
                {
                    if (verificarTutor(ComBGrado, ComBSeccion, ChecBTutor))
                    {
                        if (VerificarContra())
                        {
                            Verificar_Grado_Mateira();
                        }
                    }
                }
                else MessageBox.Show("Este Docente ya existe.\n\nVerifique que ha ingresado correctamente su Nombre-Apellido.\nCaso contrario este Docente ya existe en el sistema", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Por favor Ingrese todos los datos requeridos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private bool VerificarNombre()
        {
            conectar = Conexion.Cnn();
            String dato = "", consulta2 = "select  Nombre from Maestros ";
            adap = new SqlDataAdapter(consulta2, conectar);
            dr = adap.SelectCommand.ExecuteReader();
            while (dr.Read())
            {
                dato = dr["Nombre"].ToString();
            } conectar.Close();
            if (dato == Nombre) return false;
            else return true;
        }

        private bool valido()
        {
            if (txtNombre.Text != "" && txtApellido1.Text != "" && txtTelefono.Text != "" && txtDireccion.Text != "" && DGV_g_m.Rows.Count > 0 && txtContra.Text != "" && txtContraConfirmar.Text != "")
            {
                if (txtTelefono.TextLength != 8) { MessageBox.Show("\tIngrese un número de telefono valido\n\tDe 8 digitos", "E R R OR", MessageBoxButtons.OK, MessageBoxIcon.Error); return false; }
                if (ChecBTutor.Checked == true)
                {
                    MessageBox.Show("siempre aca");
                    if (ComBGrado.Text != "" && ComBSeccion.Text != "")
                    {
                        return true;
                    }
                    else return false;
                }
                else return true;
            }
            else { if (DGV_g_m.Rows.Count == 0) MessageBox.Show("Debe ingresar al menos una Materia Grado Seccion a Impartir", "E R R OR", MessageBoxButtons.OK, MessageBoxIcon.Error); return false; }  
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
            String apel1 = txtApellido1.Text.ToUpper(), apel2 = "";
            if (txtApellido2.Text != "") { apel2 = txtApellido2.Text.ToUpper(); }
            else { apel2 = apel1[1].ToString(); }
            num_ran = rd.Next(0, 9999);
            ID = apel1[0].ToString() + apel2[0].ToString() + DateTime.Now.Year.ToString();
            if (num_ran < 10) ID = ID + num_ran + "000";
            if (num_ran < 100) ID = ID + num_ran + "00";
            if (num_ran < 1000) ID = ID + num_ran + "0";
            else ID = ID + num_ran;
            Nombre = txtApellido1.Text + " " + txtApellido2.Text + " " + txtNombre.Text;
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
                        mjs = mjs + String.Format("Grado:   {0}\nMateria: {1}\nSeccion:  {2}\n\n", grado, materia, seccion);
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

        private void DGV_g_m_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (MessageBox.Show("Grado:    " + DGV_g_m.Rows[e.RowIndex].Cells[0].Value + "\nMateria: " + DGV_g_m.Rows[e.RowIndex].Cells[1].Value + "\nSeccion: " + DGV_g_m.Rows[e.RowIndex].Cells[2].Value + "\n\n¿Dese eliminar estos datos?", "ELIMINAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DGV_g_m.Rows.RemoveAt(e.RowIndex);
            }            
        }

        //////////////////////////////////////////////////////////////////////
        ////////// INGRESAR DATOS

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
            MessageBox.Show("Datos Docente Validos", "DATOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            IngresarNGM();

            conectar = Conexion.Cnn();
            consulta = "insert into Usuarios values(@usu,@pass,@tipo)";
            cmd = new SqlCommand(consulta, conectar);
            cmd.Parameters.AddWithValue("@usu", ID);
            cmd.Parameters.AddWithValue("@pass", txtContra.Text.Trim());
            cmd.Parameters.AddWithValue("@tipo", 2);
            cmd.ExecuteNonQuery();
            conectar.Close();
            MessageBox.Show("EL Docecnte ha sido sido registrado\nPor Favor tomar nota de los siguientes datos para que pueda acceder al sistema \n\nUsuario:       " + ID + "\nContraseña:  " + txtContra.Text.Trim(), "Docente Registrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtNombre.Clear();
            txtApellido1.Clear();
            txtApellido2.Clear();
            txtTelefono.Clear();
            txtDireccion.Clear();
            txtContra.Clear();
            txtContraConfirmar.Clear();
            ComBGrado.Text = "";
            ComBSeccion.Text = "";
            ComBGrado2.Text = "";
            ComBMateria.Text = "";
            ComboBNGS.Text = "";
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

        ////////////////////////////////////////////////////////////
    }
}
