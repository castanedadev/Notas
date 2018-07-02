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
    public partial class Graficos : Form
    {
        public Graficos()
        {
            InitializeComponent();
        }
        private void Graficostunning()
        {
            string[] series = { "Trimestre 1", "Trimestre 2", "Trimestre 3" };
            decimal[] porcentaje = { GraficosBarra.Trimestre1, GraficosBarra.Trimestre2, GraficosBarra.Trimestre3 };
            double[] porcentajes = new double[3];
            for (int i = 0; i < 3; i++)
            {
                porcentajes[i] = Math.Round(double.Parse(porcentaje[i].ToString()), 2);
            }
            chart1.Palette = ChartColorPalette.Excel;
            chart1.Titles.Add("Balance de Trimestres");
            chart1.Series["Series1"].LegendText = "Trimestres";


            for (int i = 0; i < series.Length; i++)
            {
                Series serie = chart1.Series.Add(series[i]);
                serie.Label = porcentajes[i].ToString();
                serie.Points.Add(porcentajes[i]);
            }
            double final = Math.Round(double.Parse(GraficosBarra.Final.ToString()), 2);
            chart2.Palette = ChartColorPalette.Pastel;
            chart2.Titles.Add("Promedio final");
            chart2.Series["Series1"].LegendText = "Promedio";
            Series s = chart2.Series.Add("Promedio");
            s.Label = final.ToString();
            s.Points.Add(final);
        }

        private void Graficos_Load(object sender, EventArgs e)
        {
            Graficostunning();
        }
    }
}