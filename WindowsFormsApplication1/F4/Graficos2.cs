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
    public partial class Graficos2 : Form
    {
        public Graficos2(int mater)
        {
            InitializeComponent();
            List<string> xNamee = new List<string>();
            List<int> yValues = new List<int>();

            xNamee.Add("Aprobados");
            xNamee.Add("Reprobados");
            yValues.Add(GR1.apr);
            yValues.Add(GR1.repro);
            label1.Text = "Gráfico aprobados vs reprobados de la materia " + GR1.mat;
          
            chart1.Series[0].Points.DataBindXY(xNamee, yValues);

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }


     



    }
}
