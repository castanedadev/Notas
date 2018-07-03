using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
namespace WindowsFormsApplication1.F4
{
        class Alu
    {
            SqlConnection conn;

            private string nombre;
            private string nIE;
            private string año;
            private int IdAA;
            private int grado;
            private int seccion;
            private List<Nota> nm;
            private bool aprobado;


            public Alu()
            {
                conn = ConexionRepositorio.Cnn();
                nombre = "";
                nIE = "";
                año = "";
                nm = new List<Nota>();
                IdAA = 0;
                aprobado = true;
            }

            public string Nombre
            {
                get { return nombre; }
                set { nombre = value; }
            }
            public string NIE
            {
                get { return nIE; }
                set { nIE = value; }
            }
            public string Año
            {
                get { return año; }
                set { año = value; }
            
            }
            public List<Nota> NM
            {
                get { return nm; }
                set { nm = value; }
            }
            public int IDAA
            {
                get { return IdAA; }
                set { IdAA = value; }
            }
            public int Grado
            {
                get { return grado; }
                set { grado = value; }
            }
            public int Seccion
            {
                get { return seccion; }
                set { seccion = value; }
            }
            public bool Aprobado
            {
                get { return aprobado; }
                set { aprobado = value; }
            }


            public void GetIdAlumnoAno()
            {
                SqlCommand cmm2;
                try
                {
                    conn.Open();

                    

                    cmm2 = new SqlCommand("GetAlumnoAno", conn);
                    cmm2.CommandType = CommandType.StoredProcedure;    
                    cmm2.Parameters.AddWithValue("@NIE", NIE);
                    cmm2.Parameters.AddWithValue("@ano",Año);
                    SqlDataReader reader2 = cmm2.ExecuteReader();

                    if (reader2.HasRows)
                    {
                        while (reader2.Read())
                        {
                            IDAA = int.Parse(reader2["IdAlumnoAno"].ToString().Trim());

                        }

                    }
                    else
                    {
                        reader2.Close();
                    }

                   
                    conn.Close();
                     
                }
                catch
                {

                    MessageBox.Show("Error extrayendo el IDALUmno", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    conn.Close();

                }
             
            
            }

            public void Llenado()
            {
                if (Grado >= 2 && Grado < 5)
                {
                    for (int i = 1; i < 7; i++)
                    {
                        MateriaNota(IDAA, i);
                    }
                
                }
                else if (Grado >= 5 && Grado < 11)
                {
                    for (int i = 1; i < 9; i++)
                    {
                        MateriaNota(IDAA, i);
                    }
                    
                
                }
                else if (Grado >= 11 && Grado < 13)
                {

                    for (int i = 1; i < 5; i++)
                    {
                        MateriaNota(IDAA, i);
                    }
                    for (int i = 7; i < 12; i++)
                    {
                        MateriaNota(IDAA, i);
                    }
                
                }
            
            
            
            
            }




            internal void  MateriaNota(int IDAA, int IDM)
            {
                bool existencia = true;
                Nota aux;
                SqlCommand cmm;
                try
                {
                    aux = new Nota();

                    aux.IdMateria = IDM;
                     
                    cmm = new SqlCommand("GetNotas", conn);
                    cmm.CommandType = CommandType.StoredProcedure;
                    cmm.Parameters.AddWithValue("@IdAlumnoAno", IDAA);
                    cmm.Parameters.AddWithValue("@IdMateria", IDM);
                    SqlDataReader reader2;
                    conn.Open();
                    reader2 = cmm.ExecuteReader();
                    if (reader2.HasRows)
                    {
                        while (reader2.Read())
                        {
                            int trimestre = 0;
                            trimestre = int.Parse(reader2["Trimestre"].ToString().Trim());

                            if (trimestre == 1)
                            {
                                aux.Notas[0] += double.Parse(reader2["Porcentaje"].ToString().Trim());

                            }
                            else if (trimestre == 2)
                            {

                                aux.Notas[1] += double.Parse(reader2["Porcentaje"].ToString().Trim());

                            }
                            else if (trimestre == 3)
                            {
                                aux.Notas[2] += double.Parse(reader2["Porcentaje"].ToString().Trim());

                            }
                        }



                    }
                    else
                    {
                        existencia = false;
                    }
                    reader2.Close();

                    if (existencia == true)
                        aux.GetPromedioFinal();
                    else
                    {
                        aux.PFinal = 0;
                        aux.Aprobada = false;

                    }
                    if (aux.Aprobada == false)
                    {
                        Aprobado = false;
                    }
  



                    aux.GetMateria();
                    NM.Add(aux);
                  


                    conn.Close();
                }
                catch
                {

                    conn.Close();
                    MessageBox.Show("Error extrayendo las notas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



            }




          





    }
}
