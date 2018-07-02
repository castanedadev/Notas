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
namespace WindowsFormsApplication1.F1
{
    public partial class DirectorPerfil : Form
    {
        HabilitacionKeyPress kp = new HabilitacionKeyPress();
       private SqlConnection conectar;
       private SqlCommand cmd;
        public DirectorPerfil()
        {
            InitializeComponent();
            
        }
        Form pad;
        public DirectorPerfil(Form da)
        {
            InitializeComponent();
            pad = da as Form;
        
        }
     



        private void Continuar_Click(object sender, EventArgs e)
        {

            foreach (Bunifu.Framework.UI.BunifuMetroTextbox item in panel1.Controls)
            {
                if (item.Text == "")
                {
                    errorProvider1.SetError(item, "Falta rellenar este campo");
                    item.Focus();
                    return;
                }
                else
                {
                    errorProvider1.Clear();
                }

            }

            if (!correo())
            {
                errorProvider1.SetError(Correo, "Correo ingresado incorrectamente");
                return;
            }
            else
                errorProvider1.Clear();


            if (!contraseñas())
            {
                errorProvider1.SetError(ConContraseña, "Las contraseñas no coinciden");
                return;
            }
            else
                errorProvider1.Clear();
            if (Telefono.Text.Length > 8)
            {
                Telefono.Focus();
                return;
            }


            SqlConnection cnn = ConexionK.Cnn();

            string cadena = "INSERT INTO  Director VALUES ('" + Usuario.Text + "','" + Nombre.Text + "','" +
                Correo.Text + "','" + Contraseña.Text + "',1,'" + Telefono.Text + "')";

            try
            {
                SqlCommand cmm = new SqlCommand(cadena, cnn);
                cnn.Open();
                cmm.ExecuteNonQuery();
                cnn.Close();

                ////USUARIO
                conectar = Conexion.Cnn();
                string consulta = "insert into Usuarios values(@usu,@pass,@tipo)";
                cmd = new SqlCommand(consulta, conectar);
                cmd.Parameters.AddWithValue("@usu", Usuario.Text);
                cmd.Parameters.AddWithValue("@pass", Contraseña.Text.Trim());
                cmd.Parameters.AddWithValue("@tipo", 1);
                cmd.ExecuteNonQuery();
                conectar.Close();


                this.Hide();
                pad.Hide();
                F_Splash.MN.padre.Hide();
                Login fh = new Login();
                fh.ShowDialog();
                F_Splash.MN.padre.Close();               
            }
            catch
            {
                cnn.Close();            
            }
        }

        private void DirectorPerfil_Load(object sender, EventArgs e)
        {            
            Continuar.Click += new System.EventHandler(Continuar_Click);
            Nombre.KeyPress += Nombre_KeyPress;
            Usuario.KeyPress += Usuario_KeyPress;
            Correo.KeyPress+=Correo_KeyPress;
            Contraseña.KeyPress += Contraseña_KeyPress;
            ConContraseña.KeyPress += Contraseña_KeyPress;
            Telefono.KeyPress += Telefono_KeyPress;
        }

        internal bool contraseñas()
        {
            if (Contraseña.Text != ConContraseña.Text)
                return false;
            else
                return true;

        }
        internal bool correo()
        {
            string corre = Correo.Text;
            int arroba=0;
            int punto = 0;

            if (corre.Contains("@"))
            {
                arroba = 1;
            }
            if (corre.Contains("."))
            {
                punto = 1;
            }


            if (arroba == 1 && punto == 1)
                return true;
            else
                return false;
            
        
        }
      

        private void Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {

            kp.SoloTxt(sender, e);
        
        }
        private void Usuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            kp.nopuntuacion(sender, e);
            kp.NoEs(sender, e);
        }
        private void Correo_KeyPress(object sender, KeyPressEventArgs e)
        {
            kp.SoloPuntoyArroba(sender, e);
            kp.NoEs(sender, e);

        
        }

        private void Contraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            kp.nopuntuacion(sender, e);
            kp.NoEs(sender, e);
        
        }
        
        private void Telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            kp.NoNumeros(sender, e);
            kp.NoSimbolos(sender, e);
            if (Telefono.Text.Length >8)
            {
                Telefono.Focus();
                errorProvider2.SetError(Telefono, "Ingresar teléfono con 8 cifras");
                return;
            }
            else
            {
                errorProvider2.Clear();
            }

        }






    }
}
