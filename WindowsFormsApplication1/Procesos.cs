 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Data;
using Microsoft;
namespace WindowsFormsApplication1
{
    class Procesos
    {
        //private SqlConnection getconexion;
        private SqlCommand scomand;
        private SqlDataReader sreader;
        private int periodo;
        private int trimestre;
        private decimal porcen;
        public string acti;
        public decimal ponde=0.0m;
        public int ids, idg;

        public int Preferencia(string usu)
        {
            int tipo=0;
            string consulta = "Preferencia";
            SqlConnection get = Conexion.Cnn();
            scomand = new SqlCommand(consulta, get);
            scomand.Parameters.AddWithValue("@Usuario", usu);
            scomand.CommandType = CommandType.StoredProcedure;
            scomand.ExecuteNonQuery();
            sreader = scomand.ExecuteReader();
            if(sreader.Read())
            {
                tipo = int.Parse(sreader["Tipo"].ToString());
            }
            get.Close();
            return tipo;
            
        }

        public void materiacusto1(string nombre, ComboBox cbg, ComboBox cbm)
        {
            string consulta;
            consulta = "CustoMate1";
            SqlConnection getconexion = Conexion.Cnn();
            scomand = new SqlCommand(consulta, getconexion);
            scomand.Parameters.AddWithValue("@Nombre", nombre);
            scomand.Parameters.AddWithValue("@Grado", cbg.Text.ToString());
            scomand.CommandType = CommandType.StoredProcedure;
            scomand.ExecuteNonQuery();
            sreader = scomand.ExecuteReader();
            while (sreader.Read())
            {
                cbm.Items.Add(sreader["Materia"].ToString());
            }
            getconexion.Close();
        }

        public void Seccioncusto(ComboBox cbllenar, ComboBox cbref, string usu)
        {
            string consulta = "secc";
            SqlConnection getconexion = Conexion.Cnn();
            scomand = new SqlCommand(consulta, getconexion);
            scomand.Parameters.AddWithValue("@Maestro", usu);
            scomand.Parameters.AddWithValue("@Grado", cbref.Text);
            scomand.CommandType = CommandType.StoredProcedure;
            scomand.ExecuteNonQuery();
            sreader = scomand.ExecuteReader();
            while (sreader.Read())
            {
                cbllenar.Items.Add(sreader["Seccion"].ToString());
            }
            getconexion.Close();
        }

        public void gradocusto(string nombre, ComboBox cbg)
        {
            string consulta;
            consulta = "FillCusto";
            SqlConnection getconexion = Conexion.Cnn();
            scomand = new SqlCommand(consulta, getconexion);
            scomand.Parameters.AddWithValue("@Nombre", nombre);
            scomand.CommandType = CommandType.StoredProcedure;
            scomand.ExecuteNonQuery();
            sreader = scomand.ExecuteReader();
            while (sreader.Read())
            {
                cbg.Items.Add(sreader["Grado"].ToString());
            }
            getconexion.Close();
        }
        public void materiacusto(string nombre, ComboBox cbg, ComboBox cbs, ComboBox cbm)
        {
            string consulta;
            consulta = "CustoMate";
            SqlConnection getconexion = Conexion.Cnn();
            scomand = new SqlCommand(consulta, getconexion);
            scomand.Parameters.AddWithValue("@Nombre", nombre);
            scomand.Parameters.AddWithValue("@Grado", cbg.Text.ToString());
            scomand.Parameters.AddWithValue("@Seccion", cbs.Text.ToString());
            scomand.CommandType = CommandType.StoredProcedure;
            scomand.ExecuteNonQuery();
            sreader = scomand.ExecuteReader();
            while(sreader.Read())
            {
                cbm.Items.Add(sreader["Materia"].ToString());
            }
            getconexion.Close();
        }
        public void nombreusu(string usu,Label l)
        {
            string nom;
            int c = 0;
            nom = "Nombreusu";
            SqlConnection getconexion = Conexion.Cnn();
            scomand = new SqlCommand(nom, getconexion);
            scomand.Parameters.AddWithValue("@id", usu);
            scomand.CommandType = CommandType.StoredProcedure;
            scomand.ExecuteNonQuery();
            sreader = scomand.ExecuteReader();
            if(sreader.Read())
            {
               
                l.Text = sreader["Nombre"].ToString();
                c++;
            }
            getconexion.Close();
          if(c==0)
          {
              string nom1;
              nom1 = "Nombreusu1";
              SqlConnection getconexion1 = Conexion.Cnn();
              scomand = new SqlCommand(nom1, getconexion1);
              scomand.Parameters.AddWithValue("@id", usu);
              scomand.CommandType = CommandType.StoredProcedure;
              scomand.ExecuteNonQuery();
              sreader = scomand.ExecuteReader();
              if (sreader.Read())
              {

                  l.Text = sreader["Nombre"].ToString();
              }
              getconexion1.Close();
          }
        }

        //public void nombreusu1(string usu, Label l)
        //{
          

        //}


        public string Nombrereportfinal(string usu)
        {
            string nom;
            nom = "Nombreusu";
            SqlConnection getconexion = Conexion.Cnn();
            scomand = new SqlCommand(nom, getconexion);
            scomand.Parameters.AddWithValue("@id", usu);
            scomand.CommandType = CommandType.StoredProcedure;
            scomand.ExecuteNonQuery();
            sreader = scomand.ExecuteReader();
            if (sreader.Read())
            {
              nom= sreader["Nombre"].ToString();
              return nom;
            }
            return "";
        }
        public int idseccion(string s)
        {

            SqlConnection getconexion = Conexion.Cnn();

            string a = "";
            string spinsertar = "idsec";
            scomand = new SqlCommand(spinsertar, getconexion);

            scomand.Parameters.AddWithValue("@Seccion", s);
            scomand.CommandType = CommandType.StoredProcedure;
            scomand.ExecuteNonQuery();
            sreader = scomand.ExecuteReader();
            while (sreader.Read())
            {
                a = sreader["IdSeccion"].ToString();
            }
            getconexion.Close();
            ids = int.Parse(a);
            return ids;
        }
        public int idgrado(ComboBox cbg)
        {
            string a = "";
            SqlConnection getconexion = Conexion.Cnn();


            string spinsertar = "idgrad";
            scomand = new SqlCommand(spinsertar, getconexion);
            scomand.Parameters.AddWithValue("@Grado", cbg.Text.ToString());

            scomand.CommandType = CommandType.StoredProcedure;
            scomand.ExecuteNonQuery();
            sreader = scomand.ExecuteReader();
            if (sreader.Read())
            {
                a = sreader["IdGrado"].ToString();
            }
            getconexion.Close();
            idg = int.Parse(a);
            return idg;
        }
        public void LlenarGrados(ComboBox cb)
        {
            int co = 0;
            try
            {
            SqlConnection getconexion = Conexion.Cnn();
            string CcbGrado = "Select Grado from GRADO";
            scomand = new SqlCommand(CcbGrado, getconexion);

            sreader = scomand.ExecuteReader();
            while (sreader.Read())
            {
                if (co != 0) 
                {
                    cb.Items.Add(sreader["Grado"].ToString());
                }
                co++;
            }
            getconexion.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Error", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }//LlenarGrados

        public void LlenarSeccion(ComboBox cbllenar,ComboBox cbref)
        {
            try
            {
                   SqlConnection getconexion = Conexion.Cnn();
            string CcbSeccion = "GradoSeccion";
            scomand = new SqlCommand(CcbSeccion, getconexion);
            scomand.Parameters.AddWithValue("@Grado", cbref.Text);
            scomand.CommandType = CommandType.StoredProcedure;
            scomand.ExecuteNonQuery();
            sreader = scomand.ExecuteReader();
            while (sreader.Read())
            {
                cbllenar.Items.Add(sreader["Seccion"].ToString());

            }
            getconexion.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Error", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }//LlenarSeccion

        public void LlenarMaterias(ComboBox cbllenar, ComboBox cbref)
        {
            try
            {
                SqlConnection getconexion = Conexion.Cnn();
                string consulta = "GradoMaterias";
                scomand = new SqlCommand(consulta, getconexion);
                scomand.Parameters.AddWithValue("@Grado", cbref.Text);
                scomand.CommandType = CommandType.StoredProcedure;
                scomand.ExecuteNonQuery();
                sreader = scomand.ExecuteReader();
                while (sreader.Read())
                {
                    cbllenar.Items.Add(sreader["Materia"].ToString());
                }
                getconexion.Close();

            }
            catch (Exception)
            {

                MessageBox.Show("Error");
            }
            
        }//LlenarMaterias

        public void LlenarAlumnos(ComboBox cbGrado,ComboBox cbSeccion, DataGridView dgv)
        {
            try
            {
                List<string> ALumnosorden = new List<string>();
                SqlConnection getconexion = Conexion.Cnn();
                int i = 0;
                string getAlumnos;
                getAlumnos = "ALUMNOSPORSECCION";
                scomand = new SqlCommand(getAlumnos, getconexion);
                scomand.Parameters.AddWithValue("@Grado", cbGrado.Text);
                scomand.Parameters.AddWithValue("@Seccion", cbSeccion.Text);
                scomand.CommandType = CommandType.StoredProcedure;
                scomand.ExecuteNonQuery();
                sreader = scomand.ExecuteReader();

                while (sreader.Read())
                {
                    dgv.Rows.Add();
                    ALumnosorden.Add(sreader["Nombre"].ToString());                                    
                    dgv[0, i].Value = (i + 1).ToString();
                    i++;
                }
                ALumnosorden.Sort();
                for (int j = 0; j < i; j++)
                {
                  dgv[1, j].Value = ALumnosorden[j];
                }
                
                getconexion.Close();
                ALumnosorden.Clear();
            }
            catch (Exception)
            {

                MessageBox.Show("Error", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }//LenarAlumnos

        public int Trimestre(RadioButton r1, RadioButton r2, RadioButton r3)
        {

            if (r1.Checked)
                trimestre= 1;
            else if (r2.Checked)
                trimestre = 2;
            else
            {
                trimestre = 3;
            }
            return trimestre;
        }


        public int Periodo(RadioButton r1, RadioButton r2, RadioButton r3)
        {
            
            if (r1.Checked)
                periodo = 1;
            else if (r2.Checked)
                periodo = 2;
            else
            {
                periodo = 3;
            }
            return periodo;
        }

        public void LlenarActividades(ComboBox cbs,ComboBox cbGrado, ComboBox cbMateria, DataGridView dgv
            ,RadioButton r1, RadioButton r2, RadioButton r3,RadioButton r11,
            RadioButton r22, RadioButton r33)
        {
            try
            {
                Procesos p = new Procesos();
                SqlConnection getconexion = Conexion.Cnn();
                string getActividades;
                getActividades = "GetActividades";
                scomand = new SqlCommand(getActividades, getconexion);
                scomand.Parameters.AddWithValue("@Grado", cbGrado.Text);
                scomand.Parameters.AddWithValue("@Materia", cbMateria.Text);
                scomand.Parameters.AddWithValue("@Trimestre", p.Trimestre(r11,r22,r33));
                scomand.Parameters.AddWithValue("@Periodo", p.Periodo(r1, r2, r3));
                scomand.Parameters.AddWithValue("@Seccion", cbs.Text);
                scomand.CommandType = CommandType.StoredProcedure;
                scomand.ExecuteNonQuery();
                sreader = scomand.ExecuteReader();

                while (sreader.Read())
                {
                    dgv.Columns.Add(sreader["Actividad"].ToString(), sreader["Actividad"].ToString());
                }
                getconexion.Close();

            }
            catch (Exception)
            {

                MessageBox.Show("Error", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }//LlenarActividades

        public void LlenarCalificaciones(ComboBox ma, ComboBox gr, ComboBox sec, DataGridView dgv,
            RadioButton r1, RadioButton r2, RadioButton r3, RadioButton r11, RadioButton r22, RadioButton r33)
        {
            
            try
            {
                  int alumnos = 0, actividades = 0, notas = 0;
            alumnos = dgv.RowCount;
            actividades = dgv.ColumnCount - 3;
            notas = alumnos * actividades;
            Procesos p = new Procesos();

            for (int i = 0; i < alumnos; i++)
            {
                for (int j = 2; j < actividades + 3; j++)
                {
                    SqlConnection getconexion = Conexion.Cnn();
                    string getNotas;
                    getNotas = "NOTASPORGRADOSECCION";
                    scomand = new SqlCommand(getNotas, getconexion);
                    scomand.Parameters.AddWithValue("@Materia", ma.Text.ToString());
                    scomand.Parameters.AddWithValue("@Grado", gr.Text.ToString());
                    scomand.Parameters.AddWithValue("@Seccion", sec.Text.ToString());
                    scomand.Parameters.AddWithValue("@Alumno", dgv[1, i].Value.ToString());
                    scomand.Parameters.AddWithValue("@Actividad", dgv.Columns[j].Name.ToString());
                    scomand.Parameters.AddWithValue("@Trimestre", p.Trimestre(r11, r22, r33));
                    scomand.Parameters.AddWithValue("@Periodo",p.Periodo(r1,r2,r3));
                    scomand.CommandType = CommandType.StoredProcedure;
                    scomand.ExecuteNonQuery();
                    sreader = scomand.ExecuteReader();

                    if (sreader.Read())
                    {
                        dgv[j, i].Value = sreader["Calificacion"].ToString();

                    }
                    getconexion.Close();

                }
            }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error calificaion" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }//LlenarCalificaciones

        public void LlenarPorcentajes(ComboBox ma,DataGridView dgv,
            RadioButton r1, RadioButton r2, RadioButton r3, RadioButton r11, RadioButton r22
            ,RadioButton r33)
        {
            try
            {
                int alumnos = dgv.RowCount;
                int columnas = dgv.ColumnCount;

                Procesos p = new Procesos();

                for (int i = 0; i < alumnos; i++)
                {
                    SqlConnection getconexion = Conexion.Cnn();
                    string fillpor;
                    fillpor = "getPorcentajes";
                    scomand = new SqlCommand(fillpor, getconexion);
                    scomand.Parameters.AddWithValue("@Alumno", dgv[1, i].Value.ToString());
                    scomand.Parameters.AddWithValue("@Materia", ma.Text.ToString());
                    scomand.Parameters.AddWithValue("@Trimestre", p.Trimestre(r11, r22, r33));
                    scomand.Parameters.AddWithValue("@Periodo", p.Periodo(r1, r2, r3));
                    scomand.CommandType = CommandType.StoredProcedure;
                    scomand.ExecuteNonQuery();
                    sreader = scomand.ExecuteReader();
                    if (sreader.Read())
                    {
                        dgv[columnas - 1, i].Value = sreader["Porcentaje"].ToString();
                    }
                    getconexion.Close();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error porcentaje" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }//LlenarPorcentajes

        public void Limpiarcb(ComboBox cb)
        {
            cb.Items.Clear();
            cb.Text = "";

        }
        public void Vaciardgv(DataGridView dgv)
        {
            dgv.Rows.Clear();
            dgv.Columns.Clear();
        }

        public bool ListoCarga(ComboBox cb1, ComboBox cb2, ComboBox cb3, RadioButton r1, RadioButton r2, RadioButton r3,
            RadioButton r11, RadioButton r22, RadioButton r33)
        {
            if (cb1.Text != "" && cb2.Text != "" && cb3.Text != "" && (r1.Checked || r2.Checked || r3.Checked)
                && (r11.Checked || r22.Checked || r33.Checked))
                return true;
            else
                return false;
        }

        public void exportarexcel(DataGridView tabla)
        {
            try
            {
                Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Application.Workbooks.Add(true);
                int indiceColumna = 0;
                foreach (DataGridViewColumn col in tabla.Columns)
                {
                    indiceColumna++;
                    excel.Cells[1, indiceColumna] = col.Name;
                }
                int indiceFila = 0;

                foreach (DataGridViewRow row in tabla.Rows)
                {
                    indiceFila++;
                    indiceColumna = 0;
                    foreach (DataGridViewColumn col in tabla.Columns)
                    {
                        indiceColumna++;
                        excel.Cells[indiceFila + 1, indiceColumna] = row.Cells[col.Name].Value;
                    }

                }
                excel.Visible = true;

            }
            catch (Exception)
            {

                MessageBox.Show("Error al exportar el registro", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
     
        public decimal Periodoporcentaje(RadioButton r1, RadioButton r2, RadioButton r3)
        {
            Procesos p = new Procesos();
            decimal porcen = 0m;
            try
            {
                if (p.Periodo(r1, r2, r3) == 1)
                {
                    porcen = 3.5m;
                }
                if (p.Periodo(r1, r2, r3) == 2)
                {
                    porcen = 3.5m;
                }
                if (p.Periodo(r1, r2, r3) == 3)
                {
                    porcen = 3.0m;
                }
                return porcen;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
                return 0;
            }
        }            

        public void InAct(ComboBox cbSeccion,TextBox txtact, ComboBox cbm, ComboBox cbg,
            RadioButton r1, RadioButton r2, RadioButton r3,TextBox txtp,DataGridView dgv,
            RadioButton r11, RadioButton r22, RadioButton r33)
        {
            try
            {
                Procesos p = new Procesos();
                SqlConnection getconexion = Conexion.Cnn();
                int cont = dgv.RowCount;
                string ingresaract;
                ingresaract = "IngresarActividades";
                scomand = new SqlCommand(ingresaract, getconexion);
                scomand.Parameters.AddWithValue("@Actividad", txtact.Text.ToString());
                scomand.Parameters.AddWithValue("@Materia", cbm.Text.ToString());
                scomand.Parameters.AddWithValue("@Grado", cbg.Text.ToString());
                scomand.Parameters.AddWithValue("@Trimestre", p.Trimestre(r11, r22, r33));
                scomand.Parameters.AddWithValue("@Periodo", p.Periodo(r1, r2, r3));
                scomand.Parameters.AddWithValue("@Ponderacion", Convert.ToDecimal(txtp.Text.ToString()));
                scomand.Parameters.AddWithValue("@Seccion", cbSeccion.Text);
                scomand.CommandType = CommandType.StoredProcedure;
                scomand.ExecuteNonQuery();
                getconexion.Close();
                dgv.Rows.Add();
                dgv[0, cont ].Value = txtact.Text.ToString();
                dgv[1, cont ].Value = txtp.Text.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al ingresar los datos " + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

        public void UpdateActividad(ComboBox cbSeccion,DataGridView dgv,ComboBox ma,ComboBox gr,
            RadioButton r1, RadioButton r2, RadioButton r3,
            RadioButton r11, RadioButton r22, RadioButton r33)
        {
            try
            {
                            List<string> Alumnos = new List<string>();
            List<decimal> calificacion = new List<decimal>();
            List<decimal> PorcentajeMateria = new List<decimal>();
            decimal ponderacionact=0;
            bool flag = false;
            int y = dgv.CurrentCellAddress.Y;
            Procesos p = new Procesos();
            SqlConnection getconexion0 = Conexion.Cnn();
            string step1;
            step1 = "UpdatePorstep1";
            scomand = new SqlCommand(step1, getconexion0);
            scomand.Parameters.AddWithValue("@Materia",ma.Text.ToString());
            scomand.Parameters.AddWithValue("@Actividad", dgv[0, y].Value.ToString());
            scomand.Parameters.AddWithValue("@Grado",gr.Text.ToString());
            scomand.Parameters.AddWithValue("@Trimestre",p.Trimestre(r11,r22,r33));
            scomand.Parameters.AddWithValue("@Periodo",p.Periodo(r1,r2,r3));
            scomand.Parameters.AddWithValue("@Seccion", cbSeccion.Text);
            scomand.CommandType = CommandType.StoredProcedure;
            scomand.ExecuteNonQuery();
            sreader = scomand.ExecuteReader();
            while(sreader.Read())
            {
                Alumnos.Add(sreader["Nombre"].ToString());
                calificacion.Add(decimal.Parse(sreader["Calificacion"].ToString()));
                flag = true;
            }
            getconexion0.Close();
            if (flag)
            {
                ponderacionact = decimal.Parse(dgv[1, y].Value.ToString());


                for (int i = 0; i < Alumnos.Count; i++)
                {
                    SqlConnection getconexion1 = Conexion.Cnn();
                    string fillpor;
                    fillpor = "getPorcentajes";
                    scomand = new SqlCommand(fillpor, getconexion1);
                    scomand.Parameters.AddWithValue("@Alumno", Alumnos[i].ToString());
                    scomand.Parameters.AddWithValue("@Materia", ma.Text.ToString());
                    scomand.Parameters.AddWithValue("@Trimestre", p.Trimestre(r11, r22, r33));
                    scomand.Parameters.AddWithValue("@Periodo", p.Periodo(r1, r2, r3));
                    scomand.CommandType = CommandType.StoredProcedure;
                    scomand.ExecuteNonQuery();
                    sreader = scomand.ExecuteReader();
                    if (sreader.Read())
                    {
                        PorcentajeMateria.Add(decimal.Parse(sreader["Porcentaje"].ToString()));
                    }
                    getconexion1.Close();
                }

                    for (int i = 0; i < Alumnos.Count; i++)
                    {
                        SqlConnection getconexion2 = Conexion.Cnn();
                        string updatePorcentaje = "UpdatePorcentaje";
                        scomand = new SqlCommand(updatePorcentaje, getconexion2);
                        scomand.Parameters.AddWithValue("@Alumno", Alumnos[i].ToString());
                        scomand.Parameters.AddWithValue("@Materia", ma.Text.ToString());
                        scomand.Parameters.AddWithValue("@NPorcentaje", PorcentajeMateria[i] - (calificacion[i] * ponderacionact) / 10);
                        scomand.Parameters.AddWithValue("@Trimestre", p.Trimestre(r11, r22, r33));
                        scomand.Parameters.AddWithValue("@Periodo", p.Periodo(r1, r2, r3));
                        scomand.CommandType = CommandType.StoredProcedure;
                        scomand.ExecuteNonQuery();
                        sreader = scomand.ExecuteReader();
                        getconexion2.Close();

                    }

          
            }
            Alumnos.Clear();
            PorcentajeMateria.Clear();
            calificacion.Clear();
            }
            catch (Exception)
            {
                
                throw;
            }
        }

             public void DeleteActividad(ComboBox cbSeccion,DataGridView dgv,ComboBox ma,ComboBox gr,
            RadioButton r1, RadioButton r2, RadioButton r3,
            RadioButton r11, RadioButton r22, RadioButton r33)          
           {
             try
                {
            Procesos p = new Procesos();
            SqlConnection getconexion3 = Conexion.Cnn();
            int y = dgv.CurrentCellAddress.Y;
            string deletea;
            deletea = "DeleteAct";
            scomand = new SqlCommand(deletea, getconexion3);
            scomand.Parameters.AddWithValue("@Actividad", dgv[0, y].Value.ToString());
            scomand.Parameters.AddWithValue("@Materia", ma.Text.ToString());
            scomand.Parameters.AddWithValue("@Grado", gr.Text.ToString());
            scomand.Parameters.AddWithValue("@Trimestre", p.Trimestre(r11, r22, r33));
            scomand.Parameters.AddWithValue("@Periodo", p.Periodo(r1, r2, r3));
            scomand.Parameters.AddWithValue("@Seccion", cbSeccion.Text);
            scomand.CommandType = CommandType.StoredProcedure;
            scomand.ExecuteNonQuery();
            getconexion3.Close();

        }
        catch (Exception)
        {
            
            throw;
        }

        }//Delete Actividades

        public void CuadroNotas(DataGridView dgvRegistro,ComboBox cbGrado,ComboBox cbMateria, ComboBox cbSeccion,
            RadioButton rbt1,RadioButton rbt2, RadioButton rbt3, RadioButton rbp35,
            RadioButton rbs35, RadioButton rb30)
             {
                 Procesos p = new Procesos();

                     if (Convert.ToString(dgvRegistro.CurrentCell.Value) == "")
                     {
                         dgvRegistro.CurrentCell.Value = 0;
                     }

                     if (decimal.Parse(dgvRegistro.CurrentCell.Value.ToString()) < 0 || decimal.Parse(dgvRegistro.CurrentCell.Value.ToString()) > 10)
                     {
                         MessageBox.Show("Nota inválida", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                         dgvRegistro.CurrentCell.Value = 0;
                     }

                     int x, y, columnas;
                     bool flag = false;
                     x = dgvRegistro.CurrentCellAddress.X;
                     y = dgvRegistro.CurrentCellAddress.Y;
                     columnas = dgvRegistro.ColumnCount - 1;



                     SqlConnection getconexion = Conexion.Cnn();
                     string updatenotas;
                     updatenotas = "UpdateNotas";
                     scomand = new SqlCommand(updatenotas, getconexion);
                     scomand.Parameters.AddWithValue("@Materia", cbMateria.Text.ToString());
                     scomand.Parameters.AddWithValue("@Grado", cbGrado.Text.ToString());
                     scomand.Parameters.AddWithValue("@Seccion", cbSeccion.Text.ToString());
                     scomand.Parameters.AddWithValue("@Alumno", dgvRegistro[1, y].Value.ToString());
                     scomand.Parameters.AddWithValue("@Actividad", dgvRegistro.Columns[x].Name.ToString());
                     scomand.Parameters.AddWithValue("@Trimestre", p.Trimestre(rbt1, rbt2, rbt3));
                     scomand.Parameters.AddWithValue("@Periodo", p.Periodo(rbp35, rbs35, rb30));
                     scomand.Parameters.AddWithValue("@NCalificaion", decimal.Parse(dgvRegistro.CurrentCell.Value.ToString()));
                     scomand.CommandType = CommandType.StoredProcedure;
                     scomand.ExecuteNonQuery();
                     sreader = scomand.ExecuteReader();

                     if (sreader.Read())
                     {
                         flag = true;
                     }
                     getconexion.Close();
                     if (flag.Equals(false))
                     {

                         string InsertRegistro;
                         InsertRegistro = "IngresarRegistro";
                         scomand = new SqlCommand(InsertRegistro, getconexion);
                         getconexion.Open();
                         scomand.Parameters.AddWithValue("@Alumno", dgvRegistro[1, y].Value.ToString());
                         scomand.Parameters.AddWithValue("@Materia", cbMateria.Text.ToString());
                         scomand.Parameters.AddWithValue("@Actividad", dgvRegistro.Columns[x].Name.ToString());
                         scomand.Parameters.AddWithValue("@Grado", cbGrado.Text.ToString());
                         scomand.Parameters.AddWithValue("@Seccion", cbSeccion.Text.ToString());
                         scomand.Parameters.AddWithValue("@Trimestre", p.Trimestre(rbt1, rbt2, rbt3));
                         scomand.Parameters.AddWithValue("@Periodo", p.Periodo(rbp35, rbs35, rb30));
                         scomand.Parameters.AddWithValue("@Calificacion", decimal.Parse(dgvRegistro.CurrentCell.Value.ToString()));
                         scomand.CommandType = CommandType.StoredProcedure;
                         scomand.ExecuteNonQuery();

                     }
                     getconexion.Close();


                     //PORCENTAJE
                     decimal total = 0;
                     double t = 0;
                     string porcentaje;
                     List<decimal> porcentajes = new List<decimal>();
                     porcentaje = "getPonderacion";//valor de la nota en el 35%
                     scomand = new SqlCommand(porcentaje, getconexion);
                     getconexion.Open();
                     scomand.Parameters.AddWithValue("@Grado", cbGrado.Text.ToString());
                     scomand.Parameters.AddWithValue("@Materia", cbMateria.Text.ToString());
                     scomand.Parameters.AddWithValue("@Trimestre", p.Trimestre(rbt1, rbt2, rbt3));
                     scomand.Parameters.AddWithValue("@Periodo", p.Periodo(rbp35, rbs35, rb30));
                     scomand.Parameters.AddWithValue("@Seccion", cbSeccion.Text);
                     scomand.CommandType = CommandType.StoredProcedure;
                     scomand.ExecuteNonQuery();
                     sreader = scomand.ExecuteReader();
                     while (sreader.Read())
                     {
                         porcentajes.Add(decimal.Parse(sreader["Ponderacion"].ToString()));
                     }
                     getconexion.Close();


                     for (int po = 2; po < dgvRegistro.ColumnCount - 1; po++)
                     {

                         if (Convert.ToString(dgvRegistro[po, y].Value) != "")
                         {
                             total = total + decimal.Parse(dgvRegistro[po, y].Value.ToString()) * (porcentajes[po - 2]) / 10;
                         }

                     }
                     porcentajes.Clear();
                     string updatePorcentaje;
                     bool flag1 = false;
                     updatePorcentaje = "UpdatePorcentaje";
                     scomand = new SqlCommand(updatePorcentaje, getconexion);
                     getconexion.Open();
                     scomand.Parameters.AddWithValue("@Alumno", dgvRegistro[1, y].Value.ToString());
                     scomand.Parameters.AddWithValue("@Materia", cbMateria.Text.ToString());
                     scomand.Parameters.AddWithValue("@NPorcentaje", total);
                     scomand.Parameters.AddWithValue("@Trimestre", p.Trimestre(rbt1, rbt2, rbt3));
                     scomand.Parameters.AddWithValue("@Periodo", p.Periodo(rbp35, rbs35, rb30));
                     scomand.CommandType = CommandType.StoredProcedure;
                     scomand.ExecuteNonQuery();
                     sreader = scomand.ExecuteReader();
                     if (sreader.Read())
                     {
                         flag1 = true;
                     }
                     getconexion.Close();
                     if (flag1.Equals(false))
                     {
                         string insertarporcen;
                         insertarporcen = "IngresarPorcentaje";
                         scomand = new SqlCommand(insertarporcen, getconexion);
                         getconexion.Open();
                         scomand.Parameters.AddWithValue("@Alumno", dgvRegistro[1, y].Value.ToString());
                         scomand.Parameters.AddWithValue("@Materia", cbMateria.Text.ToString());
                         scomand.Parameters.AddWithValue("@Trimestre", p.Trimestre(rbt1, rbt2, rbt3));
                         scomand.Parameters.AddWithValue("@Periodo", p.Periodo(rbp35, rbs35, rb30));
                         scomand.Parameters.AddWithValue("@Porcentaje", total);
                         scomand.CommandType = CommandType.StoredProcedure;
                         scomand.ExecuteNonQuery();
                         getconexion.Close();
                     }
                     t = (double)total;
                     t = Math.Round(t, 2);
                     dgvRegistro[columnas, y].Value = t.ToString();


            }//Cuadro de notas





       public void CrearCuadrofinal(DataGridView dgv)
        {
            dgv.Columns.Clear();
            dgv.Rows.Clear();
            dgv.Columns.Add("No", "No");
            dgv.Columns.Add("Alumnos", "NOMBRE DEL ALUMNO/A");
            dgv.Columns.Add("T1P35","ACT."+"\n35%");
            dgv.Columns.Add("T1S35","ACT."+"\n35%");
            dgv.Columns.Add("T1P30","EXA."+"\n30%");
            dgv.Columns.Add("PROM1","PROM");
            dgv.Columns.Add("T2P35","ACT."+"\n35%");
            dgv.Columns.Add("T2S35","ACT." + "\n35%");
            dgv.Columns.Add("T2P30","EXA." + "\n30%");
            dgv.Columns.Add("PROM2","PROM");
            dgv.Columns.Add("T3P35","ACT." + "\n35%");
            dgv.Columns.Add("T3S35","ACT."+"\n35%");
            dgv.Columns.Add("T3P30","EXA." + "\n30%");
            dgv.Columns.Add("PROM3","PROM");
            dgv.Columns.Add("PROMF", "PROM."+"\nFINAL");
        }

        public void LlenarcuadroFinal(DataGridView dgv, ComboBox cbm)
       {
           try
           {
               int trimestre = 0;
               int periodo = 0;
               decimal promedio = 0;
               for (int i = 0; i < dgv.Rows.Count; i++)
               {
                   for (int j = 2; j < 15; j++)
                   {

                       if (j >= 2 && j <= 4 || j >= 6 && j <= 8 || j >= 10 && j <= 12)
                       {
                           if (j >= 2 && j <= 4)
                               trimestre = 1;
                           else if (j >= 6 && j <= 8)
                               trimestre = 2;
                           else if (j >= 10 && j <= 12)
                               trimestre = 3;
                           else
                           {
                               trimestre = 0;
                           }
                           if (j == 2 || j == 6 || j == 10)
                               periodo = 1;
                           else if (j == 3 || j == 7 || j == 11)
                               periodo = 2;
                           else if (j == 4 || j == 8 || j == 12)
                               periodo = 3;
                           else
                           {
                               periodo = 0;
                           }

                           SqlConnection getconexion = Conexion.Cnn();
                           string llenarporcentajes;
                           llenarporcentajes = "fillCuadrofinal";
                           scomand = new SqlCommand(llenarporcentajes, getconexion);
                           scomand.Parameters.AddWithValue("@Alumno", dgv[1, i].Value.ToString());
                           scomand.Parameters.AddWithValue("@Materia", cbm.Text.ToString());
                           scomand.Parameters.AddWithValue("@Trimestre", trimestre);
                           scomand.Parameters.AddWithValue("@Periodo", periodo);
                           scomand.CommandType = CommandType.StoredProcedure;
                           scomand.ExecuteNonQuery();
                           sreader = scomand.ExecuteReader();
                           if (sreader.Read())
                           {
                               dgv[j, i].Value = sreader["Porcentaje"].ToString();
                           }
                           else
                           {
                               dgv[j, i].Value = "0";
                           }
                           getconexion.Close();
                       }//if de porcentajes
                       if (j == 5)
                       {
                           for (int l = 2; l < 5; l++)
                           {
                               if (Convert.ToString(dgv[l, i].Value) != "")
                                   promedio = promedio + decimal.Parse(dgv[l, i].Value.ToString());
                           }
                           dgv[5, i].Value = promedio.ToString();
                           promedio = 0;
                       }
                       if (j == 9)
                       {
                           for (int l = 6; l < 9; l++)
                           {
                               if (Convert.ToString(dgv[l, i].Value) != "")
                                   promedio = promedio + decimal.Parse(dgv[l, i].Value.ToString());
                           }

                           dgv[9, i].Value = promedio.ToString();
                           promedio = 0;
                       }
                       if (j == 13)
                       {
                           for (int l = 10; l < 13; l++)
                           {
                               if (Convert.ToString(dgv[l, i].Value) != "")
                                   promedio = promedio + decimal.Parse(dgv[l, i].Value.ToString());
                           }

                           dgv[13, i].Value = promedio.ToString();
                           promedio = 0;
                       }
                       if (j == 14)
                       {
                           double p = 0;
                           int aux = 5;
                           while (aux < 14)
                           {
                               promedio = promedio + decimal.Parse(dgv[aux, i].Value.ToString());
                               aux = aux + 4;
                           }
                           p = (double)promedio / 3;
                           p = Math.Round(p, 2);
                           dgv[14, i].Value = p.ToString();
                           promedio = 0;
                       }
                   }//for de columnas

               }// for de fikas
               int filas = dgv.RowCount;
               GraficosBarra.Trimestre1 = 0m;
               GraficosBarra.Trimestre2 = 0m;
               GraficosBarra.Trimestre3 = 0m;
               for (int i = 0; i < filas; i++)
               {
                   GraficosBarra.Trimestre1 = +GraficosBarra.Trimestre1 + (decimal.Parse(dgv[5, i].Value.ToString()) / filas);
                   GraficosBarra.Trimestre2 = +GraficosBarra.Trimestre2 + (decimal.Parse(dgv[9, i].Value.ToString()) / filas);
                   GraficosBarra.Trimestre3 = +GraficosBarra.Trimestre3 + (decimal.Parse(dgv[13, i].Value.ToString()) / filas);
               }
               GraficosBarra.Final = (GraficosBarra.Trimestre1 + GraficosBarra.Trimestre2 + GraficosBarra.Trimestre3) / 3;

           }
           catch (Exception)
           {

               MessageBox.Show("Error en los porcentajes", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }
      
       }//llenar cuadro final


        public void getestado(ComboBox cb,TextBox n,TextBox a)
        {
            try
            {
                            string ge;
            ge = "Select Estado from ESTADO";
            SqlConnection get = Conexion.Cnn();
            scomand = new SqlCommand(ge, get);
            scomand.ExecuteNonQuery();
            sreader = scomand.ExecuteReader();
            while(sreader.Read())
            {
                cb.Items.Add(sreader["Estado"].ToString());
            }
            get.Close();
            string select;
            SqlConnection get1 = Conexion.Cnn();
            select = "getestadoA";
            scomand = new SqlCommand(select, get1);
            scomand.Parameters.AddWithValue("@Nombre", a.Text + "," + n.Text);
            scomand.CommandType = CommandType.StoredProcedure;
            scomand.ExecuteNonQuery();
            sreader = scomand.ExecuteReader();
            if(sreader.Read())
            {
                cb.Text = sreader["Estado"].ToString();
            }
            get1.Close();
            }
            catch (Exception)
            {
                
                throw;
            }
        }

    }
}
