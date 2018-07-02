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
    public partial class RecuperarAlumnos : Form
    {
        Procesos mtd = new Procesos();
        ProdTraslado pd = new ProdTraslado();
        AlTraslado alu = new AlTraslado();
        public RecuperarAlumnos()
        {
            InitializeComponent();
            cmbGrado.Visible = false;
            cmbSeccion.Visible = false;
            pd.LlenarCombo(cmbAño);
            mtd.LlenarGrados(cmbGrado);
            string consulta=" SELECT * FROM Seccion WHERE IdSeccion!=1";
            pd.LlenarCombo1(cmbSeccion, consulta, "Seccion");

            cmbAño.SelectedIndexChanged += new System.EventHandler(ComAñoChange);
            cmbGrado.SelectedIndexChanged += new System.EventHandler(ComGradoChange);
            cmbSeccion.SelectedIndexChanged += new System.EventHandler(ComSeccionChange);

            btnAgregarSimple.Click += new System.EventHandler(btn_EnviarSimple);
            btnAgregarMulti.Click += new System.EventHandler(btn_EnviarMulti);
            btnRsimple.Click += new System.EventHandler(btn_RSimple);
            btnRmulti.Click += new System.EventHandler(btn_RMulti);

            btnVer.Click += new System.EventHandler(VerAvanzado_Click);
            btnContinuar.Click += new System.EventHandler(btnContinuar_Click);
            radioButton1.Checked = true;

        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            string AlSelected;


            foreach (string item in listBox2.Items)
            {

                AlSelected = AlTraslado.rer[item].ToString();
                F2.PropiedadAlumno temp = AlTraslado.alumnos[int.Parse(AlSelected)];

                alu.Recuperar(temp);

            }

            repe fh = new repe();
            this.Visible = false;
            fh.ShowDialog();
            this.Close();

            
        
        }

        private void ComAñoChange(object sender, EventArgs e)
        {
            if (cmbAño.SelectedIndex != -1)
            {
                cmbGrado.Visible = true;

            
            }
            else
                cmbGrado.Visible = false;

            if (cmbGrado.Visible == true && cmbSeccion.Visible == true)
            {
                if (cmbGrado.SelectedIndex != -1 && cmbGrado.SelectedIndex != -1 && cmbAño.SelectedIndex!=-1)
                {
                    RR();
                }
            
            }


            
        }
        private void ComGradoChange(object sender, EventArgs e)
        {
            if (cmbGrado.SelectedIndex != -1)
                cmbSeccion.Visible = true;
            else
            {
             
                cmbSeccion.Visible = false;
            }
            if (cmbSeccion.Visible == true)
            {
                if (cmbGrado.SelectedIndex != -1 && cmbGrado.SelectedIndex != -1 && cmbAño.SelectedIndex != -1)
                {
                    RR();
                }
            }


        }
        private void ComSeccionChange(object sender, EventArgs e)
        {
            if (cmbSeccion.SelectedIndex != -1)
            {
                int año = cmbAño.SelectedIndex + 1;
                int grado = cmbGrado.SelectedIndex + 2;
                int seccion = cmbSeccion.SelectedIndex + 2;
                alu.GetListBox(listBox1, año, grado, seccion,"GetAl","");


            }
            else
            {
                errorProvider1.SetError(cmbSeccion, "Seleccione la sección correctamente");
            
            }
        
        }
        internal void RR()
        {

            int año = cmbAño.SelectedIndex + 1;
            int grado = cmbGrado.SelectedIndex + 2;
            int seccion = cmbSeccion.SelectedIndex + 2;
            alu.GetListBox(listBox1, año, grado, seccion,"GetAl","");

        }


        private void btn_EnviarSimple(object sender, EventArgs e)
        {
            if (!MoverSimple(listBox1, listBox2))
                errorProvider1.SetError(listBox1, "No hay datos que trasladar");
            else
                errorProvider1.Clear();
        }
        private void btn_RSimple(object sender, EventArgs e)
        {

            if (!MoverSimple(listBox2, listBox1))
                errorProvider1.SetError(listBox2, "No hay datos que trasladar");
            else
                errorProvider1.Clear();
        }

        private void btn_EnviarMulti(object sender, EventArgs e)
        { 
            if (!MoverMulti(listBox1,listBox2))
                errorProvider1.SetError(listBox1,"No hay datos que trasladar");
            else 
                errorProvider1.Clear();
        
        }
        private void btn_RMulti(object sender, EventArgs e)
        {
            if (!MoverMulti(listBox2, listBox1))
                errorProvider1.SetError(listBox2, "No hay datos que trasladar");
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


                        string g = AlTraslado.rer[LBI.GetItemText(LBI.Items[i])].ToString();
                        F2.PropiedadAlumno actual = new F2.PropiedadAlumno();
                        actual = AlTraslado.alumnos[int.Parse(g)];
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


                    string g = AlTraslado.rer[LBI.GetItemText(LBI.Items[i])].ToString();
                    F2.PropiedadAlumno actual = new F2.PropiedadAlumno();
                    actual = AlTraslado.alumnos[int.Parse(g)];
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
            abrir();
        }

        private void VerAvanzado_Click(object sender, EventArgs e)
        {
            abrir();
            
        }
        internal void abrir()
        {

            if (listBox2.Text != "")
            {
                string alSelected;

                alSelected = AlTraslado.rer[listBox2.Text].ToString();
                

                AlumnosR fh = new AlumnosR(AlTraslado.alumnos[int.Parse(alSelected)]);
                fh.ShowDialog();

            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                txtNombre.Visible = false;
                cmbGrado.Visible = true;
                cmbSeccion.Visible = true;
                label2.Text = "Grado";
                label3.Visible = true;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                label2.Text = "Nombre";
                txtNombre.Visible = true;
                cmbGrado.Visible = false;
                cmbSeccion.Visible = false;
                label3.Visible = false;
            }
        }

        private void txtNombre_OnTextChange(object sender, EventArgs e)
        {
            if (txtNombre.text != "")
            {
                int año = cmbAño.SelectedIndex + 1;
                alu.GetListBox(listBox1, año, 0, 0, "GetAl2", txtNombre.text);
            }
        }




       



    }
}
