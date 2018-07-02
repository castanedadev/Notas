using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1.F3
{
    public partial class RPro : Form
    {
        public RPro()
        {
            InitializeComponent();
            CrearData1();
            CrearData2();
            LlenarData1();
            LlenarData2();

            button1.Click += new System.EventHandler(btn1_Click);
            button2.Click += new System.EventHandler(btn2_Click);
            btnaceptar.Click += new System.EventHandler(btnAceptar);
        }

        private void btnAceptar(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            button1.Visible = false;
            panel2.Visible = true;
            
        
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            button2.Visible = false;
            button1.Visible = true;
            panel2.Visible = false;
        
        }


        internal void CrearData1()
        {

            dataGridView1.Columns.Add("IdMaestro", "IdMaestro");
            dataGridView1.Columns.Add("Nombre", "Nombre");
            dataGridView1.Columns.Add("Razón", "Razón");
            dataGridView1.Columns[2].Width = 200;
        
        
        }

        internal void LlenarData1()
        {
            int c = ProdTraslado.profesR.Count;
            F2.PropiedadMaestro actual;
            if (c > 0)
            {
                for (int i = 0; i < c; i++)
                {
                    actual = new F2.PropiedadMaestro();
                    actual = ProdTraslado.profesR[i];

                    dataGridView1.Rows.Add(actual.IdMaestro, actual.Nombre, "Ya se encuentra en la base de datos");

                }
            }
            else
            {

                textBox1.Visible = true;
            }

        
        
        }

        internal void CrearData2()
        {

            dataGridView2.Columns.Add("Maestro asignado", "Maestro asignado");
            dataGridView2.Columns.Add("Materia", "Materia");
            dataGridView2.Columns.Add("Grado", "Grado");
            dataGridView2.Columns.Add("Sección", "Sección");
            dataGridView2.Columns.Add("Razón", "Razón");
            dataGridView2.Columns[0].Width = 200;
            dataGridView2.Columns[4].Width = 200;


        }

        internal void LlenarData2()
        {
            int c = ProdTraslado.MR.Count;
            NGM actual;
            if (c > 0)
            {
                for (int i = 0; i < c; i++)
                {
                    actual = new NGM();
                    actual = ProdTraslado.MR[i];
                    SqlConnection conn = Conexion.Cnn();


                    for (int j = 0; j < actual.Grado.Count; j++)
                    {
                        SqlCommand cmm = new SqlCommand("NGMRep", conn);
                        cmm.CommandType = CommandType.StoredProcedure;
                        cmm.Parameters.AddWithValue("@materia", actual.Materia[j]);
                        cmm.Parameters.AddWithValue("@grado", actual.Grado[j]);
                        cmm.Parameters.AddWithValue("@seccion", actual.Seccion[j]);
                        SqlDataReader reader;
                        reader = cmm.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {

                                string maestro= reader["Nombre"].ToString().Trim();
                                string materia = reader["Materia"].ToString().Trim();
                                string grado = reader["Grado"].ToString().Trim();
                                string seccion = reader["Seccion"].ToString().Trim();
                                dataGridView2.Rows.Add(maestro, materia, grado, seccion, "Ya ha sido asignada");
                            }


                        }
                        else
                        {
                            reader.Close();
                        }



                    }

                    conn.Close();


                    
                }
            }
            else
            {

                textBox2.Visible = true;
            }



        }






    }
}
