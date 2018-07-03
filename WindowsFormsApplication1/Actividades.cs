using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;
namespace WindowsFormsApplication1
{
    
    public partial class Actividades : Form
    {    
        
        private SqlCommand scomand;
        private SqlDataReader sreader;
        private string actividada;
        private string ponderaa;
        Procesos pr = new Procesos();
        Menu m = new Menu();
        


        public Actividades()
        {
            InitializeComponent();
          
            btnCargar.Enabled = false;
            txtActividad.Enabled = false;
            txtPonderacion.Enabled = false;
            btnAgregar.Enabled = false;
            cbMateria.Enabled = false;
            btnBorrar.Enabled = false;       
        }

        private bool Activar(ComboBox gr, ComboBox ma, RadioButton r1, RadioButton r2, RadioButton r3,
            RadioButton r11, RadioButton r22, RadioButton r33)
        {
            if (gr.Text != "" && ma.Text != "" && (r1.Checked || r2.Checked || r3.Checked)
                && (r11.Checked || r22.Checked || r33.Checked))
                return true;
            else
                return false;
        }

        private void LlenarGridview()
        {

            try
            {
                SqlConnection getconexion = Conexion.Cnn();
                string getActividades;
                int i = 0;
                getActividades = "GetActividades";
                scomand = new SqlCommand(getActividades, getconexion);
                scomand.Parameters.AddWithValue("@Grado", cbGrado.Text.ToString());
                scomand.Parameters.AddWithValue("@Materia", cbMateria.Text.ToString());
                scomand.Parameters.AddWithValue("@Trimestre", pr.Trimestre(rbt1, rbt2, rbt3));
                scomand.Parameters.AddWithValue("@Periodo", pr.Periodo(rbp35, rbs35, rb30));
                scomand.Parameters.AddWithValue("@Seccion", cbSeccion.Text);
                scomand.CommandType = CommandType.StoredProcedure;
                scomand.ExecuteNonQuery();
                sreader = scomand.ExecuteReader();
                while (sreader.Read())
                {
                    dgvactividades.Rows.Add();
                    dgvactividades[0, i].Value = sreader["Actividad"].ToString();
                    dgvactividades[1, i].Value = sreader["Ponderacion"].ToString();
                    i++;
                }
                getconexion.Close();

            }
            catch (Exception)
            {
                
                throw;
            }
        }



         private bool validaractividad(TextBox tact)
         {
             try
             {
                 SqlConnection getconexion = Conexion.Cnn();
                 string getActividades;
                 getActividades = "GetActividades";
                 scomand = new SqlCommand(getActividades, getconexion);
                 scomand.Parameters.AddWithValue("@Grado", cbGrado.Text.ToString());
                 scomand.Parameters.AddWithValue("@Materia", cbMateria.Text.ToString());
                 scomand.Parameters.AddWithValue("@Trimestre", pr.Trimestre(rbt1, rbt2, rbt3));
                 scomand.Parameters.AddWithValue("@Periodo", pr.Periodo(rbp35, rbs35, rb30));
                 scomand.Parameters.AddWithValue("@Seccion", cbSeccion.Text);
                 scomand.CommandType = CommandType.StoredProcedure;
                 scomand.ExecuteNonQuery();
                 sreader = scomand.ExecuteReader();
                 while (sreader.Read())
                 {
                     if(sreader["Actividad"].ToString()==tact.Text)
                     {
                         MessageBox.Show("Ya existe una actividad con ese nombre en este periodo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                         return false;
                     }
                 }
                 getconexion.Close();
                 return true;
                

             }
             catch (Exception)
             {

                 throw;
             }
         }
        private decimal Sumatoria()
        {
            decimal total = 0;
            int conteoAct = dgvactividades.RowCount;
            if (conteoAct != 0)
            {
                for (int i = 0; i < conteoAct; i++)
                {
                    total += decimal.Parse(dgvactividades[1, i].Value.ToString());
                }

            }
            return total;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            dgvactividades.Rows.Clear();
            LlenarGridview();
            int contar = dgvactividades.RowCount;
            if (contar == 0)
            {
                MessageBox.Show("No hay actividades planificadas", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lbltotal.Text = "0,0";
            }
            else
            {

                lbltotal.Text = Convert.ToString(Sumatoria());
            }
            txtActividad.Enabled = true;
            txtPonderacion.Enabled = true;
            btnAgregar.Enabled = true;
            btnBorrar.Enabled = true;

        }

        private void cbGrado_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtActividad.Enabled = false;
            txtPonderacion.Enabled = false;
            btnAgregar.Enabled = false;
            cbMateria.Enabled = false;
            btnCargar.Enabled = false;
            pr.Limpiarcb(cbSeccion);
            ///////////
            if (pr.Preferencia(Usuario.usuario) == 1)
            {
                pr.LlenarSeccion(cbSeccion, cbGrado);
            }
            else if (pr.Preferencia(Usuario.usuario) == 2)
            {
                pr.Seccioncusto(cbSeccion, cbGrado, Usuario.usuario);
            }

            ///////////
            
            cbMateria.Enabled = true;
            if (Activar(cbGrado, cbMateria, rbt1, rbt2, rbt3, rbp35, rbs35, rb30))
                btnCargar.Enabled = true;
            else
                btnCargar.Enabled = false;

        }

        private void cbMateria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Activar(cbGrado, cbMateria, rbt1, rbt2, rbt3, rbp35, rbs35, rb30))
                btnCargar.Enabled = true;
            else
                btnCargar.Enabled = false;
        }

        private void rbp1_CheckedChanged(object sender, EventArgs e)
        {
            if (Activar(cbGrado, cbMateria, rbt1, rbt2, rbt3, rbp35, rbs35, rb30))
                btnCargar.Enabled = true;
            else
                btnCargar.Enabled = false;
        }

        private void rbp2_CheckedChanged(object sender, EventArgs e)
        {
            if (Activar(cbGrado, cbMateria, rbt1, rbt2, rbt3, rbp35, rbs35, rb30))
                btnCargar.Enabled = true;
            else
                btnCargar.Enabled = false;
        }

        private void rbp3_CheckedChanged(object sender, EventArgs e)
        {
            if (Activar(cbGrado, cbMateria, rbt1, rbt2, rbt3, rbp35, rbs35, rb30))
                btnCargar.Enabled = true;
            else
                btnCargar.Enabled = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                decimal total1 = 0;
                total1 += Convert.ToDecimal(txtPonderacion.Text) + Sumatoria();
                if (total1 > pr.Periodoporcentaje(rbp35, rbs35, rb30) || decimal.Parse(txtPonderacion.Text.ToString()) <= 0 || !validaractividad(txtActividad)||txtActividad.Text=="")
                {
                    if (total1 > pr.Periodoporcentaje(rbp35, rbs35, rb30))
                        MessageBox.Show("La sumatoria de los porcentajes de las actividades" +
                            "\n exceden el pocentaje del periodo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else if (total1 < 0)
                        MessageBox.Show("Ingrese un porcentaje válido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else if (txtActividad.Text == "") 
                    {

                        MessageBox.Show("Ingrese una actividad", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    pr.InAct(cbSeccion,txtActividad, cbMateria, cbGrado, rbp35, rbs35, rb30, txtPonderacion, dgvactividades,
                    rbt1, rbt2, rbt3);
                    lbltotal.Text = Convert.ToString(total1);
                }
                txtPonderacion.Text = "";
                txtActividad.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show("Ingrese una ponderación válida", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPonderacion.Text = "";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Se borrarán todos los registros de esta actividad", "Eliminar actividad", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            try
            {
                if (r == DialogResult.Yes)
                {
                    pr.UpdateActividad(cbSeccion,dgvactividades, cbMateria, cbGrado, rbp35, rbs35, rb30, rbt1, rbt2, rbt3);
                    pr.DeleteActividad(cbSeccion,dgvactividades, cbMateria, cbGrado, rbp35, rbs35, rb30, rbt1, rbt2, rbt3);
                    dgvactividades.Rows.RemoveAt(dgvactividades.CurrentRow.Index);
                    lbltotal.Text = Sumatoria().ToString();
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Error al eliminar la actividad", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void rbp35_CheckedChanged(object sender, EventArgs e)
        {
            if (Activar(cbGrado, cbMateria, rbt1, rbt2, rbt3, rbp35, rbs35, rb30))
                btnCargar.Enabled = true;
            else
                btnCargar.Enabled = false;
        }

        private void rbs35_CheckedChanged(object sender, EventArgs e)
        {
            if (Activar(cbGrado, cbMateria, rbt1, rbt2, rbt3, rbp35, rbs35, rb30))
                btnCargar.Enabled = true;
            else
                btnCargar.Enabled = false;
        }

        private void rb30_CheckedChanged(object sender, EventArgs e)
        {
            if (Activar(cbGrado, cbMateria, rbt1, rbt2, rbt3, rbp35, rbs35, rb30))
                btnCargar.Enabled = true;
            else
                btnCargar.Enabled = false;
        }

        private void dgvactividades_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int x = dgvactividades.CurrentCellAddress.X;
            int y = dgvactividades.CurrentCellAddress.Y;
            lblnn.Visible = true;
            lblnp.Visible = true;
            txtnn.Visible = true;
            txtnp.Visible = true;
            btnactu.Visible = true;
             actividada = dgvactividades[0, y].Value.ToString();
            ponderaa = dgvactividades[1, y].Value.ToString();
            txtnn.Text = actividada;
            txtnp.Text = ponderaa;
            dgvactividades.Rows.RemoveAt(dgvactividades.CurrentRow.Index);
            lbltotal.Text = Sumatoria().ToString();
            dgvactividades.Enabled = false;
            btnAgregar.Enabled = false;

            
        }
        private int validaractu(DataGridView dgv)
            {

                int c = 0;
                int cont = dgv.Rows.Count;
                for (int i = 0; i < cont; i++)
                {
                    if (txtnn.Text == Convert.ToString(dgv[0, i].Value)) 
                    {
                        c++;
                        MessageBox.Show("Esta activiad ya existe", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                return c;
            }
        private void btnactu_Click(object sender, EventArgs e)
        {
            decimal total1 = 0;
            total1 += Convert.ToDecimal(txtnp.Text) + Sumatoria();
            if (total1 > pr.Periodoporcentaje(rbp35, rbs35, rb30) || decimal.Parse(txtnp.Text.ToString()) <= 0||validaractu(dgvactividades)!=0||txtnn.Text=="")
            {
                if (total1 > pr.Periodoporcentaje(rbp35, rbs35, rb30))
                    MessageBox.Show("La sumatoria de los porcentajes de las actividades" +
                        "\n exceden el pocentaje del periodo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (total1 < 0)
                    MessageBox.Show("Ingrese un porcentaje válido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (txtnn.Text == "")
                {

                    MessageBox.Show("Ingrese una actividad", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                
                    string nuevonombre;
                    SqlConnection getconexion = Conexion.Cnn();
                    nuevonombre = "NnombreAct";
                    scomand = new SqlCommand(nuevonombre, getconexion);
                    scomand.Parameters.AddWithValue("@Materia", cbMateria.Text.ToString());
                    scomand.Parameters.AddWithValue("@Grado", cbGrado.Text.ToString());
                    scomand.Parameters.AddWithValue("@Trimestre", pr.Trimestre(rbt1, rbt2, rbt3).ToString());
                    scomand.Parameters.AddWithValue("@Periodo", pr.Periodo(rbp35, rbs35, rb30).ToString());
                    scomand.Parameters.AddWithValue("@nombre", actividada);
                    scomand.Parameters.AddWithValue("@Nnombre", txtnn.Text);
                    scomand.Parameters.AddWithValue("@Seccion", cbSeccion.Text);
                    scomand.CommandType = CommandType.StoredProcedure;
                    scomand.ExecuteNonQuery();
                    getconexion.Close();

                    List<string> Alumnos = new List<string>();
                    List<decimal> calificacion = new List<decimal>();
                    List<decimal> PorcentajeMateria = new List<decimal>();
                    bool flag = false;
                    Procesos p = new Procesos();
                    SqlConnection getconexion0 = Conexion.Cnn();
                    string step1;
                    step1 = "UpdatePorstep1";
                    scomand = new SqlCommand(step1, getconexion0);
                    scomand.Parameters.AddWithValue("@Materia", cbMateria.Text.ToString());
                    scomand.Parameters.AddWithValue("@Actividad", txtnn.Text.ToString());
                    scomand.Parameters.AddWithValue("@Grado", cbGrado.Text.ToString());
                    scomand.Parameters.AddWithValue("@Trimestre", pr.Trimestre(rbp35, rbs35, rb30));
                    scomand.Parameters.AddWithValue("@Periodo", pr.Periodo(rbt1, rbt2, rbt3));
                    scomand.Parameters.AddWithValue("@Seccion", cbSeccion.Text);
                    scomand.CommandType = CommandType.StoredProcedure;
                    scomand.ExecuteNonQuery();
                    sreader = scomand.ExecuteReader();
                    while (sreader.Read())
                    {
                        Alumnos.Add(sreader["Nombre"].ToString());
                        calificacion.Add(decimal.Parse(sreader["Calificacion"].ToString()));
                        flag = true;
                    }
                    getconexion0.Close();
                    if (flag)
                    {



                        for (int i = 0; i < Alumnos.Count; i++)
                        {
                            SqlConnection getconexion1 = Conexion.Cnn();
                            string fillpor;
                            fillpor = "getPorcentajes";
                            scomand = new SqlCommand(fillpor, getconexion1);
                            scomand.Parameters.AddWithValue("@Alumno", Alumnos[i].ToString());
                            scomand.Parameters.AddWithValue("@Materia", cbMateria.Text.ToString());
                            scomand.Parameters.AddWithValue("@Trimestre", pr.Trimestre(rbt1, rbt2, rbt3));
                            scomand.Parameters.AddWithValue("@Periodo", pr.Periodo(rbp35, rbs35, rb30));
                            scomand.CommandType = CommandType.StoredProcedure;
                            scomand.ExecuteNonQuery();
                            sreader = scomand.ExecuteReader();
                            if (sreader.Read())
                            {
                                PorcentajeMateria.Add(decimal.Parse(sreader["Porcentaje"].ToString()));
                            }
                            getconexion1.Close();
                        }
                        decimal nuevoporcentaje = decimal.Parse(txtnp.Text.ToString()) - decimal.Parse(ponderaa);
                        for (int i = 0; i < Alumnos.Count; i++)
                        {
                            SqlConnection getconexion2 = Conexion.Cnn();
                            string updatePorcentaje = "UpdatePorcentaje";
                            scomand = new SqlCommand(updatePorcentaje, getconexion2);
                            scomand.Parameters.AddWithValue("@Alumno", Alumnos[i].ToString());
                            scomand.Parameters.AddWithValue("@Materia", cbMateria.Text.ToString());
                            scomand.Parameters.AddWithValue("@NPorcentaje", PorcentajeMateria[i] + (calificacion[i] * nuevoporcentaje) / 10);
                            scomand.Parameters.AddWithValue("@Trimestre", pr.Trimestre(rbt1, rbt2, rbt3));
                            scomand.Parameters.AddWithValue("@Periodo", pr.Periodo(rbp35, rbs35, rb30));
                            scomand.CommandType = CommandType.StoredProcedure;
                            scomand.ExecuteNonQuery();
                            sreader = scomand.ExecuteReader();
                            getconexion2.Close();

                        }



                    }
                    SqlConnection getconexion3 = Conexion.Cnn();
                    string updatePonderacion = "UpdatePonderacion";
                    scomand = new SqlCommand(updatePonderacion, getconexion3);
                    scomand.Parameters.AddWithValue("@Actividad", txtnn.Text);
                    scomand.Parameters.AddWithValue("@Materia", cbMateria.Text.ToString());
                    scomand.Parameters.AddWithValue("@Grado", cbGrado.Text.ToString());
                    scomand.Parameters.AddWithValue("@Trimestre", pr.Trimestre(rbt1, rbt2, rbt3));
                    scomand.Parameters.AddWithValue("@Periodo", pr.Periodo(rbp35, rbs35, rb30));
                    scomand.Parameters.AddWithValue("@Npodenra", decimal.Parse(txtnp.Text.ToString()));
                    scomand.Parameters.AddWithValue("@Seccion", cbSeccion.Text);
                    scomand.CommandType = CommandType.StoredProcedure;
                    scomand.ExecuteNonQuery();
                    sreader = scomand.ExecuteReader();
                    getconexion3.Close();
                    Alumnos.Clear();
                    PorcentajeMateria.Clear();
                    calificacion.Clear();

                    int conteo = dgvactividades.RowCount;
                    dgvactividades.Rows.Add();
                    dgvactividades[0, conteo].Value = txtnn.Text;
                    dgvactividades[1, conteo].Value = txtnp.Text;
                    lbltotal.Text = Sumatoria().ToString();
                    lblnn.Visible = false;
                    lblnp.Visible = false;
                    txtnn.Visible = false;
                    txtnp.Visible = false;
                    btnactu.Visible = false;


                    MessageBox.Show("Datos actualizados", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvactividades.Enabled = true;
                    btnAgregar.Enabled = true;
            }
            


            }


        private void Actividades_Load(object sender, EventArgs e)
        {
            if (pr.Preferencia(Usuario.usuario) == 1)
            {
                pr.LlenarGrados(cbGrado);
            }
            else if (pr.Preferencia(Usuario.usuario) == 2)
            {
                pr.gradocusto(Usuario.usuario, cbGrado);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pr.Limpiarcb(cbMateria);
              if (pr.Preferencia(Usuario.usuario) == 1)
            {
                pr.LlenarMaterias(cbMateria, cbGrado);
            }
            else if (pr.Preferencia(Usuario.usuario) == 2)
            {
                pr.materiacusto(Usuario.usuario, cbGrado,cbSeccion,cbMateria);
            }
        }
        }


 
        }


    
    
