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
    public partial class repe : Form
    {
        public repe()
        {
            InitializeComponent();
            CrearDataGrid();
            llenarData();
        }
        internal void CrearDataGrid()
        {
            dataGridView1.Columns.Add("NIE", "NIE");
            dataGridView1.Columns.Add("Nombre", "Nombre");
            dataGridView1.Columns.Add("Razón", "Razón");
            dataGridView1.Columns[2].Width = 200;
        
        }

        internal void llenarData()
        {
            int c = AlTraslado.Repetidos.Count;
            F2.PropiedadAlumno actual;
            if (c > 0)
            {
                for (int i = 0; i < c; i++)
                {
                    actual = new F2.PropiedadAlumno();
                    actual = AlTraslado.Repetidos[i];

                    dataGridView1.Rows.Add(actual.Nie, actual.Nombre, "Ya se encuentra en la base de datos");

                }
            }
            else
            {

                textBox1.Visible = true;
            }



        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void repe_Load(object sender, EventArgs e)
        {

        }
    }
}
