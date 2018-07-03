using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
namespace WindowsFormsApplication1.F2
{
    class Transferencia
    {

        public static int IdAño;

        SqlConnection conOrignal;
        SqlConnection conRepositorio;
        SqlCommand cmm;
        SqlDataReader reader;

        public Transferencia()
        {
            conOrignal = ConexionK.Cnn();
            conRepositorio = ConexionRepositorio.Cnn();


        }

        public bool comprobar(string id, string pass)
        {
            bool retorno = false;
            int auxiliar1 = 0, auxiliar2 = 0;
            try
            {
                string cadena = "SELECT IdDirector,pass FROM Director";
                cmm = new SqlCommand(cadena, conOrignal);
                conOrignal.Open();
                reader = cmm.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        if ((reader["IdDirector"].ToString().Trim()) == id)
                        {

                            auxiliar1 = 1;

                            if ((reader["pass"].ToString().Trim()) == pass)
                                auxiliar2 = 1;


                            break;
                        }

                    }



                }

                if (auxiliar1 == 1 && auxiliar2 == 1)
                    retorno = true;
                else
                    retorno = false;


                conOrignal.Close();
                return retorno;

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error comprobando perfil \n\n" + ex.ToString());

                conOrignal.Close();

                return false;

            }



        }



        public void LlenarComboAño(ComboBox obj)
        {
            try
            {
                ComboBox cb = obj as ComboBox;
                List<int> qu = new List<int>();
                string cadena = "SELECT * FROM ANO";
                cmm = new SqlCommand(cadena, conRepositorio);

                for (int i = 2010; i <= 2030; i++)
                {
                    //MessageBox.Show("un puto cambio");
                    cb.Items.Add(i);

                }

                conRepositorio.Open();
                reader = cmm.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string quit = reader["ano"].ToString().Trim();
                        for (int i = 0; i <= 20; i++)
                        {
                            cb.SelectedIndex = i;

                            if (cb.Text == quit)
                            {
                                int g = 2010;
                                qu.Add(g + i);
                                break;



                            }

                        }



                    }
                }

                conRepositorio.Close();
                cb.Items.Clear();

                for (int i = 2010; i <= 2030; i++)
                {
                    int auxiliar = 1;
                    foreach (int item in qu)
                    {
                        if (item == i)
                        {

                            auxiliar = 0;
                            break;

                        }
                    }

                    if (auxiliar == 1)
                    {
                        cb.Items.Add(i);
                    }



                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erroren el llenado de combo \n\n" + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                conRepositorio.Close();
            }




        }



        public void CrearIdAño(string año)
        {



            try
            {
                conRepositorio.Open();
                string cdn = "INSERT INTO ANO VALUES ('" + año + "')";
                cmm = new SqlCommand(cdn, conRepositorio);
                cmm.ExecuteNonQuery();

                cdn = "SELECT IdAno FROM ANO WHERE Ano='" + año + "'";
                SqlCommand n = new SqlCommand(cdn, conRepositorio);

                reader = n.ExecuteReader();
                if (reader.HasRows)
                {
                    if (reader.Read())
                    {
                        IdAño = int.Parse(reader["IdAno"].ToString().TrimEnd());


                    }
                }

                conRepositorio.Close();


            }
            catch
            {

                conRepositorio.Close();
            }

        }

        public void RealizarTransFerencias()
        {

            TransferirDocentes();
            TransferirAlumnos();
            TransferirNGM();
            TransferirActividad();
            TransferirPorcentaje();
            TransferirRegistro();

            VaciaOriginal();


        }


        //internal void Transferir1Parametro(string tabla,string campo, string procedimiento, string parametro,string campoID)
        //{
        //    try
        //    {
        //        conOrignal.Open();
        //        string comm = "SELECT * FROM "+tabla;
        //        cmm = new SqlCommand(comm, conOrignal);

        //        reader = cmm.ExecuteReader();

        //        if (reader.HasRows)
        //        {
        //            while (reader.Read())
        //            {
        //                int ayuda = int.Parse(reader[campoID].ToString().Trim());
        //                if (ayuda != 1)
        //                {
        //                    try
        //                    {
        //                        conRepositorio.Open();
        //                        string aux = reader[campo].ToString().Trim();
        //                        SqlCommand command = new SqlCommand(procedimiento, conRepositorio);
        //                        command.CommandType = CommandType.StoredProcedure;
        //                        command.Parameters.AddWithValue(parametro, aux);
        //                        command.ExecuteNonQuery();
        //                        conRepositorio.Close();
        //                    }
        //                    catch (Exception ex)
        //                    {
        //                        MessageBox.Show("Error" + ex);
        //                        conRepositorio.Close();
        //                    }
        //                }
        //                else

        //                {

        //                        string aux = reader[campo].ToString().Trim();

        //                }


        //            }
        //        }
        //        conOrignal.Close();


        //    }
        //    catch

        //    {
        //        conOrignal.Close();

        //    }



        //}


        internal int ComprobarExistencia1Parametro(string procedimiento, string parametro, int tipodedato)
        {
            int auxiliar = 0;
            try
            {
                string cadena = "declare @retorno int;";
                //si es tipo cadena
                if (tipodedato == 0)
                    cadena += "exec @retorno= " + procedimiento + " '" + parametro + "';";
                //si es tipo entero
                if (tipodedato == 1)
                    cadena += "exec @retorno= " + procedimiento + " " + parametro + ";";
                cadena += "select @retorno as 'Retorno';";

                conRepositorio.Open();
                cmm = new SqlCommand(cadena, conRepositorio);
                reader = cmm.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        auxiliar = int.Parse(reader["Retorno"].ToString().Trim());

                    }
                }



                conRepositorio.Close();
                return auxiliar;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                conRepositorio.Close();
                return 2;
            }


        }

        internal void TransferirDocentes()
        {
            List<PropiedadMaestro> n = GetProfesores();
            foreach (PropiedadMaestro item in n)
            {

                TransDocente(item);



            }

        }


        internal void TransDocente(PropiedadMaestro p)
        {

            int pro = ComprobarExistencia1Parametro("ComprobarIdMaestro", p.IdMaestro, 0);
            if (pro == 1)
            {
                int grado = p.Grado;
                int seccion = p.Seccion;
                SqlCommand Ingresar = new SqlCommand("IngresarDocente", conRepositorio);
                Ingresar.CommandType = CommandType.StoredProcedure;
                Ingresar.Parameters.AddWithValue("@idmaestro", p.IdMaestro);
                Ingresar.Parameters.AddWithValue("@fecha", p.Fecha);
                Ingresar.Parameters.AddWithValue("@Nombre", p.Nombre);

                try
                {
                    conRepositorio.Open();
                    Ingresar.ExecuteNonQuery();
                    conRepositorio.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    conRepositorio.Close();
                }


                SqlCommand enviarM = new SqlCommand("IngresarMaestroAno", conRepositorio);
                enviarM.CommandType = CommandType.StoredProcedure;
                enviarM.Parameters.AddWithValue("@IdMaestro", p.IdMaestro);
                enviarM.Parameters.AddWithValue("@Telefono", p.Telefono);
                enviarM.Parameters.AddWithValue("@Direccion", p.Direccion);
                if (p.Tutor == 1)
                {
                    enviarM.Parameters.AddWithValue("@Grado", p.Grado);
                    enviarM.Parameters.AddWithValue("@Seccion", p.Seccion);

                }

                if (p.Tutor == 0)
                {
                    enviarM.Parameters.AddWithValue("@Grado", 1);
                    enviarM.Parameters.AddWithValue("@Seccion", 1);

                }


                enviarM.Parameters.AddWithValue("@IdAno", IdAño);
                enviarM.Parameters.AddWithValue("@Estado", p.Estado);
                try
                {
                    conRepositorio.Open();
                    enviarM.ExecuteNonQuery();
                    conRepositorio.Close();

                }
                catch
                {
                    conRepositorio.Close();
                    MessageBox.Show("Ha ocurrido un error transfiriendo al profesor " + p.Nombre, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {

                string consulta = "UPDATE Maestros SET Nombre= '" + p.Nombre;
                consulta += "',Fecha= '" + p.Fecha + "' WHERE IdMaestro= '" + p.IdMaestro + "'";

                SqlCommand cmm = new SqlCommand(consulta, conRepositorio);
                try
                {
                    conRepositorio.Open();
                    cmm.ExecuteNonQuery();
                    conRepositorio.Close();



                }
                catch
                {
                    conRepositorio.Close();
                    MessageBox.Show("Error actualizando maestro en repositorio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }



                SqlCommand enviarM = new SqlCommand("IngresarMaestroAno", conRepositorio);
                enviarM.CommandType = CommandType.StoredProcedure;
                enviarM.Parameters.AddWithValue("@IdMaestro", p.IdMaestro);
                enviarM.Parameters.AddWithValue("@Telefono", p.Telefono);
                enviarM.Parameters.AddWithValue("@Direccion", p.Direccion);

                if (p.Tutor == 1)
                {
                    enviarM.Parameters.AddWithValue("@Grado", p.Grado);
                    enviarM.Parameters.AddWithValue("@Seccion", p.Seccion);

                }

                if (p.Tutor == 0)
                {
                    enviarM.Parameters.AddWithValue("@Grado", 1);
                    enviarM.Parameters.AddWithValue("@Seccion", 1);

                }


                enviarM.Parameters.AddWithValue("@IdAno", IdAño);
                enviarM.Parameters.AddWithValue("@Estado", p.Estado);
                try
                {
                    conRepositorio.Open();
                    enviarM.ExecuteNonQuery();
                    MessageBox.Show("Profesor " + p.Nombre + " enviado");
                    conRepositorio.Close();

                }
                catch
                {
                    conRepositorio.Close();
                    MessageBox.Show("Ha ocurrido un error transfiriendo al profesor " + p.Nombre, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }

        internal void TransAlumno(PropiedadAlumno a)
        {
            int pro = ComprobarExistencia1Parametro("ComprobarNIE", a.Nie, 0);

            if (pro == 1)
            {
                cmm = new SqlCommand("IngresarAlumno", conRepositorio);
                cmm.CommandType = CommandType.StoredProcedure;
                cmm.Parameters.AddWithValue("@NIE", a.Nie);
                cmm.Parameters.AddWithValue("@Nombre", a.Nombre);
                cmm.Parameters.AddWithValue("@Fecha_Nac", a.Fechanac);

                try
                {
                    conRepositorio.Open();
                    cmm.ExecuteNonQuery();
                    conRepositorio.Close();

                }
                catch
                {
                    MessageBox.Show("Error al enviar estudiante", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    conRepositorio.Close();
                }

                SqlCommand cmm2 = new SqlCommand("IngresarAlumnoAno", conRepositorio);
                cmm2.CommandType = CommandType.StoredProcedure;

                cmm2.Parameters.AddWithValue("@NIE", a.Nie);
                cmm2.Parameters.AddWithValue("@Telefono", a.Telefono);
                cmm2.Parameters.AddWithValue("@Direccion", a.Direccion);
                cmm2.Parameters.AddWithValue("@Responsable", a.Responsable);
                cmm2.Parameters.AddWithValue("@Grado", a.Grado);
                cmm2.Parameters.AddWithValue("@Seccion", a.Seccion);
                cmm2.Parameters.AddWithValue("@Estado", a.Estado);
                cmm2.Parameters.AddWithValue("@ano", IdAño);
                try
                {
                    conRepositorio.Open();
                    cmm2.ExecuteNonQuery();
                    conRepositorio.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    conRepositorio.Close();
                }


            }

            else
            {

                SqlCommand cmm2 = new SqlCommand("IngresarAlumnoAno", conRepositorio);
                cmm2.CommandType = CommandType.StoredProcedure;

                cmm2.Parameters.AddWithValue("@NIE", a.Nie);
                cmm2.Parameters.AddWithValue("@Telefono", a.Telefono);
                cmm2.Parameters.AddWithValue("@Direccion", a.Direccion);
                cmm2.Parameters.AddWithValue("@Responsable", a.Responsable);
                cmm2.Parameters.AddWithValue("@Grado", a.Grado);
                cmm2.Parameters.AddWithValue("@Seccion", a.Seccion);
                cmm2.Parameters.AddWithValue("@Estado", a.Estado);
                cmm2.Parameters.AddWithValue("@ano", IdAño);
                try
                {
                    conRepositorio.Open();
                    cmm2.ExecuteNonQuery();
                    conRepositorio.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    conRepositorio.Close();
                }


            }


        }

        internal void TransferirAlumnos()
        {
            try
            {
                List<PropiedadAlumno> alumnos = GetAlumnos();

                foreach (PropiedadAlumno a in alumnos)
                {
                    TransAlumno(a);
                }

            }

            catch
            {

            }


        }

        internal void TransferirNGM()
        {

            try
            {

                string comm = "SELECT * FROM NGM";
                cmm = new SqlCommand(comm, conOrignal);

                conOrignal.Open();
                reader = cmm.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        try
                        {
                            conRepositorio.Open();
                            string IdMaestro = reader["Maestro"].ToString().Trim();
                            int Grado = int.Parse(reader["Grado"].ToString().Trim());
                            int Materia = int.Parse(reader["Materia"].ToString().Trim());
                            int Seccion = int.Parse(reader["Seccion"].ToString().Trim());
                            int Estado = int.Parse(reader["Estado"].ToString().Trim());

                            SqlCommand command = new SqlCommand("IngresarNGM", conRepositorio);
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@IdMaestro", IdMaestro);
                            command.Parameters.AddWithValue("@Grado", Grado);
                            command.Parameters.AddWithValue("@Materia", Materia);
                            command.Parameters.AddWithValue("@seccion", Seccion);
                            command.Parameters.AddWithValue("@estado", Estado);
                            command.Parameters.AddWithValue("@ano", IdAño);
                            command.ExecuteNonQuery();
                            conRepositorio.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error" + ex);
                            conRepositorio.Close();
                        }


                    }

                }
                conOrignal.Close();
            }
            catch
            {

                MessageBox.Show("Error transpotando", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conOrignal.Close();

            }

        }


        internal void TransferirActividad()
        {

            try
            {

                string comm = "SELECT * FROM ACTIVIDADES";
                cmm = new SqlCommand(comm, conOrignal);

                conOrignal.Open();
                reader = cmm.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        try
                        {
                            conRepositorio.Open();
                            string Actividad = reader["Actividad"].ToString().Trim();
                            int Materia = int.Parse(reader["Materia"].ToString().Trim());
                            int Grado = int.Parse(reader["Grado"].ToString().Trim());
                            int Seccion = int.Parse(reader["Seccion"].ToString().Trim());
                            int Trimestre = int.Parse(reader["Trimestre"].ToString().Trim());
                            int Periodo = int.Parse(reader["Periodo"].ToString().Trim());
                            double Ponderacion = double.Parse(reader["Ponderacion"].ToString().Trim());

                            SqlCommand command = new SqlCommand("IngresarActividades", conRepositorio);
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@Actividad", Actividad);
                            command.Parameters.AddWithValue("@Materia", Materia);
                            command.Parameters.AddWithValue("@Grado", Grado);
                            command.Parameters.AddWithValue("@Seccion", Seccion);
                            command.Parameters.AddWithValue("@Trimestre", Trimestre);
                            command.Parameters.AddWithValue("@Periodo", Periodo);
                            command.Parameters.AddWithValue("@Ponderacion", Ponderacion);
                            command.ExecuteNonQuery();
                            conRepositorio.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error" + ex);
                            conRepositorio.Close();
                        }


                    }

                }
                conOrignal.Close();
            }
            catch
            {

                MessageBox.Show("Error transpotando actvidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conOrignal.Close();

            }

        }

        internal void TransferirPorcentaje()
        {

            try
            {

                string comm = "SELECT * FROM PorcentajeMateria";
                cmm = new SqlCommand(comm, conOrignal);

                conOrignal.Open();
                reader = cmm.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        try
                        {
                            conRepositorio.Open();
                            string Alumno = reader["Alumno"].ToString().Trim();
                            int Materia = int.Parse(reader["Materia"].ToString().Trim());
                            int Trimestre = int.Parse(reader["Trimestre"].ToString().Trim());
                            int Periodo = int.Parse(reader["Periodo"].ToString().Trim());
                            double Porcentaje = double.Parse(reader["Porcentaje"].ToString().Trim());

                            SqlCommand command = new SqlCommand("IngresarPorcentaje", conRepositorio);
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@Alumno", Alumno);
                            command.Parameters.AddWithValue("@Materia", Materia);
                            command.Parameters.AddWithValue("@Trimestre", Trimestre);
                            command.Parameters.AddWithValue("@Periodo", Periodo);
                            command.Parameters.AddWithValue("@Porcentaje", Porcentaje);
                            command.Parameters.AddWithValue("@ano", IdAño);
                            command.ExecuteNonQuery();
                            conRepositorio.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error" + ex);
                            conRepositorio.Close();
                        }


                    }

                }
                conOrignal.Close();
            }
            catch
            {

                MessageBox.Show("Error transpotando porcentaje", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conOrignal.Close();

            }

        }


        internal void TransferirRegistro()
        {

            try
            {

                string comm = "SELECT * FROM REGISTRO";
                cmm = new SqlCommand(comm, conOrignal);

                conOrignal.Open();
                reader = cmm.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        try
                        {
                            conRepositorio.Open();
                            string Alumno = reader["Alumno"].ToString().Trim();
                            int Materia = int.Parse(reader["Materia"].ToString().Trim());
                            int Activdad = int.Parse(reader["Actividad"].ToString().Trim());
                            int Grado = int.Parse(reader["Grado"].ToString().Trim());
                            int Seccion = int.Parse(reader["Seccion"].ToString().Trim());
                            int Trimestre = int.Parse(reader["Trimestre"].ToString().Trim());
                            int Periodo = int.Parse(reader["Periodo"].ToString().Trim());
                            double Calificacion = double.Parse(reader["Calificacion"].ToString().Trim());

                            SqlCommand command = new SqlCommand("IngresarRegistro", conRepositorio);
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@Alumno", Alumno);
                            command.Parameters.AddWithValue("@Materia", Materia);
                            command.Parameters.AddWithValue("@Actividad", Activdad);
                            command.Parameters.AddWithValue("Grado", Grado);
                            command.Parameters.AddWithValue("@Seccion", Seccion);
                            command.Parameters.AddWithValue("@Trimestre", Trimestre);
                            command.Parameters.AddWithValue("@Periodo", Periodo);
                            command.Parameters.AddWithValue("@Calificacion", Calificacion);
                            command.Parameters.AddWithValue("@ano", IdAño);
                            command.ExecuteNonQuery();

                            conRepositorio.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error enviando registro" + ex);
                            conRepositorio.Close();
                        }


                    }

                }
                conOrignal.Close();
            }
            catch
            {

                MessageBox.Show("Error transpotando porcentaje", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conOrignal.Close();

            }

        }

        internal List<PropiedadMaestro> GetProfesores()
        {
            List<PropiedadMaestro> Profesores = new List<PropiedadMaestro>();
            PropiedadMaestro p;
            try
            {
                conOrignal.Open();
                cmm = new SqlCommand("SELECT * FROM Maestros", conOrignal);
                reader = cmm.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        p = new PropiedadMaestro();
                        p.IdMaestro = reader["IdMaestro"].ToString().Trim(); ;
                        p.Nombre = reader["Nombre"].ToString().Trim();
                        p.Fecha = reader["Fecha"].ToString().Trim();
                        p.Telefono = reader["Telefono"].ToString().Trim();
                        p.Direccion = reader["Direccion"].ToString().Trim();
                        p.Tutor = int.Parse(reader["Tutor"].ToString().Trim());

                        if (p.Tutor == 1)
                        {
                            p.Grado = int.Parse(reader["Grado_t"].ToString().Trim());
                            p.Seccion = int.Parse(reader["Seccion_t"].ToString().Trim());
                        }
                        else
                        {
                            p.Grado = 1;
                            p.Seccion = 1;
                        }
                        p.Estado = int.Parse(reader["Estado"].ToString().Trim());

                        Profesores.Add(p);
                    }



                }


                conOrignal.Close();

                return Profesores;
            }
            catch (Exception ex)
            {
                conOrignal.Close();
                MessageBox.Show("Error\n\n" + ex.ToString());
                return null;
            }
        }

        internal List<PropiedadAlumno> GetAlumnos()
        {

            List<PropiedadAlumno> Alumnos = new List<PropiedadAlumno>();
            PropiedadAlumno a;
            try
            {
                conOrignal.Open();
                cmm = new SqlCommand("SELECT * FROM ALUMNO", conOrignal);
                reader = cmm.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        a = new PropiedadAlumno();
                        a.Nie = reader["NIE"].ToString().Trim();
                        a.Nombre = reader["Nombre"].ToString().Trim();
                        a.Fechanac = reader["Fecha_nac"].ToString().Trim();
                        a.Telefono = reader["Telefono"].ToString().Trim();
                        a.Direccion = reader["Direccion"].ToString().Trim();
                        a.Responsable = reader["Responsable"].ToString().Trim();
                        a.Grado = int.Parse(reader["Grado"].ToString().Trim());
                        a.Seccion = int.Parse(reader["Seccion"].ToString().Trim());
                        a.Estado = int.Parse(reader["Estado"].ToString().Trim());
                        Alumnos.Add(a);
                    }
                }


                conOrignal.Close();

                return Alumnos;
            }
            catch
            {

                return null;
            }
        }

        internal void VaciaOriginal()
        {
            try
            {
                cmm = new SqlCommand("DeleteDatos", conOrignal);
                cmm.CommandType = CommandType.StoredProcedure;
                conOrignal.Open();
                cmm.ExecuteNonQuery();
                conOrignal.Close();
                MessageBox.Show("datos eliminados con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch
            {

                MessageBox.Show("Error borrando datos en la original", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conOrignal.Close();

            }


        }








    }
}
