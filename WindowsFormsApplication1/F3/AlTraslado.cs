using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Collections;
namespace WindowsFormsApplication1.F3
{
    class AlTraslado
    {
        SqlConnection conn;
        SqlCommand cmm;
        SqlDataReader reader;
        public static Hashtable rer;
        public static List<F2.PropiedadAlumno> alumnos;
        public static List<F2.PropiedadAlumno> Repetidos;


        public AlTraslado()
        {
            conn = ConexionRepositorio.Cnn();
            alumnos = new List<F2.PropiedadAlumno>();
           
        }


        public void GetListBox(ListBox lb, int año, int  grado, int  seccion,string procedimiento,string nombre)
        {
            Repetidos = new List<F2.PropiedadAlumno>();
        
            int c = 0;
           alumnos=GetAlumnos(año, grado, seccion,procedimiento,nombre);
           rer = new Hashtable();
            ListBox LB = lb as ListBox;
            LB.Items.Clear();
            if (alumnos.Count>0)
            {
                LB.Enabled = true;
                foreach (F2.PropiedadAlumno item in alumnos)
                {
                    rer.Add(item.Nombre, c);
                    LB.Items.Add(item.Nombre);


                    c++;


                }
            }
            else
            {
                LB.Items.Add("No hay alumnos para ");
                LB.Items.Add("estos parámetros del repositorio");
                LB.Enabled = false;
            }


        
        
        }


        internal List<F2.PropiedadAlumno> GetAlumnos(int año,int grado, int seccion,string procedimiento,string nombre)
        {

            List<F2.PropiedadAlumno> temp = new List<F2.PropiedadAlumno>();
            try
            {
                F2.PropiedadAlumno alumno;
                cmm = new SqlCommand(procedimiento, conn);

                cmm.CommandType = CommandType.StoredProcedure;
                cmm.Parameters.AddWithValue("@ano", año);
                //Busqueda añosecciongrado
                if (procedimiento == "GetAl")
                {
                    cmm.Parameters.AddWithValue("@grado", grado);
                    cmm.Parameters.AddWithValue("@seccion", seccion);
                   
                }
                    //Busqueda año -nombre
                else if (procedimiento == "GetAl2")
                {
                    nombre = nombre + "%";
                    cmm.Parameters.AddWithValue("@nombre", nombre);

                }


                conn.Open();
                reader = cmm.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        alumno = new F2.PropiedadAlumno();
                        alumno.Nie = reader["NIE"].ToString().Trim();
                        alumno.Nombre = reader["Nombre"].ToString().Trim();
                        alumno.Fechanac = reader["Fecha_nac"].ToString().Trim();
                        alumno.Direccion = reader["Direccion"].ToString().Trim();
                        alumno.Telefono = reader["Telefono"].ToString().Trim();
                        alumno.Responsable = reader["Responsable"].ToString().Trim();
                        alumno.Grado = int.Parse(reader["Grado"].ToString().Trim())+1;
                        alumno.Seccion = int.Parse(reader["Seccion"].ToString().Trim());

                        if (alumno.Grado != 13)
                        {
                            alumno.Grado = alumno.Grado + 1;
                        }
                      


                        temp.Add(alumno);
                    
                    }
                    
                
                }


                conn.Close();

                return temp;
            }
            catch
            {

                conn.Close();
                return null;
            }
        
        
        }

        public void Recuperar(F2.PropiedadAlumno n)
        {
            SqlConnection conn = Conexion.Cnn();
            F2.PropiedadAlumno item = n as F2.PropiedadAlumno;
           
            try
            {


                string cadena = "SELECT * FROM ALUMNO WHERE NIE='" + item.Nie+ "'";
                SqlCommand cmm = new SqlCommand(cadena, conn);
                SqlDataReader reader;

                reader = cmm.ExecuteReader();
                if (reader.HasRows)
                {
                    Repetidos.Add(item);
                    return;
                }
                reader.Close();

                item.Estado = 1;
                cmm = new SqlCommand("Ingresaralumnos", conn);
                cmm.CommandType = CommandType.StoredProcedure;
                cmm.Parameters.AddWithValue("@NIE", item.Nie);
                cmm.Parameters.AddWithValue("@Nombre", item.Nombre);
                cmm.Parameters.AddWithValue("@Fecha_nac", item.Fechanac);
                cmm.Parameters.AddWithValue("@Telefono", item.Telefono);
                cmm.Parameters.AddWithValue("@Direccion", item.Direccion);
                cmm.Parameters.AddWithValue("@Responsable", item.Responsable);
                cmm.Parameters.AddWithValue("@Grado", item.Grado);
                cmm.Parameters.AddWithValue("@Seccion",item.Seccion );
                
                cmm.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message, "Error retornando alumnos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }




    
    
    
    }
}
