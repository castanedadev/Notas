using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;

namespace WindowsFormsApplication1.F4
{
    class procesoI
    {
        private SqlCommand cmm;
        private SqlDataReader reader;
        private SqlConnection conn;
        private List<Alu> Alumnos;
        public procesoI()
        {
            conn = ConexionRepositorio.Cnn();
        
        }
    
        

       public void CrearCuadrofinal(DataGridView dgv, int Materia)
        {
           try
           {

           DataGridView data=dgv as DataGridView;
            dgv.Columns.Clear();
            dgv.Rows.Clear();
            dgv.Columns.Add("Alumnos", "NOMBRE DEL ALUMNO/A");
            dgv.Columns.Add("Trimestre 1","Trimestre 1."+"");
            dgv.Columns.Add("Trimestre 2","Trimestre 2."+"\n35%");
            dgv.Columns.Add("Trimestre 3","Trimesre 3");
            dgv.Columns.Add("Promedio final","Promedio final");
            dgv.Columns[0].Width =200;
            dgv.Columns[1].Width = 100;
            dgv.Columns[2].Width = 100;
            dgv.Columns[3].Width = 100;
            dgv.Columns[4].Width = 100;

             int c = 0;
               foreach (Alu item in Alumnos)
               {
                   string nombre = item.Nombre;
                   string tri1 = "";
                   string tri2 = "";
                   string tri3 = "";
                   string promediofinal = "";
                   bool apro = true;
                   foreach (Nota nt in item.NM)
                   {
                       tri1 = nt.Notas[0].ToString();
                       tri2 = nt.Notas[1].ToString();
                       tri3 = nt.Notas[2].ToString();

                       promediofinal = nt.PFinal.ToString();
                       apro = nt.Aprobada;


                       
                           if (nt.IdMateria == Materia)
                           {
                               data.Rows.Add(nombre, tri1,tri2,tri3, promediofinal);

                               if (!apro)
                               {
                                   data.Rows[c].Cells[4].Style.BackColor = Color.Red;
                               }
                               else
                               {
                                   data.Rows[c].Cells[4].Style.BackColor = Color.Green;

                               }

                           }
                       }
                  
                       c++;

                   }
               
               }
               catch
               { }





       
        
       }


       public void CrearCuadro1(DataGridView dgv,int Materia)
       {
           try
           {
               DataGridView data = dgv as DataGridView;
               //try
               //{
               dgv.Columns.Clear();
               //dgv.Width = 400;
               dgv.Rows.Clear();
               dgv.Columns.Add("Alumnos", "NOMBRE DEL ALUMNO");
               dgv.Columns.Add("Materia", "Materia");
               dgv.Columns.Add("Nota", "Nota" );

               dgv.Columns[0].Width = 200;
               dgv.Columns[1].Width = 100;
               dgv.Columns[2].Width = 100;
               int c = 0;
               foreach (Alu item in Alumnos)
               {
                   string nombre = item.Nombre;
                   string materia = "";
                   string promediofinal = "";
                   bool apro = true;
                   foreach (Nota nt in item.NM)
                   {
                       materia = nt.Materia;
                       promediofinal = nt.PFinal.ToString();
                       apro = nt.Aprobada;


                       if (Materia != 0)
                       {
                           if (nt.IdMateria == Materia)
                           {
                               data.Rows.Add(nombre, materia, promediofinal);

                               if (!apro)
                               {
                                   data.Rows[c].Cells[2].Style.BackColor = Color.Red;
                               }
                               else
                               {
                                   data.Rows[c].Cells[2].Style.BackColor = Color.Green;

                               }

                           }
                       }
                       else
                       {

                           data.Rows.Add(nombre, materia, promediofinal);

                           if (apro == false)
                           {
                               data.Rows[c].Cells[2].Style.BackColor = Color.Red;
                           }
                           else
                           {
                               data.Rows[c].Cells[2].Style.BackColor = Color.Green;

                           }

                       }

                       c++;

                   }
               }
               //}
               //catch
               //{ }

           }
           catch

           { 
           }

       
       
       }


       public void CrearCuadroPorTrimestre(DataGridView dgv, int Materia, int trimestre)
       {
           try
           {
               DataGridView data = dgv as DataGridView;

               dgv.Columns.Clear();

               dgv.Columns.Clear();
               //dgv.Width = 400;
               dgv.Rows.Clear();
               dgv.Columns.Add("Alumnos", "NOMBRE DEL ALUMNO" );
               dgv.Columns.Add("Materia", "Materia" );
               dgv.Columns.Add("Nota", "Nota" );

               dgv.Columns[0].Width = 200;
               dgv.Columns[1].Width = 100;
               dgv.Columns[2].Width = 100;
               int c = 0;
               foreach (Alu item in Alumnos)
               {
                   string nombre = item.Nombre;
                   string materia = "";
                   string NtTrimestre = "";
                   bool apro = true;
                   foreach (Nota nt in item.NM)
                   {
                       materia = nt.Materia;
                       NtTrimestre = nt.Notas[trimestre].ToString();
                       apro = nt.Aprobada;
                       double r = double.Parse(NtTrimestre);


                       if (Materia != 0)
                       {
                           if (nt.IdMateria == Materia)
                           {
                               data.Rows.Add(nombre, materia, NtTrimestre);

                               if (r < 6)
                               {
                                   data.Rows[c].Cells[2].Style.BackColor = Color.Red;
                               }
                               else
                               {
                                   data.Rows[c].Cells[2].Style.BackColor = Color.Green;

                               }

                           }
                       }
                       else
                       {

                           data.Rows.Add(nombre, materia, NtTrimestre);

                           if (r < 6)
                           {
                               data.Rows[c].Cells[2].Style.BackColor = Color.Red;
                           }
                           else
                           {
                               data.Rows[c].Cells[2].Style.BackColor = Color.Green;

                           }

                       }

                       c++;

                   }




               }

           }
           catch
           { 
           }




       }







        public void LlenarAlumnos(int año, int Grado, int Seccion, DataGridView dgv, int materia)
        {
            Alumnos = new List<Alu>();

            Alu alumno;
            //try
            //{
             
            cmm = GetAl(año, Grado, Seccion);

            conn.Open();
            cmm.ExecuteNonQuery();
            reader = cmm.ExecuteReader();
            
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    alumno = new Alu();
                    alumno.NIE = reader["NIE"].ToString().Trim();
                    alumno.Nombre = reader["Nombre"].ToString().Trim();
                    alumno.Año = reader["ano"].ToString().Trim();
                    alumno.Grado = int.Parse(reader["Grado"].ToString().Trim());
                    alumno.Seccion = int.Parse(reader["Seccion"].ToString().Trim());
                    alumno.GetIdAlumnoAno();
                    alumno.Llenado();
                    Alumnos.Add(alumno);

                }
            }
            
            conn.Close();

            CrearCuadro1(dgv, materia);
            //}
            //catch (Exception)
            //{
            //conn.Close();
            //    MessageBox.Show("Error", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

        }//LenarAlumnos



        public void LlenarAlumnos1(int año, int año2, DataGridView dgv, int materia)
        {
            Alumnos = new List<Alu>();

            Alu alumno;
            //try
            //{

            cmm = GetAl2(año, año2);

            conn.Open();
            cmm.ExecuteNonQuery();
            reader = cmm.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    alumno = new Alu();
                    alumno.NIE = reader["NIE"].ToString().Trim();
                    alumno.Nombre = reader["Nombre"].ToString().Trim();
                    alumno.Año = reader["ano"].ToString().Trim();
                    alumno.Grado = int.Parse(reader["Grado"].ToString().Trim());
                    alumno.Seccion = int.Parse(reader["Seccion"].ToString().Trim());
                    alumno.GetIdAlumnoAno();
                    alumno.Llenado();
                    Alumnos.Add(alumno);




                    int auxiliar = 0;
                    foreach (string item in GR1.años)
                    {
                        if (item == alumno.Año)
                        {
                            if (alumno.Aprobado == true)
                            {

                                GR1.aprobados[auxiliar] += 1;
                            }
                            else
                            {
                                GR1.reprobados[auxiliar] += 1;
                            }


                        }
                        auxiliar++;

                    }



                }
              



            }

            conn.Close();

            CrearCuadro1(dgv, materia);
            //}
            //catch (Exception)
            //{
            //conn.Close();
            //    MessageBox.Show("Error", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

        }//LenarAlumnos




        public void LlenarCombos(string consulta,string parametro, ComboBox cb)
        {
            ComboBox cmb = cb as ComboBox;
            try
            {
                cmm = new SqlCommand(consulta, conn);
                conn.Open();
                reader = cmm.ExecuteReader();
                if (reader.HasRows)
                {

                    while (reader.Read())
                    {
                        cmb.Items.Add(reader[parametro].ToString().Trim());
                    
                    }
                
                }




                conn.Close();

            }
            catch 
            {
                MessageBox.Show("Error llenando parámetros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            }
            
        
        
        }


        internal SqlCommand GetAl(int año, int grado, int seccion)
        {
            SqlCommand retorno;
            if (año == 0 && grado!=0 && seccion!=0)
            {
                retorno = new SqlCommand("GetAlNoAno", conn);
                retorno.CommandType = CommandType.StoredProcedure;
                retorno.Parameters.AddWithValue("@grado", grado);
                retorno.Parameters.AddWithValue("@seccion", seccion);           
            }
            else if (grado == 0 && año!=0 && seccion!=0)
            {
                retorno = new SqlCommand("GetAlNoGrado", conn);
                retorno.CommandType = CommandType.StoredProcedure;
                retorno.Parameters.AddWithValue("@ano", año);
                retorno.Parameters.AddWithValue("@seccion", seccion); 
                      
            }
            else if (seccion == 0 && año != 0 && grado != 0)
            {
                retorno = new SqlCommand("GetAlNoSeccion", conn);
                retorno.CommandType = CommandType.StoredProcedure;
                retorno.Parameters.AddWithValue("@ano", año);
                retorno.Parameters.AddWithValue("@grado", grado);
            }
            else if (año == 0 && grado == 0 && seccion != 0)
            {
                retorno = new SqlCommand("GetAlNoAnoGrado", conn);
                retorno.CommandType = CommandType.StoredProcedure;
                retorno.Parameters.AddWithValue("@seccion", seccion);
            }
            else if (año == 0 && seccion == 0 && grado != 0)
            {
                retorno = new SqlCommand("GetAlNoAnoSeccion", conn);
                retorno.CommandType = CommandType.StoredProcedure;
                retorno.Parameters.AddWithValue("@grado", grado);
            }
            else if (grado == 0 && seccion == 0 && año != 0)
            {
                retorno = new SqlCommand("GetAlNoGradoSeccion", conn);
                retorno.CommandType = CommandType.StoredProcedure;
                retorno.Parameters.AddWithValue("@ano", año);
            }
            else if (grado != 0 && seccion != 0 && año != 0)
            {
                retorno = new SqlCommand("GetAl", conn);
                retorno.CommandType = CommandType.StoredProcedure;
                retorno.Parameters.AddWithValue("@ano", año);
                retorno.Parameters.AddWithValue("@grado", grado);
                retorno.Parameters.AddWithValue("@seccion", seccion);
            }
            else
            {
                retorno = new SqlCommand("GetAlNoNada", conn);
                retorno.CommandType = CommandType.StoredProcedure;
            
            }

            return retorno;

        }

        internal SqlCommand GetAl2(int año, int año2)
        {
            SqlCommand retorno;
            
                retorno = new SqlCommand("GetAlDosAnos", conn);
                retorno.CommandType = CommandType.StoredProcedure;
                retorno.Parameters.AddWithValue("@ano", año);
                retorno.Parameters.AddWithValue("@ano1", año2);

                return retorno;
        }
    
    }
}
