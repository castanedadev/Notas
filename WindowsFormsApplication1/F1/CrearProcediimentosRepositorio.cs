using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApplication1.F1
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
                            MessageBox.Show("Falta la directiva 'Inicialización de la base de datos' contacte al equipo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
                MessageBox.Show(ex + "Error al crear los procedimientos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show(ex + "Error al crear los procedimientos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }



        internal List<string> Inserciones()
        {
            List<string> insert = new List<string>();
            insert.Add("INSERT INTO TRIMESTRE VALUES ('Trimestre 1')");
            insert.Add("INSERT INTO TRIMESTRE VALUES ('Trimestre 2')");
            insert.Add("INSERT INTO TRIMESTRE VALUES ('Trimestre 3')");
            insert.Add("INSERT INTO ESTADO VALUES ('Activo')");
            insert.Add("INSERT INTO ESTADO VALUES ('Inactivo')");
            
            insert.Add("INSERT INTO GRADO VALUES('N')");
            insert.Add("INSERT INTO SECCION VALUES ('N')");
            insert.Add("INSERT INTO GRADO VALUES('Primer grado')");
            insert.Add("INSERT INTO GRADO VALUES('Segundo grado')");
            insert.Add("INSERT INTO GRADO VALUES('Tercer grado')");
            insert.Add("INSERT INTO GRADO VALUES('Cuarto grado')");
            insert.Add("INSERT INTO GRADO VALUES('Quinto grado')");
            insert.Add("INSERT INTO GRADO VALUES('Sexto grado')");
            insert.Add("INSERT INTO GRADO VALUES('Séptimo grado')");
            insert.Add("INSERT INTO GRADO VALUES('Octavo grado')");
            insert.Add("INSERT INTO GRADO VALUES('Noveno grado')");
            insert.Add("INSERT INTO GRADO VALUES('Primer año')");
            insert.Add("INSERT INTO GRADO VALUES('Segundo año')");
            insert.Add("INSERT INTO SECCION VALUES('A')");
            insert.Add("INSERT INTO SECCION VALUES('B')");
            insert.Add("INSERT INTO MATERIA VALUES('Matemáticas')");
            insert.Add("INSERT INTO MATERIA VALUES('Lenguaje')");
            insert.Add("INSERT INTO MATERIA VALUES('Sociales')");
            insert.Add("INSERT INTO MATERIA VALUES('Ciencias naturales')");
            insert.Add("INSERT INTO MATERIA VALUES('Educación física')");
            insert.Add("INSERT INTO MATERIA VALUES('Artística')");
            insert.Add("INSERT INTO MATERIA VALUES('Inglés')");
            insert.Add("INSERT INTO MATERIA VALUES('Computación')");
            insert.Add("INSERT INTO MATERIA VALUES('Habilitación laboral')");
            insert.Add("INSERT INTO MATERIA VALUES('Orientación para la vida')");
            insert.Add("INSERT INTO MATERIA VALUES('Seminario')");
            insert.Add("INSERT INTO NivelGradoSeccion VALUES(2,2)");
            insert.Add("INSERT INTO NivelGradoSeccion VALUES(2,3)");
            insert.Add("INSERT INTO NivelGradoSeccion VALUES(3,2)");
            insert.Add("INSERT INTO NivelGradoSeccion VALUES(3,3)");
            insert.Add("INSERT INTO NivelGradoSeccion VALUES(4,2)");
            insert.Add("INSERT INTO NivelGradoSeccion VALUES(4,3)");
            insert.Add("INSERT INTO NivelGradoSeccion VALUES(5,2)");
            insert.Add("INSERT INTO NivelGradoSeccion VALUES(5,3)");
            insert.Add("INSERT INTO NivelGradoSeccion VALUES(6,2)");
            insert.Add("INSERT INTO NivelGradoSeccion VALUES(6,3)");
            insert.Add("INSERT INTO NivelGradoSeccion VALUES(7,2)");
            insert.Add("INSERT INTO NivelGradoSeccion VALUES(7,3)");
            insert.Add("INSERT INTO NivelGradoSeccion VALUES(8,2)");
            insert.Add("INSERT INTO NivelGradoSeccion VALUES(8,3)");
            insert.Add("INSERT INTO NivelGradoSeccion VALUES(9,2)");
            insert.Add("INSERT INTO NivelGradoSeccion VALUES(9,3)");
            insert.Add("INSERT INTO NivelGradoSeccion VALUES(10,2)");
            insert.Add("INSERT INTO NivelGradoSeccion VALUES(10,3)");
            insert.Add("INSERT INTO NivelGradoSeccion VALUES(11,2)");
            insert.Add("INSERT INTO NivelGradoSeccion VALUES(11,3)");
            insert.Add("INSERT INTO NivelGradoSeccion VALUES(12,2)");
            insert.Add("INSERT INTO NivelGradoSeccion VALUES(12,3)");
            insert.Add("INSERT INTO MateriaGrado VALUES(1,2)");
            insert.Add("INSERT INTO MateriaGrado VALUES(2,2)");
            insert.Add("INSERT INTO MateriaGrado VALUES(3,2)");
            insert.Add("INSERT INTO MateriaGrado VALUES(4,2)");
            insert.Add("INSERT INTO MateriaGrado VALUES(5,2)");
            insert.Add("INSERT INTO MateriaGrado VALUES(6,2)");
            insert.Add("INSERT INTO MateriaGrado VALUES(1,3)");
            insert.Add("INSERT INTO MateriaGrado VALUES(2,3)");
            insert.Add("INSERT INTO MateriaGrado VALUES(3,3)");
            insert.Add("INSERT INTO MateriaGrado VALUES(4,3)");
            insert.Add("INSERT INTO MateriaGrado VALUES(5,3)");
            insert.Add("INSERT INTO MateriaGrado VALUES(6,3)");
            insert.Add("INSERT INTO MateriaGrado VALUES(1,4)");
            insert.Add("INSERT INTO MateriaGrado VALUES(2,4)");
            insert.Add("INSERT INTO MateriaGrado VALUES(3,4)");
            insert.Add("INSERT INTO MateriaGrado VALUES(4,4)");
            insert.Add("INSERT INTO MateriaGrado VALUES(5,4)");
            insert.Add("INSERT INTO MateriaGrado VALUES(6,4)");
            insert.Add("INSERT INTO MateriaGrado VALUES(1,5)");
            insert.Add("INSERT INTO MateriaGrado VALUES(2,5)");
            insert.Add("INSERT INTO MateriaGrado VALUES(3,5)");
            insert.Add("INSERT INTO MateriaGrado VALUES(4,5)");
            insert.Add("INSERT INTO MateriaGrado VALUES(5,5)");
            insert.Add("INSERT INTO MateriaGrado VALUES(6,5)");
            insert.Add("INSERT INTO MateriaGrado VALUES(7,5)");
            insert.Add("INSERT INTO MateriaGrado VALUES(8,5)");
            insert.Add("INSERT INTO MateriaGrado VALUES(1,6)");
            insert.Add("INSERT INTO MateriaGrado VALUES(2,6)");
            insert.Add("INSERT INTO MateriaGrado VALUES(3,6)");
            insert.Add("INSERT INTO MateriaGrado VALUES(4,6)");
            insert.Add("INSERT INTO MateriaGrado VALUES(5,6)");
            insert.Add("INSERT INTO MateriaGrado VALUES(6,6)");
            insert.Add("INSERT INTO MateriaGrado VALUES(7,6)");
            insert.Add("INSERT INTO MateriaGrado VALUES(8,6)");
            insert.Add("INSERT INTO MateriaGrado VALUES(1,7)");
            insert.Add("INSERT INTO MateriaGrado VALUES(2,7)");
            insert.Add("INSERT INTO MateriaGrado VALUES(3,7)");
            insert.Add("INSERT INTO MateriaGrado VALUES(4,7)");
            insert.Add("INSERT INTO MateriaGrado VALUES(5,7)");
            insert.Add("INSERT INTO MateriaGrado VALUES(6,7)");
            insert.Add("INSERT INTO MateriaGrado VALUES(7,7)");
            insert.Add("INSERT INTO MateriaGrado VALUES(8,7)");
            insert.Add("INSERT INTO MateriaGrado VALUES(1,8)");
            insert.Add("INSERT INTO MateriaGrado VALUES(2,8)");
            insert.Add("INSERT INTO MateriaGrado VALUES(3,8)");
            insert.Add("INSERT INTO MateriaGrado VALUES(4,8)");
            insert.Add("INSERT INTO MateriaGrado VALUES(5,8)");
            insert.Add("INSERT INTO MateriaGrado VALUES(6,8)");
            insert.Add("INSERT INTO MateriaGrado VALUES(7,8)");
            insert.Add("INSERT INTO MateriaGrado VALUES(8,8)");
            insert.Add("INSERT INTO MateriaGrado VALUES(1,9)");
            insert.Add("INSERT INTO MateriaGrado VALUES(2,9)");
            insert.Add("INSERT INTO MateriaGrado VALUES(3,9)");
            insert.Add("INSERT INTO MateriaGrado VALUES(4,9)");
            insert.Add("INSERT INTO MateriaGrado VALUES(5,9)");
            insert.Add("INSERT INTO MateriaGrado VALUES(6,9)");
            insert.Add("INSERT INTO MateriaGrado VALUES(7,9)");
            insert.Add("INSERT INTO MateriaGrado VALUES(8,9)");
            insert.Add("INSERT INTO MateriaGrado VALUES(1,10)");
            insert.Add("INSERT INTO MateriaGrado VALUES(2,10)");
            insert.Add("INSERT INTO MateriaGrado VALUES(3,10)");
            insert.Add("INSERT INTO MateriaGrado VALUES(4,10)");
            insert.Add("INSERT INTO MateriaGrado VALUES(5,10)");
            insert.Add("INSERT INTO MateriaGrado VALUES(6,10)");
            insert.Add("INSERT INTO MateriaGrado VALUES(7,10)");
            insert.Add("INSERT INTO MateriaGrado VALUES(8,10)");
            insert.Add("INSERT INTO MateriaGrado VALUES(1,11)");
            insert.Add("INSERT INTO MateriaGrado VALUES(2,11)");
            insert.Add("INSERT INTO MateriaGrado VALUES(3,11)");
            insert.Add("INSERT INTO MateriaGrado VALUES(4,11)");
            insert.Add("INSERT INTO MateriaGrado VALUES(7,11)");
            insert.Add("INSERT INTO MateriaGrado VALUES(8,11)");
            insert.Add("INSERT INTO MateriaGrado VALUES(9,11)");
            insert.Add("INSERT INTO MateriaGrado VALUES(10,11)");
            insert.Add("INSERT INTO MateriaGrado VALUES(11,11)");
            insert.Add("INSERT INTO MateriaGrado VALUES(1,12)");
            insert.Add("INSERT INTO MateriaGrado VALUES(2,12)");
            insert.Add("INSERT INTO MateriaGrado VALUES(3,12)");
            insert.Add("INSERT INTO MateriaGrado VALUES(4,12)");
            insert.Add("INSERT INTO MateriaGrado VALUES(7,12)");
            insert.Add("INSERT INTO MateriaGrado VALUES(8,12)");
            insert.Add("INSERT INTO MateriaGrado VALUES(9,12)");
            insert.Add("INSERT INTO MateriaGrado VALUES(10,12)");
            insert.Add("INSERT INTO MateriaGrado VALUES(11,12)");


            return insert;

        }



    }
}
