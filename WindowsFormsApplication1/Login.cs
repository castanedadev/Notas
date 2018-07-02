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
using System.Data.OleDb;

namespace WindowsFormsApplication1
{
    public partial class Login : Form
    {
        SqlCommand scmd;
        SqlDataReader sread;
        Procesos p = new Procesos();
        Actividades ac = new Actividades();
        public Login()
        {
            InitializeComponent();
           
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            if (TxtUser.Text != "")
            {
                if (TxtPass.Text != "")
                {
                        Ingreso();
                }
                else Error.SetError(TxtPass, "Ingrese la contraseña");
            }
            else Error.SetError(TxtUser, "Ingrese el usuario");
        }

        private void Ingreso()
        {
            string consulta;
            consulta = "ValidarEntrada";
            SqlConnection getconexion = Conexion.Cnn();
            scmd = new SqlCommand(consulta, getconexion);
            scmd.Parameters.AddWithValue("@usu", TxtUser.Text);
            scmd.Parameters.AddWithValue("@pass", TxtPass.Text);
            scmd.CommandType = CommandType.StoredProcedure;
            scmd.ExecuteNonQuery();
            sread = scmd.ExecuteReader();
            if (sread.Read())
            {
                if (sread["Usuario"].ToString() == TxtUser.Text && sread["Pass"].ToString() == TxtPass.Text)
                {
                    Menu m = new Menu();
                    this.Hide();

                    Usuario.usuario = TxtUser.Text;
                    m.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Datos no coinciden");
                TxtUser.Clear();
                TxtPass.Clear();
            }
            getconexion.Close();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (TxtUser.Text != "")
            {
                if (TxtPass.Text != "")
                {
                    if (e.KeyChar == Convert.ToChar(Keys.Enter))
                        Ingreso();
                }
                else Error.SetError(TxtPass, "Ingrese la contraseña");
            }
            else Error.SetError(TxtUser, "Ingrese el usuario");
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
