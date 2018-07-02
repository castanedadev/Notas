using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Collections;
using System.Data;
namespace WindowsFormsApplication1.F3
{
    class ProdTraslado
    {
        SqlCommand cmm;
        SqlDataReader reader;
        SqlConnection conn;
        public static Hashtable rer;
        public static List<F2.PropiedadMaestro> profes;
        public static List<NGM> pNGM;
        public static List<F2.PropiedadMaestro> profesR;
        public static List<NGM> MR;
   
        public ProdTraslado()
        {

            conn = ConexionRepositorio.Cnn();
        }


        public void LlenadoProfes(ListBox b,string año)
        {
            try
            {
                profes = new List<F2.PropiedadMaestro>();
                pNGM = new List<NGM>();
                profesR = new List<F2.PropiedadMaestro>();
                MR = new List<NGM>();
                int c = 0;
                b.Items.Clear();
                rer = new Hashtable();
                ListBox lb = b as ListBox;

                profes = getProf(año);
                if (profes != null)
                {
                    foreach (F2.PropiedadMaestro item in profes)
                    {
                        
                        rer.Add(item.Nombre, c);
                       LlenarMaterias(item.IdMaestro, año);
                        
                        lb.Items.Add(item.Nombre);



                        c++;

                    }
                }
                lb.Sorted = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }

        internal List<F2.PropiedadMaestro> getProf(string año)
        {
            try
            {
                List<F2.PropiedadMaestro> profes = new List<F2.PropiedadMaestro>();
                F2.PropiedadMaestro p;
                cmm = new SqlCommand("GetRP", conn);
                cmm.CommandType = CommandType.StoredProcedure;
                cmm.Parameters.AddWithValue("@ano", año);
                conn.Open();
                reader = cmm.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        p = new F2.PropiedadMaestro();
                        p.IdMaestro = reader["IdMaestro"].ToString().Trim();
                       
                        p.Nombre = reader["Nombre"].ToString().Trim();
                        p.Fecha = reader["Fecha"].ToString().Trim();
                        p.Direccion = reader["Direccion"].ToString().Trim();
                        p.Grado = int.Parse(reader["IdGrado"].ToString().Trim());                       
                        p.Seccion = int.Parse(reader["IdSeccion"].ToString().Trim());
                        p.Telefono = reader["Telefono"].ToString().Trim();

                        profes.Add(p);

                    
                    
                    }
                
                
                }



                conn.Close();
                return profes;
            }
            catch
            {
                conn.Close();
                return null;

            }
            
        
        
        }


        public void LlenarCombo(ComboBox b)
        {
            ComboBox cb = b as ComboBox;

            try
            {
                conn.Open();
                string cadena = "SELECT ano FROM ANO";
                cmm = new SqlCommand(cadena, conn);
                reader = cmm.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        cb.Items.Add(reader["ano"].ToString().Trim());
                    
                    
                    }
                
                }
                conn.Close();

            }
            catch
            {

                conn.Close();
            }


        
        
        }

        internal void LlenarMaterias(string IdMaestro, string año)
        {

            NGM nu;
            try
            {
                nu = new NGM();

                cmm = new SqlCommand("GetNGM", conn);
                cmm.CommandType = CommandType.StoredProcedure;
                cmm.Parameters.AddWithValue("@ano", int.Parse(año));
                cmm.Parameters.AddWithValue("@maestro", IdMaestro);
                conn.Open();
                
                nu.Maestro = IdMaestro;
                nu.Año = año;
                
                reader = cmm.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int grado, seccion, materia;
                        materia = int.Parse(reader["Materia"].ToString().Trim());
                        seccion = int.Parse(reader["Seccion"].ToString().Trim());
                        grado = int.Parse(reader["Grado"].ToString().Trim());
                        nu.Grado.Add(grado);
                        nu.Seccion.Add(seccion);
                        nu.Materia.Add(materia);
                        nu.Estado.Add(1);
                        pNGM.Add(nu);


                    }


                }
                else
                {
                    pNGM.Add(nu);
                }


                conn.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                conn.Close();
            }
            
        
        }


        public void LlenarData(DataGridView da, NGM pr)
            {
                DataGridView materias=da as DataGridView;
                materias.Rows.Clear();
                materias.Columns.Clear();
                materias.Columns.Add("Materia","Materia");
                materias.Columns.Add("Grado","Grado");
                materias.Columns.Add("Seccion","Seccion");
                SqlCommand ma;
                SqlCommand gra;
                SqlCommand secc;  
		  

		        
            
             
                    if (pr.Grado.Count>0)
                    {
                        for (int i = 0; i < pr.Grado.Count; i++)
                        {
                            
                                             
                            materias.Rows.Add();
                            string gr = "SELECT Grado FROM GRADO WHERE IdGrado= " + pr.Grado[i];
                            string mat = "SELECT * FROM MATERIA WHERE IdMateria=" + pr.Materia[i];
                            string sec = "SELECT Seccion FROM SECCION WHERE IdSeccion= " + pr.Seccion[i];
                            ma = new SqlCommand(mat, conn);
                            gra = new SqlCommand(gr, conn);
                            secc = new SqlCommand(sec, conn);
                            try
                            {
                                conn.Open();
                                reader = ma.ExecuteReader();
                             
                                while (reader.Read())
                                {
                                    materias[0, i].Value = reader["Materia"].ToString().Trim();
                                }
                                reader.Close();
                                reader = gra.ExecuteReader();
                                while (reader.Read())
                                {
                                    materias[1, i].Value = reader["Grado"].ToString().Trim();
                                }
                                reader.Close();
                                reader = secc.ExecuteReader();

                                while (reader.Read())
                                {
                                    materias[2, i].Value = reader["Seccion"].ToString().Trim();
                                }
                               
                                conn.Close();
                               


                            }
                            catch (Exception)
                            {
                                MessageBox.Show("Error recuperando materias", "Error", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                                conn.Close();
                            }



                        }





                    }



            }


        public void Recuperar(F2.PropiedadMaestro n)
        {
            SqlConnection conn = Conexion.Cnn();
            F2.PropiedadMaestro item = n as F2.PropiedadMaestro;
            
            try
            {
                
                    if (item.Grado!=1 && item.Seccion!=1)
                            item.Tutor=1;

                    string cadena = "SELECT * FROM Maestros WHERE IdMaestro='" + item.IdMaestro+"'"; 
                    SqlCommand cmm = new SqlCommand(cadena, conn);
                    SqlDataReader reader;
                 
                    reader = cmm.ExecuteReader();
                    if (reader.HasRows)
                    {
                        profesR.Add(item);
                        return;
                    }
                      reader.Close();
                    
                    item.Estado = 1;
                    cmm = new SqlCommand("DocenteRetorno", conn);
                    cmm.CommandType = CommandType.StoredProcedure;
                    cmm.Parameters.AddWithValue("@tutor", item.Tutor);
                    cmm.Parameters.AddWithValue("@idMaestro", item.IdMaestro);
                    cmm.Parameters.AddWithValue("@Nombre", item.Nombre);
                    cmm.Parameters.AddWithValue("@fecha", item.Fecha);
                    cmm.Parameters.AddWithValue("@telefono", item.Telefono);
                    cmm.Parameters.AddWithValue("@direccion", item.Direccion);
                    if (item.Tutor == 0)
                    {
                        cmm.Parameters.AddWithValue("@Grado", "");
                        cmm.Parameters.AddWithValue("@seccion", "");

                    }
                    else
                    {
                        cmm.Parameters.AddWithValue("@Grado", item.Grado);
                        cmm.Parameters.AddWithValue("@seccion", item.Seccion);
                    }
                    cmm.Parameters.AddWithValue("@estado", char.Parse("1"));

                    
                        cmm.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message, "Error retornando maestros", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        
        }

        public void RecuperarNGM(NGM n)
        {
            SqlConnection conn = Conexion.Cnn();
            NGM auxiliar = n as NGM;
            try
            {
                
                
                    if (auxiliar.Grado.Count > 0)
                    {
                        
                           
                        for (int j = 0; j < auxiliar.Grado.Count; j++)
                        {
                            string cadena = "SELECT * FROM NGM WHERE Materia=" + auxiliar.Materia[j] + " AND Grado= " + auxiliar.Grado[j]+ " AND Seccion= " + auxiliar.Seccion[j];
                            SqlCommand cmm = new SqlCommand(cadena, conn);
                            SqlDataReader reader=null;
                            reader = cmm.ExecuteReader();
                            if (reader.HasRows)
                            {
                                
                                MR.Add(auxiliar);
                                return;

                            }
                            reader.Close();

                            cmm = new SqlCommand("NGMRetorno", conn);
                            cmm.CommandType = CommandType.StoredProcedure;
                            cmm.Parameters.AddWithValue("@IdMaestro", auxiliar.Maestro);
                            cmm.Parameters.AddWithValue("@Grado", auxiliar.Grado[j]);
                            cmm.Parameters.AddWithValue("@Materia", auxiliar.Materia[j]);
                            cmm.Parameters.AddWithValue("@seccion", auxiliar.Seccion[j]);
                            cmm.Parameters.AddWithValue("@estado", 1);
                            cmm.ExecuteNonQuery();

                        }
                    
                    
                    }

                    
                


                conn.Close();
            }

            catch (Exception ex)
            {

                conn.Close();
                MessageBox.Show(ex.Message, "Error retornando NGM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        
        }

        public void LlenarCombo1(ComboBox c,string consulta,string campo)
        { 
            ComboBox cmb=c as ComboBox;
            try
            {
                conn.Open();
                cmm = new SqlCommand(consulta, conn);
                reader = cmm.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        cmb.Items.Add(reader[campo].ToString().Trim());
                    
                    }
                
                
                }



                conn.Close();


            }
            catch (Exception)

            {
                MessageBox.Show("Error recuperando secciones", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        
        
        }









    }
}
