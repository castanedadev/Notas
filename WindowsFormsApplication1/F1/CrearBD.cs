using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1.F1
{
    class CrearBD
    {
        StreamReader reader;
        public CrearBD(string direccion)
        {
            try
            {

                reader = new StreamReader("C:\\Program Files\\Nueva Carpeta\\script.dll");


            }
            catch
            {
                try
                {
                    reader = new StreamReader("C:\\Program Files (x86)\\Nueva Carpeta\\script.dll");

                }
                catch
                {
                    try
                    {
                        reader = new StreamReader("C:\\Nueva Carpeta\\script.dll");
                    }
                    catch
                    {
                        try
                        {
                            reader = new StreamReader(direccion + "\\script.dll");

                        }
                        catch
                        {
                            MessageBox.Show("Falta la directiva 'Inicialización de la base de datos' contacte al equipo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                }
            }


        } //fin del constructor


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
                        if (linea[linea.Length - 1] != ';')
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

        public void CrearBDTablas()
        {
            string cadena = "server=(localdb)\\Escuelas;database=master;integrated security=yes";
            SqlConnection conn = new SqlConnection(cadena);
            try
            {

                List<string> querys = Comandos();
                SqlCommand cmm;
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
                MessageBox.Show(ex + "");

            }



        }


    }
}
