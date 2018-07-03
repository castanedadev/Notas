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
    public partial class Rep1 : Form
    {
        public Rep1()
        {
            InitializeComponent();
            btnRProfes.Click += new System.EventHandler(RecuperarProfes);
            btnRAl.Click += new System.EventHandler(RecuperarAlu);
        }

        private void RecuperarProfes(object sender, EventArgs e)
        {
            RecuperarProfesores fh = new RecuperarProfesores();
            this.Visible = false;
            fh.ShowDialog();
            this.Visible = true;
        
        }
        private void RecuperarAlu(object sender, EventArgs e)
        {
            RecuperarAlumnos fh = new RecuperarAlumnos();
            this.Visible = false;
            fh.ShowDialog();
            this.Visible = true;
        }


    }
}
