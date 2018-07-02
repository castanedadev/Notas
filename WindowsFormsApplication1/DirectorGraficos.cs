using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApplication1
{
    public partial class DirectorGraficos : Form
    {
        Procesos p = new Procesos();
        public DirectorGraficos()
        {
            InitializeComponent();
            TriA.Visible = false;
            TriB.Visible = false;
            TotalA.Visible = false;
            TotalB.Visible = false;
            cbSeccion.Visible = false;
            dgvauxiliar.Visible = false;
        }

        private void GraficosDirector()
        {
            string[] series = { "Trimestre 1", "Trimestre 2", "Trimestre 3" };
            TriA.Series.Clear();
            TriB.Series.Clear();
            TotalA.Series.Clear();
            TotalB.Series.Clear();

            for (int i = 0; i < 2; i++)
            {


                if (i == 0)
                {
                    cbSeccion.Text = "A";
                    p.CrearCuadrofinal(dgvauxiliar);
                    p.LlenarAlumnos(cbGrado, cbSeccion, dgvauxiliar);
                    p.LlenarcuadroFinal(dgvauxiliar, cbMateria);


                    decimal[] porcentaje = { GraficosBarra.Trimestre1, GraficosBarra.Trimestre2, GraficosBarra.Trimestre3 };
                    double[] porcentajes = new double[3];
                    for (int j = 0; j < 3; j++)
                    {
                        porcentajes[j] = Math.Round(double.Parse(porcentaje[j].ToString()), 2);
                    }
                    TriA.Palette = ChartColorPalette.Excel;
                    for (int u = 0; u < series.Length; u++)
                    {
                        Series serie = TriA.Series.Add(series[u]);
                        serie.Label = porcentajes[u].ToString();
                        serie.Points.Add(porcentajes[u]);
                    }

                    double final = Math.Round(double.Parse(GraficosBarra.Final.ToString()), 2);
                    TotalA.Palette = ChartColorPalette.Pastel;
                    Series s = TotalA.Series.Add("Promedio");
                    s.Label = final.ToString();
                    s.Points.Add(final);

                }
                else
                {
                    cbSeccion.Text = "B";
                    p.CrearCuadrofinal(dgvauxiliar);
                    p.LlenarAlumnos(cbGrado, cbSeccion, dgvauxiliar);
                    p.LlenarcuadroFinal(dgvauxiliar, cbMateria);

                    decimal[] porcentaje = { GraficosBarra.Trimestre1, GraficosBarra.Trimestre2, GraficosBarra.Trimestre3 };
                    double[] porcentajes = new double[3];
                    for (int j = 0; j < 3; j++)
                    {
                        porcentajes[j] = Math.Round(double.Parse(porcentaje[j].ToString()), 2);
                    }
                    TriB.Palette = ChartColorPalette.Excel;
                    // TriB.Series["Series1"].LegendText = "Trimestres";


                    for (int u = 0; u < series.Length; u++)
                    {
                        Series serie = TriB.Series.Add(series[u]);
                        serie.Label = porcentajes[u].ToString();
                        serie.Points.Add(porcentajes[u]);
                    }
                    double final = Math.Round(double.Parse(GraficosBarra.Final.ToString()), 2);
                    TotalB.Palette = ChartColorPalette.Pastel;
                    try
                    {
                        //TotalB.Series["Series1"].LegendText = "Promedio";
                    }
                    catch (Exception)
                    {

                        //TotalB.Series["Promedio"].LegendText = "Promedio";
                    }
                    Series s = TotalB.Series.Add("Promedio");
                    s.Label = final.ToString();
                    s.Points.Add(final);

                }



            }
        }

        private void DirectorGraficos_Load(object sender, EventArgs e)
        {
            p.LlenarGrados(cbGrado);
            TriA.Titles.Add("Balance de Trimestres");
            TotalA.Titles.Add("Promedio final");
            TriB.Titles.Add("Balance de Trimestres");
            TotalB.Titles.Add("Promedio final");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            GraficosDirector();
            TriA.Visible = true;
            TriB.Visible = true;
            TotalA.Visible = true;
            TotalB.Visible = true;
        }

        private void cbGrado_SelectedIndexChanged(object sender, EventArgs e)
        {
            p.Limpiarcb(cbMateria);
            p.LlenarMaterias(cbMateria, cbGrado);
        }
    }
}
