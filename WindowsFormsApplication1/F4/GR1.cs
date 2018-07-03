using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.F4
{
    public partial class GR1 : Form
    {

        bool auxiliar = true;

        public static int a;
        public static int g;
        public static int s;
        public static int modo=0;
        int abiert = 0;

        public static List<string> años;
        public static List<int> aprobados;
        public static List<int> reprobados;
        
        public static string gaño;

        procesoI mtd = new procesoI();
        public GR1()
        {
            InitializeComponent();
            crear();
           

        
        }
        internal void crear()
        {
            string año1 = "SELECT * FROM ANO ";
            string grado1 = "SELECT * FROM GRADO WHERE IdGrado!=1";
            string seccion1 = "SELECT * FROM SECCION WHERE IdSeccion!=1";
            string materias = "SELECT * FROM MATERIA ";
            string Trimestre = "SELECT * FROM TRIMESTRE";
            mtd.LlenarCombos(año1, "ano", año);
            mtd.LlenarCombos(grado1, "Grado", grado);
            mtd.LlenarCombos(seccion1, "Seccion", seccion);
            mtd.LlenarCombos(materias, "Materia", materia);
            mtd.LlenarCombos(año1, "ano", año2);
            mtd.LlenarCombos(Trimestre, "Trimestre", trimestres);
            trimestres.Items.Add("Completo");
           
        }


        internal void Llenar()
        {
            abiert = 3;
            años = new List<string>();
            aprobados = new List<int>();
            reprobados = new List<int>();


            foreach (string item in año.Items)
            {
                años.Add(item);
                aprobados.Add(0);
                reprobados.Add(0);

            }


            VgRAF.Visible = true;
            auxiliar = true;
            trimestres.Visible = false;
            gaño = año.SelectedText;
            int mater = materia.SelectedIndex;

            if (mater == -1)
            {
                mater = 0;
            }
            else
            {
                mater += 1;
                if (año.SelectedIndex != -1)
                {
                    abiert = 3;
                }


            }


            dataGridView1.Rows.Clear();
            if (año.SelectedIndex == -1 && grado.SelectedIndex != -1 && seccion.SelectedIndex != -1)
            {
                a = 0;
                g = grado.SelectedIndex +2;
                s = seccion.SelectedIndex + 2;

                mtd.LlenarAlumnos(a, g, s, dataGridView1,mater);
                //mtd.CrearCuadro1(dataGridView1, mater);
            
            }
            else if (año.SelectedIndex != -1 && grado.SelectedIndex == -1 && seccion.SelectedIndex != -1)
            {
                 a = año.SelectedIndex + 1; ;
                 g = 0;
                 s = seccion.SelectedIndex + 2;

                mtd.LlenarAlumnos(a, g, s, dataGridView1,mater);
                // mtd.CrearCuadro1(dataGridView1, mater);
            

            }
            else  if (año.SelectedIndex != -1 && grado.SelectedIndex != -1 && seccion.SelectedIndex == -1)
            {
                a = año.SelectedIndex + 1 ;
                 g = grado.SelectedIndex + 2;
                 s = 0;

                mtd.LlenarAlumnos(a, g, s, dataGridView1,mater);
                //  mtd.CrearCuadro1(dataGridView1, mater);
            
            }

            else if (año.SelectedIndex == -1 && grado.SelectedIndex == -1 && seccion.SelectedIndex != -1)
            {
                 a = 0 ;
                 g = 0;
                 s = seccion.SelectedIndex+2;

                auxiliar = false;
                mtd.LlenarAlumnos(a, g, s, dataGridView1,mater);
                // mtd.CrearCuadro1(dataGridView1, mater);
            
            }
            else if (año.SelectedIndex == -1 && grado.SelectedIndex != -1 && seccion.SelectedIndex == -1)
            {
                 a = 0 ;
                 g = grado.SelectedIndex + 2;
                 s = 0;
                auxiliar = false;
                mtd.LlenarAlumnos(a, g, s, dataGridView1,mater);
                //  mtd.CrearCuadro1(dataGridView1, mater);
            
            }
            else if (año.SelectedIndex != -1 && grado.SelectedIndex == -1 && seccion.SelectedIndex == -1)
            {
                 a = año.SelectedIndex + 1; 
                 g = 0;
                 s = 0;

                mtd.LlenarAlumnos(a, g, s, dataGridView1,mater);


                //   mtd.CrearCuadro1(dataGridView1, mater);
            
                if (mater == 1)
                {
                    abiert = 3;
                }

           
            }
            else if (año.SelectedIndex != -1 && grado.SelectedIndex != -1 && seccion.SelectedIndex != -1)
            {
                 a = año.SelectedIndex + 1;
                 g = grado.SelectedIndex + 2;
                 s = seccion.SelectedIndex + 2;

                mtd.LlenarAlumnos(a, g, s, dataGridView1,mater);
                //  mtd.CrearCuadro1(dataGridView1, mater);
            

            }
            else
            {
                a = 0;
                g = 0;
                s = 0;
                mtd.LlenarAlumnos(a, g, s, dataGridView1, mater);

                //  mtd.CrearCuadro1(dataGridView1, mater);
            
            
            }

        
        }

        private void año_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (año.SelectedIndex != -1)
            {
                label5.Visible = true;
                año2.Visible = true;

            }
           
            Llenar();
        }

        private void grado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (grado.SelectedIndex != -1)
            {
                año2.Visible = false;
            }

            Llenar();
        }

        private void seccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (seccion.SelectedIndex != -1)
            {
                año2.Visible = false;
            }
            Llenar();
        }

        private void Actualizar_Click(object sender, EventArgs e)
        {
            Llenar();
        }

        private void materia_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (materia.SelectedIndex != -1)
            {
                año2.Visible = false;
            }
            Llenar();
        }

        private void trimestres_SelectedIndexChanged(object sender, EventArgs e)
        {
            int mater = materia.SelectedIndex;
            if (mater == -1)
            {
                mater = 0;
            }
            else
            {
                mater += 1;
            }

            if (trimestres.SelectedIndex != -1)
            {
               
                if (trimestres.SelectedIndex != 3)
                {
                    errorProvider1.Clear();
                    mtd.CrearCuadroPorTrimestre(dataGridView1, mater, trimestres.SelectedIndex);
                }
                else
                {
                    if (año.SelectedIndex != -1 && grado.SelectedIndex != -1 && seccion.SelectedIndex != -1 && materia.SelectedIndex != -1)
                    {
                        errorProvider1.Clear();
                        dataGridView2.Visible = true;
                        dataGridView1.Visible = false;
                        mtd.CrearCuadrofinal(dataGridView2, mater);

                    }
                    else
                    {
                        errorProvider1.SetError(trimestres, "Deben estar completados todos los parámetros (Año,grado,sección,materia) para utilizar esta opción");

                    }
                
                
                }
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

            if (dataGridView1.Rows.Count > 0)
            {
                if (grado.SelectedIndex != -1 && seccion.SelectedIndex != -1 && materia.SelectedIndex != -1)
                {
                    errorProvider1.Clear();
                    trimestres.Visible = true;
                    panel3.Enabled = false;
                    regresar.Visible = true;
                    bunifuThinButton21.Visible = false;
                }
            }
            else
            {
                errorProvider1.SetError(bunifuThinButton21, "No hay datos que filtrar");
            
            }
        }

        private void regresar_Click(object sender, EventArgs e)
        {
            foreach (ComboBox item in panel3.Controls)
            {
                item.Items.Clear();
            }

            trimestres.Items.Clear();
            trimestres.Visible = false;
            bunifuThinButton21.Visible = true;
            panel3.Enabled = true;
            año2.Items.Clear();
            crear();
            trimestres.SelectedIndex = -1;
            dataGridView2.Visible = false;
            dataGridView1.Visible = true;

        }

     
        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            
            if (auxiliar == true)
            {

               

                regre1.Visible = true;
                VgRAF.Visible = false;
                panel4.Dock = DockStyle.Fill;
                F_Splash.MN g = new F_Splash.MN();
               switch (abiert)
               {
                   case 1:
                    g.AbrirPanel1(new Grafico(), panel4);
                    break;
                   case 3:
                    {
                        if (grado.SelectedIndex != -1 && seccion.SelectedIndex != -1 && materia.SelectedIndex != -1)
                        {
                            if (año2.Visible == false)
                            {
                                MateriasAños();
                                g.AbrirPanel1(new Graficos2((materia.SelectedIndex+1)), panel4);
                            }
                            else
                            {
                                regre1.Visible = false;
                                panel4.Visible = false;
                                panel4.Dock = DockStyle.None;

                                VgRAF.Visible = true;


                                return;
                            }
                        }
                        else
                        {
                            regre1.Visible = false;
                            panel4.Visible = false;
                            panel4.Dock = DockStyle.None;

                            VgRAF.Visible = true;                                                                                         
                            return;
                        }
                        
                        break;
                    }
               }
                panel4.Visible = true;

            }
            else
            {
                MessageBox.Show("Puede que los filtros escogidos no tengan versión gráfica, intentelo con otra forma", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            }



        }

        private void regre1_Click(object sender, EventArgs e)
        {
            regre1.Visible = false;
            panel4.Visible = false;
            panel4.Dock = DockStyle.None;

            VgRAF.Visible = true;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void año2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                años = new List<string>();
                aprobados = new List<int>();
                reprobados = new List<int>();

                int ini = int.Parse(año.Text);
                int fin = int.Parse(año2.Text);

                for (int i = ini; i <= fin; i++)
                {
                    años.Add(i.ToString());
                    aprobados.Add(0);
                    reprobados.Add(0);


                }



                int mater = materia.SelectedIndex;
                if (mater == -1)
                {
                    mater = 0;
                }
                else
                {
                    mater += 1;
                }


                grado.SelectedIndex = -1;
                seccion.SelectedIndex = -1;

                if (año2.SelectedIndex != -1)
                {
                    abiert = 1;
                    grado.Visible = false;
                    seccion.Visible = false;
                    a = año.SelectedIndex + 1;
                    int a2 = año2.SelectedIndex + 1;
                    año2.Visible = false;
                    mtd.LlenarAlumnos1(a, a2, dataGridView1, 0);
                    grado.Visible = true;
                    seccion.Visible = true;
                    label5.Visible = false;


                }
                else
                {
                    grado.Visible = true;
                    seccion.Visible = true;

                }
            }
            catch

            { }
        }

        public static int apr, repro;
        public static string mat;
        internal void MateriasAños()
        {

            apr = 0;
            repro = 0;
            mat = materia.SelectedText;
            int r = dataGridView1.Rows.Count;
            int c = dataGridView1.Columns.Count;
            for (int i = 0; i < r; i++)
            {

                double aux = double.Parse(dataGridView1.Rows[i].Cells[c - 1].Value.ToString());
                if (aux < 6)
                {
                    repro++;

                }
                else
                {
                    apr++; 
                }


            }


    
    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            grado.SelectedIndex = -1;
            seccion.SelectedIndex = -1;
            año.SelectedIndex = -1;
            materia.SelectedIndex = -1;
        }   






    }
}
