using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace WindowsFormsApplication1
{
    class CrearProcediimentosRepositorio
    {

        StreamReader reader;

        public CrearProcediimentosRepositorio(string direccion)
        {
            try
            {

                reader = new StreamReader("C:\\Program Files\\Nueva Carpeta\\repositorio1.dll");



            }
            catch
            {
                try
                {
                    reader = new StreamReader("C:\\Program Files (x86)\\Nueva Carpeta\\repositorio1.dll");

                }
                catch
                {
                    try
                    {
                        reader = new StreamReader("C:\\Nueva Carpeta\\repositorio1.dll");
                    }
                    catch
                    {
                        try
                        {
                            reader = new StreamReader(direccion + "\\repoprueba1.dll");

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

        SqlConnection conn = new SqlConnection("server=(localdb)\\Escuelas;pwd=;uid=;database=Repositorio");
        public void CrearProcedures()
        {
            string ayuda = "";
            List<string> querys = Comandos();
            SqlCommand cmm;
            try
            {
                conn.Open();
                foreach (string item in querys)
                {
                    // MessageBox.Show(item);
                    ayuda = item;

                    cmm = new SqlCommand(item, conn);
                    cmm.ExecuteNonQuery();
                }
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ayuda);
                conn.Close();
                MessageBox.Show(ex + "Error al crear los procedimientos");
            }



        }
        public void Insertar()
        {
            string ayuda = "";
            List<string> querys = Inserciones();
            SqlCommand cmm;
            try
            {
                conn.Open();
                foreach (string item in querys)
                {
                    ayuda = item;

                    cmm = new SqlCommand(item, conn);
                    cmm.ExecuteNonQuery();
                }
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ayuda);
                conn.Close();
                MessageBox.Show(ex + "Error al crear los procedimientos");
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


            return insert;



        }




    }
}
