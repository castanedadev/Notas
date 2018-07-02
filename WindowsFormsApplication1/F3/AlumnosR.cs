using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.F3
{
    public partial class AlumnosR : Form
    {
        Procesos pr = new Procesos();
    
        HabilitacionKeyPress hp = new HabilitacionKeyPress();
        F2.PropiedadAlumno alumno = new F2.PropiedadAlumno();
        ProdTraslado pr1 = new ProdTraslado();

        public AlumnosR()
        {
            InitializeComponent();
            
        }
        public AlumnosR(F2.PropiedadAlumno n)
        {
            InitializeComponent();
            alumno = n as F2.PropiedadAlumno;
            txtTelefono.KeyPress += Telefono_KeyPress;
            txtResponsable.KeyPress += Responsable_KeyPress;
            LlenarCombos();
            LlenarCampos();

        }

        internal void LlenarCampos()
        {
            txtNIE.Text = alumno.Nie;
            txtNom.Text = alumno.Nombre;
            dTDFechaN.Text = alumno.Fechanac;
            txtTelefono.Text = alumno.Telefono;
            txtDic.Text = alumno.Direccion;
            txtResponsable.Text = alumno.Responsable;

            cbGrado.SelectedIndex = alumno.Grado - 2;
            cbSeccion.SelectedIndex = alumno.Seccion - 2;

        
        }

        internal void LlenarCombos()
        {
            pr.LlenarGrados(cbGrado);
            string consulta="SELECT * FROM SECCION WHERE IdSeccion!=1";
            pr1.LlenarCombo1(cbSeccion, consulta, "Seccion");
        
        }
      

      

       
      
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (!VeCampos())
                return;

            if (cbGrado.SelectedIndex == -1 || cbGrado.SelectedIndex == -1)
            {
                MessageBox.Show("El alumno debe tener asignado grado y sección", "Error", MessageBoxButtons.OK
                    , MessageBoxIcon.Error);
                return;
            
            }
            if (txtTelefono.Text == "" || txtTelefono.Text.Length > 8)
            {
                errorProvider1.SetError(txtTelefono, "Campo inválido");
                return;
            }
            else
                errorProvider1.Clear();


            alumno.Telefono = txtTelefono.Text;
            alumno.Direccion = txtDic.Text;
            alumno.Responsable = txtResponsable.Text;
            alumno.Grado = cbGrado.SelectedIndex + 2;
            alumno.Seccion = cbSeccion.SelectedIndex + 2;

            this.Close();



        }

     


        private void cbSeccion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        internal bool VeCampos()
        {
            foreach (TextBox item in groupBox1.Controls)
            {

                if (item.Text == "")
                {
                    errorProvider1.SetError(item, "Campo inválido");
                    return false;
                }
                else
                {
                    errorProvider1.Clear();
                }
            }


            return true;
        }

       
        private void Telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            hp.NoNumeros(sender, e);
        
        }

        private void Responsable_KeyPress(object sender, KeyPressEventArgs e)
        {
            hp.SoloTxt(sender, e);
            hp.nopuntuacion(sender, e);
        }
        






    }
}
