using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.F1
{
    public partial class Principal : Form
    {
      
        F_Splash.MN obj = new F_Splash.MN();

        public Principal()
        {
            InitializeComponent();
        }
        System.Windows.Forms.Form pad = new System.Windows.Forms.Form();
        public Principal(System.Windows.Forms.Form da)
        {
            InitializeComponent();
            pad = da as System.Windows.Forms.Form;
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            pad.Close();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            Neg_General obj = new Neg_General();
            

        }

 
        private void pictureBox2_Click(object sender, EventArgs e)
        {

            //Neg_General obj = new Neg_General();
            //if (c < 3)
            //{
            //    obj.ResizeForm(this, 768, 1366);
            //    this.Location = new Point(this.Location.X - 80, this.Location.Y - 15);
            //    c++;
            //}

          
            obj.Maximizar(this);
            pictureBox2.Visible = false;
            pictureBox3.Visible = true;

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            obj.Restaurar(this);
            pictureBox3.Visible = false;
            pictureBox2.Visible = true;

        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            obj.MouseEnterPictureBox(pictureBox1, 3, 2);
        }
        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            obj.MouseLeavePictureBox(pictureBox1, 3, 2);
        }
        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            obj.MouseEnterPictureBox(pictureBox2, 3, 2);
        }
        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            obj.MouseLeavePictureBox(pictureBox2, 3, 2);
        }
        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            obj.MouseEnterPictureBox(pictureBox3, 3, 2);
        }
        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            obj.MouseLeavePictureBox(pictureBox3, 3, 2);
        }
        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            obj.MouseEnterPictureBox(pictureBox4, 3, 2);
        }
        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            obj.MouseLeavePictureBox(pictureBox4, 3, 2);
        }
        

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void verCuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            completo.Visible = false;
            Docente fh = new Docente();
            obj.AbrirPanel1(fh, completo);
            bunifuTransition1.ShowSync(completo);
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            bunifuTransition1.ShowSync(bunifuFlatButton2);
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {

            bunifuFlatButton1.Visible = false;
        }



    }
}
