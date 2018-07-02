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
    public partial class RecuperarProfesores : Form
    {
        ProdTraslado mtd = new ProdTraslado();
        
        public RecuperarProfesores()
        {
            InitializeComponent();
            comboBox1.SelectedIndexChanged += new System.EventHandler(ComboBox1_SelectedIndexChanged);
            btnAgregarSimple.Click += new System.EventHandler(BtnAgregarUno_Click);
            btnAgregarMulti.Click += new System.EventHandler(BtnAgregarTodos_Click);
            btnRsimple.Click += new System.EventHandler(BtnRSimple_Click);
            btnRmulti.Click += new System.EventHandler(BtnRMulti_Click);
            btnVer.Click += new System.EventHandler(BtnVer_Click);
            btnContinuar.Click += new System.EventHandler(BtnRecuper_Click);
        }

        private void RecuperarProfesores_Load(object sender, EventArgs e)
        {
            mtd.LlenarCombo(comboBox1);
            comboBox1.SelectedIndex = 0;

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            mtd.LlenadoProfes(listBox1, comboBox1.Text);
            listBox2.Items.Clear();

        }


        private void BtnAgregarUno_Click(object sender, EventArgs e)
        {
            if (!MoverSimple(listBox1, listBox2))
                errorProvider1.SetError(btnAgregarSimple, "No hay profesores de respaldo");
            else
                errorProvider1.Clear();



        }
        private void BtnRSimple_Click(object sender, EventArgs e)
        {


            if (!MoverSimple(listBox2, listBox1))
                errorProvider1.SetError(btnRsimple, "No hay profesores agregados");
            else
                errorProvider1.Clear();

        }

        private void BtnAgregarTodos_Click(object sender, EventArgs e)
        {

            if (!MoverMulti(listBox1, listBox2))
                errorProvider1.SetError(btnAgregarMulti, "No hay profesores de resplado");
            else
                errorProvider1.Clear();
        }
        private void BtnRMulti_Click(object sender, EventArgs e)
        {
            if (!MoverMulti(listBox2, listBox1))
                errorProvider1.SetError(btnRmulti, "No hay profesores agregados");
            else
                errorProvider1.Clear();
        
        }


        internal bool MoverSimple(ListBox lbI, ListBox lbF)
        {
            ListBox LBI = lbI as ListBox;
            ListBox LBF = lbF as ListBox;

            if (LBI.Items.Count > 0)
            {
                List<string> nombres = new List<string>();
                for (int i = 0; i < LBI.Items.Count; i++)
                {
                    if (LBI.GetSelected(i) == true)
                    {


                        string g = ProdTraslado.rer[LBI.GetItemText(LBI.Items[i])].ToString();
                        F2.PropiedadMaestro actual = new F2.PropiedadMaestro();
                        actual = ProdTraslado.profes[int.Parse(g)];
                        string nombre = actual.Nombre;

                        LBI.SetSelected(i, false);
                        LBF.Items.Add(nombre);
                        nombres.Add(nombre);
                    }
                }

                foreach (string item in nombres)
                {
                    LBI.Items.Remove(item);
                }


                LBF.Sorted = true;
                return true;
            }
            else
            {
                return false;
            }
        
        
        
        }

        internal bool MoverMulti(ListBox lbI, ListBox lbF)
        {
            ListBox LBI = lbI as ListBox;
            ListBox LBF = lbF as ListBox;
            if (LBI.Items.Count > 0)
            {
                for (int i = 0; i < LBI.Items.Count; i++)
                {


                    string g = ProdTraslado.rer[LBI.GetItemText(LBI.Items[i])].ToString();
                    F2.PropiedadMaestro actual = new F2.PropiedadMaestro();
                    actual = ProdTraslado.profes[int.Parse(g)];
                    string nombre = actual.Nombre;

                    LBF.Items.Add(nombre);
                }

                LBI.Items.Clear();
                LBF.Sorted = true;
                return true;
            }
            else
                return false;
        }

        private void listBox2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listBox2.Text != "")
            {
                string profSelected;

                profSelected = ProdTraslado.rer[listBox2.Text].ToString();
                F2.PropiedadMaestro temp=ProdTraslado.profes[int.Parse(profSelected)];




                try
                {
                    DocenteR fh = new DocenteR(ProdTraslado.profes[int.Parse(profSelected)], ProdTraslado.pNGM[int.Parse(profSelected)]);
                    fh.ShowDialog();
                }
                catch
                {
                    DocenteR fh = new DocenteR(ProdTraslado.profes[int.Parse(profSelected)], null);
                    fh.ShowDialog();
                }
               


            }

        }

        private void BtnVer_Click(object sender, EventArgs e)
        {

            if (listBox2.Text != "")
            {
                string profSelected;

                profSelected = ProdTraslado.rer[listBox2.Text].ToString();
                F2.PropiedadMaestro temp = ProdTraslado.profes[int.Parse(profSelected)];




                try
                {
                    DocenteR fh = new DocenteR(ProdTraslado.profes[int.Parse(profSelected)], ProdTraslado.pNGM[int.Parse(profSelected)]);
                    fh.ShowDialog();
                }
                catch
                {
                    DocenteR fh = new DocenteR(ProdTraslado.profes[int.Parse(profSelected)], null);
                    fh.ShowDialog();
                }
            }
               
        
        }

        private void BtnRecuper_Click(object sender, EventArgs e)
        {


                string profSelected;


                foreach (string item in listBox2.Items)
                {

                    profSelected = ProdTraslado.rer[item].ToString();
                    F2.PropiedadMaestro temp = ProdTraslado.profes[int.Parse(profSelected)];
                    NGM temp1 = ProdTraslado.pNGM[int.Parse(profSelected)];
                    mtd.Recuperar(temp);
                    mtd.RecuperarNGM(temp1);
                
                
                }

                RPro fh = new RPro();
                this.Visible = false;
                fh.ShowDialog();
                this.Close();
        }


    }
}
