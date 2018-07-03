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
using System.IO;

namespace WindowsFormsApplication1.F2
{
    public partial class Eliminar : Form
    {
        Transferencia n = new Transferencia();
        
        public Eliminar()
        {
            InitializeComponent();
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cadena = "¿Está segura/o que desea enviar los registros al repositorio (Una vez enviados no se podrán editar) ?";
            DialogResult r = MessageBox.Show(cadena, "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            bool aux = n.comprobar(textBox1.Text, textBox2.Text);


            if (r == DialogResult.Yes)
            {
                if (aux == true)
                {
                    errorProvider1.Clear();
                    n.LlenarComboAño(comboBox1);
                    comboBox1.SelectedIndex = 0;
                    label1.Visible = false;
                    label1.Visible = false;
                    textBox1.Visible = false;
                    textBox2.Visible = false;
                    label3.Visible = true;
                    comboBox1.Visible = true;
                    button1.Visible = false;
                    button2.Visible = true;
                }
                else
                    errorProvider1.SetError(button1, "Usuario o contraseña ingreado incorrectamente");
            }
          

        }

            
        private void button5_Click(object sender, EventArgs e)
        {
            string cadena = "¿Está segura/o que desea ingresar los datos con el año: " + comboBox1.Text;
            DialogResult r = MessageBox.Show(cadena, "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (r == DialogResult.Yes)
            {

                MessageBox.Show("espere...");

                n.CrearIdAño(comboBox1.Text);

                n.RealizarTransFerencias();
                this.Close();
            }


        }

        private void Eliminar_Load(object sender, EventArgs e)
        {
            button1.Click += new System.EventHandler(button1_Click);
            button2.Click += new System.EventHandler(button5_Click);
        }
    }
}
