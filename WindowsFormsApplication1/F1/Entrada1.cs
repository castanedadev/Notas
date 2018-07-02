using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Data.SqlClient;
namespace WindowsFormsApplication1.F1
{
    public partial class Entrada1 : Form
    {
        F_Splash.MN mt = new F_Splash.MN();
        public Entrada1()
        {
            InitializeComponent();

            //  F_Splash.MN.padre = this;        
        }
        Form pad;
        public Entrada1(System.Windows.Forms.Form da)
        {
            InitializeComponent();
            pad = da as Form;
         
        
        }

        private void prueba2_Load(object sender, EventArgs e)
        {
            //bunifuTransition1.ShowSync(pictureBox1);
            Continuar.Click += new System.EventHandler(Continuar_Click);
            
            //pictureBox1.Click += new System.EventHandler(Cerrar_Click);

            //pictureBox3.Click += new System.EventHandler(Max_Click);
            //pictureBox4.Click += new System.EventHandler(Restaurar_Click);

            bunifuCustomLabel2.Click += new System.EventHandler(labeltxt_Click);
            textBox1.TextChanged += new System.EventHandler(TextCambio);

            //pictureBox1.MouseEnter += new System.EventHandler(Btnx_MouseEnter);
            //pictureBox1.MouseLeave += new System.EventHandler(Btnx_MouseLeave);

            //pictureBox3.MouseEnter += new System.EventHandler(BtnM_MouseEnter);
            //pictureBox3.MouseLeave += new System.EventHandler(BtnM_MouseLeave);
            //pictureBox4.MouseEnter += new System.EventHandler(BtnR_MouseEnter);
            //pictureBox4.MouseLeave += new System.EventHandler(BtnR_MouseLeave);
        
        }
        private void labeltxt_Click(object sender, EventArgs e)
        {
            textBox1.Focus();
        
        }




        private void TextCambio(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                bunifuCustomLabel2.Visible = true;
            }
            else
            {
                bunifuCustomLabel2.Visible = false;
            }        
        }


        //private void Cerrar_Click(object sender, EventArgs e)
        //{
        //    this.Close();
        //}

        private void Continuar_Click(object sender, EventArgs e)
        {

            string aux = Application.StartupPath;
            CrearBD pr = new CrearBD(aux);
            CrearProcedimientos pr1 = new CrearProcedimientos(aux);

            pr.CrearBDTablas();
            MessageBox.Show("Base de datos creada correctamente..", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            pr1.CrearProcedures();
            MessageBox.Show("Procedimientos creados correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            pr1.Insertar();
            MessageBox.Show("Insertados", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            pr1.NombreE(textBox1.Text);


            F1.CrearBDRepositorio obj = new F1.CrearBDRepositorio(aux);
            F1.CrearProcediimentosRepositorio obj2 = new F1.CrearProcediimentosRepositorio(aux);
            obj.CrearBDTablas();
            obj2.CrearProcedures();
            obj2.Insertar();
            
            



            bunifuGradientPanel2.Dock = DockStyle.None;
            bunifuGradientPanel2.Width = 1;
            bunifuGradientPanel2.Height = 1;
            bunifuGradientPanel3.Dock = DockStyle.Fill;
            
            mt.AbrirPanel1(new DirectorPerfil(this), bunifuGradientPanel3);
            label1.Text = "Paso 2: Registrar datos del Director";
            bunifuTransition1.ShowSync(bunifuGradientPanel3);


        
        }

        private void prueba2_FormClosing(object sender, FormClosingEventArgs e)
        {
            pad.Close();

        }

        int c = 0;
        //private void Max_Click(object sender, EventArgs e)
        //{

        //    if (c <2)
        //    {
        //        mt.Maximizar(F_Splash.MN.padre);
        //        c++;

        //    }

        //}


        //private void Restaurar_Click(object sender, EventArgs e)
        //{

        //    if (c >= 0)
        //    {

        //        mt.Restaurar(F_Splash.MN.padre);
        //        c--;
            
        //    }

        //}

       //private void Btnx_MouseEnter(object sender ,EventArgs e)
       //{
       // mt.MouseEnterPictureBox(pictureBox1,2,2);
       //}
       //private void Btnx_MouseLeave(object sender, EventArgs e)
       //{
       //    mt.MouseLeavePictureBox(pictureBox1, 2, 2);
       //}

       private void bunifuImageButton1_Click(object sender, EventArgs e)
       {
           //this.WindowState = FormWindowState.Minimized;
           pad.WindowState = FormWindowState.Minimized;
       }

       private void bunifuImageButton2_Click(object sender, EventArgs e)
       {
           pad.Close();
       }
       //private void BtnM_MouseEnter(object sender, EventArgs e)
       //{
       //    mt.MouseEnterPictureBox(pictureBox3, 2, 2);
       //}

       //private void BtnM_MouseLeave(object sender, EventArgs e)
       //{
       //    mt.MouseLeavePictureBox(pictureBox3, 2, 2);
       //}

       //private void BtnR_MouseEnter(object sender, EventArgs e)
       //{
       //    mt.MouseEnterPictureBox(pictureBox4, 2, 2);
       //}

       //private void BtnR_MouseLeave(object sender, EventArgs e)
       //{
       //    mt.MouseLeavePictureBox(pictureBox4, 2, 2);
       //}

       //private void pictureBox1_Click(object sender, EventArgs e)
       //{

       //}

       //private void bunifuGradientPanel2_Paint(object sender, PaintEventArgs e)
       //{

       //}

       //private void button1_Click(object sender, EventArgs e)
       //{

       //    Docente fh = new Docente();

       //    F_Splash.MN.cerrar(); 
       //    fh.ShowDialog(); 
       //}



    }
}
