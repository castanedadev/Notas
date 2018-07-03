using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp;
using System.IO;
using System.Diagnostics;
using System.Data.SqlClient;
namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        SqlDataReader sreader;
        SqlCommand scomand;
        Procesos pr = new Procesos();//Objeto de la clase procesos
      
        public Form1()
        {
            InitializeComponent();           
            
            cbMateria.Enabled = false;
            cbSeccion.Enabled = false;
            btnCargar.Enabled = false;
            btnExcel.Enabled = false;
            dgvauxiliar.Visible = false;
            button1.Enabled = false;
        }
        private void toPDF()
        {
            Document doc = new Document(PageSize.A4.Rotate(), 10, 10, 10, 10);
            SaveFileDialog savefiledialog1 = new SaveFileDialog();
            savefiledialog1.InitialDirectory = @"C:";
            savefiledialog1.Title = "Guarda reporte";
            savefiledialog1.DefaultExt = "pdf";
            savefiledialog1.Filter = "pdf Files (*.pdf)|*.pdf| All Files (*.*)|*.*";
            savefiledialog1.FilterIndex = 2;
            savefiledialog1.RestoreDirectory = true;
            string filename = "";
            if (savefiledialog1.ShowDialog() == DialogResult.OK)
            {
                filename = savefiledialog1.FileName;
            }
            if (filename.Trim() != "")
            {
                FileStream file = new FileStream(filename,
                    FileMode.OpenOrCreate,
                    FileAccess.ReadWrite,
                    FileShare.ReadWrite);
                PdfWriter.GetInstance(doc, file);
                doc.Open();

                Chunk chunk = new Chunk("Reporte de notas", FontFactory.GetFont("ARIAL", 20, iTextSharp.text.Font.BOLD));
                doc.Add(new Paragraph(chunk));
                doc.Add(new Paragraph("                                     "));
                doc.Add(new Paragraph("             COMPLEJO EDUCATIVO COLONIA TIERRA VIRGEN                        "));
                doc.Add(new Paragraph("   "));
                GenerarDocumento(doc);
                doc.Close();
                Process.Start(filename);
            }
        }
        public void GenerarDocumento(Document document)
        {
            int i, j;
            PdfPTable datatable = new PdfPTable(dgvRegistro.ColumnCount);
            datatable.DefaultCell.Padding = 3;
            float[] header = gettacolumnas(dgvRegistro);
            datatable.SetWidths(header);
            datatable.WidthPercentage = 100;
            datatable.DefaultCell.BorderWidth = 2;
            datatable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;
            for (i = 0; i < dgvRegistro.Columns.Count; i++)
            {
                datatable.AddCell(dgvRegistro.Columns[i].HeaderText);
            }
            datatable.HeaderRows = 1;
            datatable.DefaultCell.BorderWidth = 1;
            for (i = 0; i < dgvRegistro.Rows.Count; i++)
            {
                for (j = 0; j < dgvRegistro.Columns.Count; j++)
                {
                    if (dgvRegistro[j, i].Value != null)
                    {
                        datatable.AddCell(new Phrase(dgvRegistro[j, i].Value.ToString()));
                    }
                    else
                    {
                        datatable.AddCell(new Phrase(""));
                    }

                }
                datatable.CompleteRow();
            }
            document.Add(datatable);
        }

        private float[] gettacolumnas(DataGridView dgv)
        {
            float[] values = new float[dgv.ColumnCount];
            for (int i = 0; i < dgv.ColumnCount; i++)
            {
                values[i] = (float)dgv.Columns[i].Width;
            }
            return values;
        }

        private void cbGrado_SelectedIndexChanged(object sender, EventArgs e)
        {            
            pr.Vaciardgv(dgvRegistro);
            cbSeccion.Enabled = true;
            cbMateria.Enabled = true;
            btnExcel.Enabled = false;
            pr.Limpiarcb(cbSeccion);

            if (pr.Preferencia(Usuario.usuario) == 1)
            {
                pr.LlenarSeccion(cbSeccion, cbGrado);
            }
            else if (pr.Preferencia(Usuario.usuario) == 2)
            {
                pr.Seccioncusto(cbSeccion, cbGrado, Usuario.usuario);
            }

            if (pr.ListoCarga(cbGrado, cbSeccion, cbMateria,rbp35,rbs35,rb30,rbt1,rbt2,rbt3))
            {
                btnCargar.Enabled = true;
                button1.Enabled = true;
            }
            else
            {
                btnCargar.Enabled = false;
                button1.Enabled = false;
            }
        }

        private void cbSeccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            pr.Limpiarcb(cbMateria);
            if (pr.Preferencia(Usuario.usuario) == 1)
            {
                pr.LlenarMaterias(cbMateria, cbGrado);
            }
            else if (pr.Preferencia(Usuario.usuario) == 2)
            {
                pr.materiacusto(Usuario.usuario, cbGrado, cbSeccion, cbMateria);
            }
            if (pr.ListoCarga(cbGrado, cbSeccion, cbMateria, rbp35, rbs35, rb30, rbt1, rbt2, rbt3))
            {
                btnCargar.Enabled = true;
                button1.Enabled = true;
            }
            else
            {
                btnCargar.Enabled = false;
                button1.Enabled = false;
            }
          
        }

        private void cbMateria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pr.ListoCarga(cbGrado, cbSeccion, cbMateria, rbp35, rbs35, rb30, rbt1, rbt2, rbt3))
            {                
                btnCargar.Enabled = true;
                button1.Enabled = true;
            }
            else
            {
                btnCargar.Enabled = false;
                button1.Enabled = false;
            }            
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            
            pr.Vaciardgv(dgvRegistro);
            dgvRegistro.Columns.Add("No", "No");
            dgvRegistro.Columns.Add("ALUMNOS", "Alumnos");
            pr.LlenarAlumnos(cbGrado,cbSeccion,dgvRegistro);
            pr.LlenarActividades(cbSeccion,cbGrado,cbMateria,dgvRegistro,rbp35,rbs35,rb30,rbt1,rbt2,rbt3);
            dgvRegistro.Columns.Add("Porcentaje", "Porcentaje");
            pr.LlenarCalificaciones(cbMateria,cbGrado,cbSeccion,dgvRegistro,rbp35,rbs35,rb30,rbt1,rbt2,rbt3);
            pr.LlenarPorcentajes(cbMateria,dgvRegistro,rbp35,rbs35,rb30,rbt1,rbt2,rbt3);
            int c = dgvRegistro.ColumnCount;
           dgvRegistro.Columns["Porcentaje"].ReadOnly = true;
           dgvRegistro.Columns["ALUMNOS"].ReadOnly = true;
           dgvRegistro.Columns["No"].ReadOnly = true;
            btnExcel.Enabled = true;
        }

        private void dgvRegistro_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                pr.CuadroNotas(dgvRegistro, cbGrado, cbMateria, cbSeccion, rbt1, rbt2, rbt3, rbp35,
             rbs35, rb30);
            }
            catch (Exception)
            {

                MessageBox.Show("Ingrese datos válidos");
                dgvRegistro.CurrentCell.Value = "0";
                pr.CuadroNotas(dgvRegistro, cbGrado, cbMateria, cbSeccion, rbt1, rbt2, rbt3, rbp35,
            rbs35, rb30);
            }          
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            pr.exportarexcel(dgvRegistro);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void rbp1_CheckedChanged(object sender, EventArgs e)
        {
            if (pr.ListoCarga(cbGrado, cbSeccion, cbMateria, rbp35, rbs35, rb30, rbt1, rbt2, rbt3))
            {
                btnCargar.Enabled = true;
                button1.Enabled = true;
            }
            else
            {
                btnCargar.Enabled = false;
                button1.Enabled = false;
            }

        }

        private void rbp2_CheckedChanged(object sender, EventArgs e)
        {
            if (pr.ListoCarga(cbGrado, cbSeccion, cbMateria,rbp35,rbs35,rb30,rbt1, rbt2, rbt3))
            {
                btnCargar.Enabled = true;
                button1.Enabled = true;
            }
            else
            {
                btnCargar.Enabled = false;
                button1.Enabled = false;
            }
        }

        private void rbp3_CheckedChanged(object sender, EventArgs e)
        {
            if (pr.ListoCarga(cbGrado, cbSeccion, cbMateria, rbp35, rbs35, rb30, rbt1, rbt2, rbt3))
            {
                btnCargar.Enabled = true;
                button1.Enabled = true;
            }
            else
            {
                btnCargar.Enabled = false;
                button1.Enabled = false;
                
            }
        }

        private void rbp35_CheckedChanged(object sender, EventArgs e)
        {
              if (pr.ListoCarga(cbGrado, cbSeccion, cbMateria,rbp35,rbs35,rb30,rbt1, rbt2, rbt3))
            {
                btnCargar.Enabled = true;
                button1.Enabled = true;
            }
            else
            {
                btnCargar.Enabled = false;
                button1.Enabled = false;
            }
        }

        private void rbs35_CheckedChanged(object sender, EventArgs e)
        {
              if (pr.ListoCarga(cbGrado, cbSeccion, cbMateria,rbp35,rbs35,rb30,rbt1, rbt2, rbt3))
            {
                btnCargar.Enabled = true;
                button1.Enabled = true;
            }
            else
            {
                btnCargar.Enabled = false;
                button1.Enabled = false;
            }
        }

        private void rb30_CheckedChanged(object sender, EventArgs e)
        {
              if (pr.ListoCarga(cbGrado, cbSeccion,cbMateria,rbp35,rbs35,rb30,rbt1, rbt2, rbt3))
            {
                btnCargar.Enabled = true;
                button1.Enabled = true;
            }
            else
            {
                btnCargar.Enabled = false;
                button1.Enabled = false;
            }
        }

        private void btnActividades_Click(object sender, EventArgs e)
        {
            Actividades f = new Actividades();
            f.Show();
            this.Hide();
        }
        private void btnPDF_Click(object sender, EventArgs e)
        {
            toPDF();
        }

        private void Form1_Load(object sender, EventArgs e)
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

        private void regresarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Menu m = new Menu();
            m.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Importar im = new Importar();
            im.importwithquestion(dgvauxiliar);
            DialogResult dialog = MessageBox.Show("Desea importar este archivo a: " +
                "\nGrado: " + cbGrado.Text + "    Sección: " + cbSeccion.Text +
            "\nMateria: " + cbMateria.Text, "IMPORTAR", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {

                try
                {

                    for (int i = 0; i < dgvauxiliar.RowCount; i++)
                    {
                        for (int j = 2; j < dgvauxiliar.ColumnCount - 1; j++)
                        {
                            Procesos p = new Procesos();

                            if (Convert.ToString(dgvauxiliar[j, i].Value) == "")
                            {
                                dgvauxiliar.CurrentCell.Value = 0;
                            }

                            if (decimal.Parse(dgvauxiliar[j, i].Value.ToString()) < 0 || decimal.Parse(dgvauxiliar[j, i].Value.ToString()) > 10)
                            {
                                MessageBox.Show("Nota inválida", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                dgvauxiliar[j, i].Value = 0;
                            }

                            int columnas;
                            bool flag = false;
                            //x = dgvRegistro.CurrentCellAddress.X;
                            //y = dgvRegistro.CurrentCellAddress.Y;
                            columnas = dgvauxiliar.ColumnCount - 1;



                            SqlConnection getconexion = Conexion.Cnn();
                            string updatenotas;
                            updatenotas = "UpdateNotas";
                            scomand = new SqlCommand(updatenotas, getconexion);
                            scomand.Parameters.AddWithValue("@Materia", cbMateria.Text.ToString());
                            scomand.Parameters.AddWithValue("@Grado", cbGrado.Text.ToString());
                            scomand.Parameters.AddWithValue("@Seccion", cbSeccion.Text.ToString());
                            scomand.Parameters.AddWithValue("@Alumno", dgvauxiliar[1, i].Value.ToString());
                            scomand.Parameters.AddWithValue("@Actividad", dgvauxiliar.Columns[j].Name.ToString());
                            scomand.Parameters.AddWithValue("@Trimestre", p.Trimestre(rbt1, rbt2, rbt3));
                            scomand.Parameters.AddWithValue("@Periodo", p.Periodo(rbp35, rbs35, rb30));
                            scomand.Parameters.AddWithValue("@NCalificaion", decimal.Parse(dgvauxiliar[j, i].Value.ToString()));
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
                                scomand.Parameters.AddWithValue("@Alumno", dgvauxiliar[1, i].Value.ToString());
                                scomand.Parameters.AddWithValue("@Materia", cbMateria.Text.ToString());
                                scomand.Parameters.AddWithValue("@Actividad", dgvauxiliar.Columns[j].Name.ToString());
                                scomand.Parameters.AddWithValue("@Grado", cbGrado.Text.ToString());
                                scomand.Parameters.AddWithValue("@Seccion", cbSeccion.Text.ToString());
                                scomand.Parameters.AddWithValue("@Trimestre", p.Trimestre(rbt1, rbt2, rbt3));
                                scomand.Parameters.AddWithValue("@Periodo", p.Periodo(rbp35, rbs35, rb30));
                                scomand.Parameters.AddWithValue("@Calificacion", decimal.Parse(dgvauxiliar[j, i].Value.ToString()));
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


                            for (int po = 2; po < dgvauxiliar.ColumnCount - 1; po++)
                            {

                                if (Convert.ToString(dgvauxiliar[po, i].Value) != "")
                                {
                                    total = total + decimal.Parse(dgvauxiliar[po, i].Value.ToString()) * (porcentajes[po - 2]) / 10;
                                }

                            }
                            porcentajes.Clear();
                            string updatePorcentaje;
                            bool flag1 = false;
                            updatePorcentaje = "UpdatePorcentaje";
                            scomand = new SqlCommand(updatePorcentaje, getconexion);
                            getconexion.Open();
                            scomand.Parameters.AddWithValue("@Alumno", dgvauxiliar[1, i].Value.ToString());
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
                                scomand.Parameters.AddWithValue("@Alumno", dgvauxiliar[1, i].Value.ToString());
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
                            dgvauxiliar[columnas, i].Value = t.ToString();
                        }




                    }
                    dgvauxiliar.DataSource = null;
                    pr.Vaciardgv(dgvRegistro);
                    dgvRegistro.Columns.Add("No", "No");
                    dgvRegistro.Columns.Add("ALUMNOS", "Alumnos");
                    pr.LlenarAlumnos(cbGrado, cbSeccion, dgvRegistro);
                    pr.LlenarActividades(cbSeccion, cbGrado, cbMateria, dgvRegistro, rbp35, rbs35, rb30, rbt1, rbt2, rbt3);
                    dgvRegistro.Columns.Add("Porcentaje", "Porcentaje");
                    pr.LlenarCalificaciones(cbMateria, cbGrado, cbSeccion, dgvRegistro, rbp35, rbs35, rb30, rbt1, rbt2, rbt3);
                    pr.LlenarPorcentajes(cbMateria, dgvRegistro, rbp35, rbs35, rb30, rbt1, rbt2, rbt3);
                    int c = dgvRegistro.ColumnCount;
                    dgvRegistro.Columns["Porcentaje"].ReadOnly = true;
                    dgvRegistro.Columns["ALUMNOS"].ReadOnly = true;
                    dgvRegistro.Columns["No"].ReadOnly = true;
                    btnExcel.Enabled = true;
                    MessageBox.Show("Porcentajes actulizados");
                }
                catch (Exception ex)
                {

                    MessageBox.Show("ERROR" + ex);
                }
            }
        }

        
        
    }
}