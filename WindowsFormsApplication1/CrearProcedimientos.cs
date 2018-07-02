using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    class CrearProcedimientos
    {
        StreamReader reader;
        public CrearProcedimientos(string direccion)
        {
            try
            {

                reader = new StreamReader("C:\\Program Files\\Nueva Carpeta\\script1.dll");



            }
            catch
            {
                try
                {
                    reader = new StreamReader("C:\\Program Files (x86)\\Nueva Carpeta\\script1.dll");

                }
                catch
                {
                    try
                    {
                        reader = new StreamReader("C:\\Nueva Carpeta\\script1.dll");
                    }
                    catch
                    {
                        try
                        {
                            reader = new StreamReader(direccion + "\\script1.dll");

                        }
                        catch
                        {
                            MessageBox.Show("Falta la directiva 'Inicialización de la base de datos' contacte al equipo");

                        }
                    }
                }
            }


        }

        internal List<string> Comandos()
        {

            List<string> querys = new List<string>();
            string linea = "";
            string query = "";
            while (linea != null)
            {
                linea = reader.ReadLine();
                if (linea != null)
                {
                    if (linea != "FIN")
                    {
                        if (linea != "END" && linea != "end")
                        {
                            query += linea + "\n";

                        }
                        else
                        {
                            query += linea;
                            querys.Add(query);
                            query = "";
                        }
                    }
                    else
                    {
                        break;
                    }
                }

            }
            reader.Close();
            return querys;
        }

        SqlConnection conn = new SqlConnection("server=(localdb)\\Escuelas;pwd=;uid=;database=Escuela");
        public void CrearProcedures()
        {
            List<string> querys = Comandos();
            SqlCommand cmm;
            try
            {



                conn.Open();
                foreach (string item in querys)
                {
                    cmm = new SqlCommand(item, conn);
                    cmm.ExecuteNonQuery();
                }
                conn.Close();

            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex + "Error al crear los procedimientos");
            }



        }
        public void Insertar()
        {
            List<string> querys = Inserciones();
            SqlCommand cmm;
            try
            {



                conn.Open();
                foreach (string item in querys)
                {
                    cmm = new SqlCommand(item, conn);
                    cmm.ExecuteNonQuery();
                }
                conn.Close();

            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex + "Error al crear los procedimientos");
            }



        }




        int c = 0;
        public void NombreE(string NE)
        {
            try
            {
                string cadena = "INSERT INTO NE VALUES('" + NE + "')";
                SqlCommand cnn = new SqlCommand(cadena, conn);
                conn.Open();
                cnn.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Instalación de la BD finalizada");

            }
            catch
            {
                conn.Close();
                c++;
                if (c < 10)
                {
                    NombreE(NE);
                }


            }


        }


        internal List<string> Inserciones()
        {
            List<string> insert = new List<string>();
            insert.Add("INSERT INTO SECCION VALUES ('N')");
            insert.Add("INSERT INTO GRADO VALUES ('N')");
            insert.Add("INSERT INTO TRIMESTRE VALUES ('Trimestre 1')");
            insert.Add("INSERT INTO TRIMESTRE VALUES ('Trimestre 2')");
            insert.Add("INSERT INTO TRIMESTRE VALUES ('Trimestre 3')");
            insert.Add("INSERT INTO ESTADO VALUES ('Activo')");
            insert.Add("INSERT INTO ESTADO VALUES ('Inactivo')");
            insert.Add("INSERT INTO TipoUsuario VALUES ('Director')");
            insert.Add("INSERT INTO TipoUsuario VALUES ('Maestro')");



            return insert;



        }




    }
}
