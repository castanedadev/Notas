using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Properties;

namespace WindowsFormsApplication1
{
    public partial class MenuDIC : Form
    {
        Procesos pro = new Procesos();
        public MenuDIC()
        {
            InitializeComponent();
            pro.nombreusu(Usuario.usuario, LblUser);
            colocar();
            Dcolor();
        }

        ////////////////////////////////////////////////////////////
        ////////////  BOTONES
        int v1 = 0;
        private void btn1_Click(object sender, EventArgs e)
        {
            if (v1 == 0) { panel1.Show(); panel2.Hide(); v2 = 0; panel3.Hide(); v3 = 0; panel4.Hide(); v4 = 0; v1 = 1; panel5.Hide(); v5 = 0; }
            else { panel1.Hide(); v1 = 0; }
        }

        int v2 = 0;
        private void btn2_Click(object sender, EventArgs e)
        {
            if (v2 == 0) { panel2.Show(); panel1.Hide(); v1 = 0; panel3.Hide(); v3 = 0; panel4.Hide(); v4 = 0; v2 = 1; panel5.Hide(); v5 = 0; }
            else { panel2.Hide(); v2 = 0; }
        }

        int v3 = 0;
        private void btn3_Click(object sender, EventArgs e)
        {
            if (v3 == 0) { panel3.Show(); panel1.Hide(); v1 = 0; panel2.Hide(); v2 = 1; panel4.Hide(); v4 = 0; v3 = 1; panel5.Hide(); v5 = 0; }
            else { panel3.Hide(); v3 = 0; }
        }

        int v4 = 0;
        private void btnConfiguration_Click(object sender, EventArgs e)
        {
            if (v4 == 0) { panel4.Show(); panel1.Hide(); v1 = 0; panel2.Hide(); v2 = 0; panel3.Hide(); v3 = 0; v4 = 1; panel5.Hide(); v5 = 0; } else { panel4.Hide(); v4 = 0; }
        }
        int v5 = 0;
        private void btn5_Click(object sender, EventArgs e)
        {
            if (v5 == 0) { panel5.Show(); panel4.Hide(); ; panel1.Hide(); v1 = 0; panel2.Hide(); v2 = 0; panel3.Hide(); v3 = 0; v4 = 0; v5 = 1; } else { panel5.Hide(); v5 = 0; }
            
        }
        ////////////////////// BOTONES SIN BTN-S

        private void btn4_Click(object sender, EventArgs e)
        {
            panel4.Hide(); ; panel1.Hide(); v1 = 0; panel2.Hide(); v2 = 0; panel3.Hide(); v3 = 0; v4 = 0; panel5.Hide(); v5 = 0;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            panel4.Hide(); ; panel1.Hide(); v1 = 0; panel2.Hide(); v2 = 0; panel3.Hide(); v3 = 0; v4 = 0; panel5.Hide(); v5 = 0;
            mostrar(new AcercaD());
        }   
        ////////////////////////////////////////////////////////////////////////////////////
        ////////////////////// MOSTRAR FORMS
        private void mostrar(object frm)
        {
            if (this.PnlContenido.Controls.Count > 0)
                this.PnlContenido.Controls.RemoveAt(0);

            Form formu = frm as Form;
            formu.TopLevel = false;
            formu.Dock = DockStyle.None;
            this.PnlContenido.Controls.Add(formu);
            this.PnlContenido.Tag = formu;
            formu.Location = new System.Drawing.Point(350, 50);
            formu.BackColor = PnlContenido.BackColor;
            formu.Show();
        }

        ////////////////////// BOTONES CON BTN-S

        private void btn1_1_Click(object sender, EventArgs e)
        {
            panel1.Hide(); v1 = 0;
            mostrar(new Acti());
        }

        private void btn1_2_Click(object sender, EventArgs e)
        {
            panel1.Hide(); v1 = 0;
            mostrar(new Form1());
        }

        private void btn2_1_Click(object sender, EventArgs e)
        {
            panel2.Hide(); v2 = 0;
            mostrar(new CuadroFinal());
        }

        private void btn3_1_Click(object sender, EventArgs e)
        {
            panel3.Hide(); v3 = 0;
            mostrar(new ActualizarDocente());
        }

        private void btn5_1_Click(object sender, EventArgs e)
        {
            panel5.Hide(); v5 = 0;
            DirectorGraficos call = new DirectorGraficos();
            call.ShowDialog();
        }

        private void btn5_2_Click(object sender, EventArgs e)
        {
            panel5.Hide(); v5 = 0;
        }

        /////////////////////////// BTN-S DEFECTO
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn3_2_Click(object sender, EventArgs e)
        {
            panel3.Hide(); v3 = 0;
            mostrar(new IngresarDocente());
        }

        private void btn1_3_Click(object sender, EventArgs e)
        {
            panel1.Hide(); v1 = 0;
            mostrar(new FormAlumnos());
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro se querer Cerrar Sesion?", "CERRAR SESION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Login call = new Login();
                this.Hide();
                call.ShowDialog();
                this.Close();
            }
        }
        ////////////////////////////////////////////////////////////////////////
        //////////////////////// FONDOS

        private void Dcolor()
        {
            switch (Settings.Default.FondoDic)
            {
                case 1:
                    PnlContenido.BackColor = Fondo1.BackColor;
                    break;
                case 2:
                    PnlContenido.BackColor = Fondo2.BackColor;
                    break;
                case 3:
                    PnlContenido.BackColor = Fondo3.BackColor;
                    break;
                case 4:
                    PnlContenido.BackColor = Fondo4.BackColor;
                    break;
                case 5:
                    PnlContenido.BackColor = Fondo5.BackColor;
                    break;
                case 6:
                    PnlContenido.BackColor = Fondo6.BackColor;
                    break;
                default:
                    PnlContenido.BackColor = Color.Gray;
                    break;
            }
        }

        private void colocar()
        {
            this.Height = 700;
            this.Width = 1365;
            Pnl1.Width = this.Width;
            Pnl2.Width = this.Width;
            PnlContenido.Width = this.Width - 10;
            PnlContenido.Height = this.Height - 90;
            btnCerrar.Location = new System.Drawing.Point(Pnl1.Width - btnCerrar.Width, 0);
            btnMinimizar.Location = new System.Drawing.Point(Pnl1.Width - btnCerrar.Width - btnMinimizar.Width, 0);
            btnConfiguration.Location = new System.Drawing.Point(Pnl2.Width - btnConfiguration.Width, 0);
            panel2.Location = new System.Drawing.Point(panel2.Location.X, 63);
            panel4.Location = new System.Drawing.Point(this.Width - panel4.Width, 63);
            panel5.Location = new System.Drawing.Point(panel5.Location.X, 63);
            panel1.Hide(); panel2.Hide(); panel3.Hide(); panel4.Hide(); panel5.Hide();
        }

        private void Fondo1_Click(object sender, EventArgs e)
        {
            PnlContenido.BackColor = Fondo1.BackColor;
            Settings.Default.FondoDic = 1; Settings.Default.Save();
        }

        private void Fondo2_Click(object sender, EventArgs e)
        {
            PnlContenido.BackColor = Fondo2.BackColor;
            Settings.Default.FondoDic = 2; Settings.Default.Save();
        }

        private void Fondo3_Click(object sender, EventArgs e)
        {
            PnlContenido.BackColor = Fondo3.BackColor;
            Settings.Default.FondoDic = 3; Settings.Default.Save();
        }

        private void Fondo4_Click(object sender, EventArgs e)
        {
            PnlContenido.BackColor = Fondo4.BackColor;
            Settings.Default.FondoDic = 4; Settings.Default.Save();
        }

        private void Fondo5_Click(object sender, EventArgs e)
        {
            PnlContenido.BackColor = Fondo5.BackColor;
            Settings.Default.FondoDic = 5; Settings.Default.Save();
        }

        private void Fondo6_Click(object sender, EventArgs e)
        {
            PnlContenido.BackColor = Fondo6.BackColor;
            Settings.Default.FondoDic = 6; Settings.Default.Save();
        }
            

        ////////////////////////////////////////////
    }
}
