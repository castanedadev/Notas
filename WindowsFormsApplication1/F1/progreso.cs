using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu;
using BunifuAnimatorNS;
using System.Threading;
using System.Diagnostics;
using System.Data.SqlClient;

namespace WindowsFormsApplication1.F1
{
    public partial class progreso : Form
    {
        bool baux = true;
        bool baux2 = false;       
        SqlConnection conn;
        private int cont = 0;

        public progreso()
        {            
            InitializeComponent();
            InicializarInstancia();
            F_Splash.MN.padre = this;
            this.BackColor = Color.White;
            ocultos();          
        }

        internal void InicializarInstancia()
        {
            string cmmd;
            cmmd = "/k sqllocaldb create Escuelas && sqllocaldb start Escuelas  && exit";
            System.Diagnostics.Process.Start("CMD.exe", cmmd);
            string cadena2 = "server=(localdb)\\Escuelas;database=master;integrated security=yes";
            SqlConnection conn2 = new SqlConnection(cadena2);

            try
            {
                conn2.Open();
                conn2.Close();
                baux2 = true;
                string cadena1 = "Server=(localdb)\\Escuelas;uid=;pwd=;database=Escuela";
                conn = new SqlConnection(cadena1);
                try
                {
                    conn.Open();
                    conn.Close();
                    baux = true;
                }
                catch
                {
                    baux = false;
                }
            }
            catch
            {
                baux2 = false;
            }
        }

        private void progreso_Load(object sender, EventArgs e)
        {
            if (baux2 == false)
            {
                MessageBox.Show("Se ha perdido la conexión con el servidor\n Reinicie el programa", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
      
        internal void Abrir( )
        {            
            Limpiar();
        }

        Panel PanelPadre = new Panel();

        internal void Limpiar()
        {
            this.Controls.Clear();
            PanelPadre.Name = "Padre";
            PanelPadre.Dock = DockStyle.Fill;
            PanelPadre.Visible = false;
            if (baux == false)
            {
                F1.Entrada1 Fh = new F1.Entrada1(this);
                AbrirPanel1(Fh, PanelPadre);
                this.Controls.Add(PanelPadre);
                Thread.Sleep(100);
                Transition1.ShowSync(PanelPadre);
            }
            else
            {
                Login fh = new Login();
                this.Hide();
                fh.ShowDialog();
                this.Close();
            }
        }

        public void AbrirPanel1(object pan, object panel)
        {
            Panel PanelPapa1 = panel as Panel;
            if (PanelPapa1.Controls.Count > 0)
                PanelPapa1.Controls.RemoveAt(0);
            Form fh = pan as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.Width = fh.Width;
            this.Height = fh.Height;
            fh.FormBorderStyle = FormBorderStyle.None;
            PanelPapa1.Controls.Add(fh);
            PanelPapa1.Tag = fh;
            fh.Show();
        }

       //////////////////////////////////////////////////////////////////////////////////////////////
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            //switch (cont)
            //{
            //    case 0:
            //        timer1.Enabled = true;
            //        cont = 1;
            //        break;
            //    case 1:
            //        Transition2.ShowSync(panel1);
            //        Procesos(0);
            //        timer1.Enabled = true;
            //        cont = 2;
            //        break;
            //    case 2:
            //        Procesos(1);
            //        timer1.Enabled = false;
            //        timer1.Stop();
            cont = 3;
            //        break;
            //}
            if (cont == 3)
            {
                timer1.Enabled = false;
                timer1.Stop();
                Abrir();
            }
        }

        private void Procesos(int p)
        {
            if (p == 0)
            {
                this.BackColor = Color.Aquamarine;
                Transition1.ShowSync(Lbl1);
                this.BackColor = Color.MidnightBlue;
                Transition1.ShowSync(Lbl2);
                this.BackColor = Color.SkyBlue;
                Transition1.ShowSync(Lbl3);
                this.BackColor = Color.Gold;
                panel1.Hide();
                mover(203, 0);
            }

            if (p == 1)
            {
                this.BackColor = Color.Green;
                Transition1.ShowSync(Lbl4);
                this.BackColor = Color.Teal;
                Transition1.ShowSync(Lbl5);
                this.BackColor = Color.Orange;
                Transition4.ShowSync(PLogoES);
                this.BackColor = Color.PaleGreen;
                Transition2.ShowSync(LblMateria);
                this.BackColor = Color.YellowGreen;
                Transition2.ShowSync(LblProyect);
                this.BackColor = Color.White;
                Transition3.ShowSync(panel1);
                this.BackColor = Color.White;
                this.BackColor = Color.White;
                this.BackColor = Color.White;
            }
        }

        private void mover(int p, int df)
        {
            if (df == 0)
            {
                panel1.Location = new System.Drawing.Point(p, 10);
                Refresh();
            }
        }        

        private void ocultos()
        {
            panel1.Hide();
            Lbl1.Hide();
            Lbl2.Hide();
            Lbl3.Hide();
            Lbl4.Hide();
            Lbl5.Hide();
            LblMateria.Hide();
            LblProyect.Hide();
            PLogoES.Hide();
            progressBar1.Location = new System.Drawing.Point(660, 0);
            panel1.Location = new System.Drawing.Point(-100, 10);
        }
        //////////////////////////////////////////////////////////////////////////////////////////////


    }
}
