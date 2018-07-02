using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Menu : Form
    {
      
        Actividades ac ;
        Form1 f1 ;
        FormAlumnos fa;
        CuadroFinal cf;
        Docente d;
        public string nombre;
        Procesos p = new Procesos();
        AcercaD acerca;

        public Menu()
        {
            InitializeComponent();                      
        }
       
        private void planificarActividadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ac == null)
            {
                ac = new Actividades();
                ac.MdiParent = this;
                ac.FormClosed += new FormClosedEventHandler(ac_FormClosed);
                ac.Show();
                if (fa != null) { fa.Close(); }
                if (cf != null) { cf.Close(); }
                if (f1 != null) { f1.Close(); }
                if (d != null) { d.Close(); }
                if (acerca != null) { acerca.Close(); }
            }
            else
            {
                ac.Activate();
            }         
        }
        public void ac_FormClosed(object sender, EventArgs e)
        {
            ac = null;
        }
        public void f1_FormClosed(object sender, EventArgs e)
        {
            f1 = null;
        }
        public void fa_FormClosed(object sender, EventArgs e)
        {
            fa = null;
        }
        public void cf_FormClosed(object sender, EventArgs e)
        {
            cf = null;
        }
        public void d_FormClosed(object sender, EventArgs e)
        {
            d = null;
        }

        private void acerca_FormClosed(object sender, FormClosedEventArgs e)
        {
            acerca = null;
        }
        
        private void cuadroDeActividadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (f1 == null)
            {
                f1 = new Form1();
                f1.MdiParent = this;
                f1.FormClosed += new FormClosedEventHandler(f1_FormClosed);
                f1.Show();
                if (fa != null) { fa.Close(); }
                if (cf != null) { cf.Close(); }
                if (d != null) { d.Close(); }
                if (ac != null) { ac.Close(); }
                if (acerca != null) { acerca.Close(); }
            }
            else
            {
                f1.Activate();
            }
        }



        private void registroDeAlumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (fa == null)
            {
                fa = new FormAlumnos();
                fa.MdiParent = this;
                fa.FormClosed += new FormClosedEventHandler(fa_FormClosed);
                fa.Show();
                if (d != null) { d.Close(); }
                if (cf != null) { cf.Close(); }
                if (f1 != null) { f1.Close(); }
                if (ac != null) { ac.Close(); }
                if (acerca != null) { acerca.Close(); }
            }
            else
            {
                fa.Activate();
            }
        }

        private void reporteDeNotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cf == null)
            {
                cf = new CuadroFinal();
                cf.MdiParent = this;
                cf.FormClosed += new FormClosedEventHandler(cf_FormClosed);
                cf.Show();

                if (fa != null) { fa.Close(); }
                if (d != null) { d.Close(); }
                if (f1 != null) { f1.Close(); }
                if (ac != null) { ac.Close(); }
                if (acerca != null) { acerca.Close(); }
            }
            else
            {
                cf.Activate();
            }          
        }

        private void datosDelDocenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (d == null)
            {
                d = new Docente();
                d.MdiParent = this;
                d.FormClosed += new FormClosedEventHandler(d_FormClosed);
                d.Show();
                if (fa != null) { fa.Close(); }
                if (cf != null) { cf.Close(); }
                if (f1 != null) { f1.Close();}
                if (ac != null) { ac.Close(); }
                if (acerca != null) { acerca.Close(); }
            }
            else
            {
                d.Activate();
            }           
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (acerca == null)
            {
                acerca = new AcercaD();
                acerca.MdiParent = this;
                acerca.FormClosed += new FormClosedEventHandler(acerca_FormClosed);
                acerca.Show();
                if (fa != null) { fa.Close(); }
                if (cf != null) { cf.Close(); }
                if (f1 != null) { f1.Close(); }
                if (ac != null) { ac.Close(); }
            }
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            p.nombreusu(Usuario.usuario, lblusu);
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DirectorGraficos dg = new DirectorGraficos();
            dg.Show();
        }
       
    }
}
