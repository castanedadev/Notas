using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApplication1.F4
{
    public partial class Grafico : Form
    {
        public Grafico()
        {
            InitializeComponent();
            comboBox1.Items.Add("Reprobados");
            comboBox1.Items.Add("Aprobados");
            comboBox1.SelectedIndex = 0;
            Load11();


        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        List<int> aprobados = new List<int>();

        public class Series
        {
            public string año { get; set; }
            public decimal Serie1 { get; set; }
        
        }
        internal void Load11()
        {

            List<Series> datosSeries = new List<Series>();

            //double[] yValues = { 10, 27.5, 7, 12, 45.5 };
            //string[] xNames = { "Mike", "John", "William", "George", "Alex" };

            List<string> xNames = GR1.años;
            List<int> yValues = GR1.reprobados;
            List<int> yValues2 = GR1.aprobados;

            chart1.Series[0].Points.DataBindXY(xNames, yValues);
            chart2.Series[0].Points.DataBindXY(xNames,yValues2);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                chart1.Visible = true;
                chart2.Visible = false;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                chart2.Visible = true;
                chart1.Visible = false;
            }
        }


    }
}
