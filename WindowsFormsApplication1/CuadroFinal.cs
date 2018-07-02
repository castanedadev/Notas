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

namespace WindowsFormsApplication1
{
    public partial class CuadroFinal : Form
    {
        Procesos pr = new Procesos();
        public CuadroFinal()
        {
            InitializeComponent();

            btnCargar.Enabled = false;
        }
        private void Activar()
        {
            if (cbGrado.Text != "" && cbMateria.Text != "" && cbSeccion.Text != "")
                btnCargar.Enabled = true;
            else
                btnCargar.Enabled = false;

        }

        private void CuadroFinal_Load(object sender, EventArgs e)
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

        private void btnCargar_Click(object sender, EventArgs e)
        {
            pr.CrearCuadrofinal(dgvcuadrofinal);
            pr.LlenarAlumnos(cbGrado, cbSeccion, dgvcuadrofinal);
            pr.LlenarcuadroFinal(dgvcuadrofinal,cbMateria);

        }

        private void cbGrado_SelectedIndexChanged(object sender, EventArgs e)
        {
            pr.Limpiarcb(cbSeccion);
            pr.Limpiarcb(cbMateria);
            if (pr.Preferencia(Usuario.usuario) == 1)
            {
                pr.LlenarSeccion(cbSeccion, cbGrado);
            }
            else if (pr.Preferencia(Usuario.usuario) == 2)
            {
                pr.Seccioncusto(cbSeccion, cbGrado, Usuario.usuario);
            }
            Activar();
        }
        private void toPDF()
        {
            string aux = Application.StartupPath;
            aux += "\\Logo.jpeg";
            iTextSharp.text.Image imagen= iTextSharp.text.Image.GetInstance(aux);
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
               PdfWriter pdfw=PdfWriter.GetInstance(doc, file);
                doc.Open();
                doc.Add(imagen);
                doc.Add(new Paragraph("                                                                                   COMPLEJO EDUCATIVO COLONIA TIERRA VIRGEN "));
                doc.Add(new Paragraph("                                                                                                    PROMEDIOS TRIMESTRALES"));
                doc.Add(new Paragraph("          GRADO:" + cbGrado.Text + "        SECCIÓN:" + cbSeccion.Text + "                      ASIGNTURA:" + cbMateria.Text));
                doc.Add(new Paragraph("    "));
                doc.Add(new Paragraph("          DOCENTE:"+pr.Nombrereportfinal(Usuario.usuario)+"                         FIRMA:________________________"));
                doc.Add(new Paragraph("    "));
                doc.Add(new Paragraph("                                                                       PRIMER TRIMESTRE       |SEGUNDO TRIMESTRE      |TERCER TRIMESTRE         |"));
                doc.Add(new Paragraph("   "));
                GenerarDocumento(doc);
                pdfw.PageEvent = new PDFFooter(); 
                doc.Close();
                Process.Start(filename);
            }
        }
        public void GenerarDocumento(Document document)
        {
            int i, j;
            PdfPTable datatable = new PdfPTable(dgvcuadrofinal.ColumnCount);
            datatable.DefaultCell.Padding = 2;
            float[] header = gettacolumnas(dgvcuadrofinal);
            datatable.SetWidths(header);
            datatable.DefaultCell.BorderWidth = 1;
            datatable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;
            for (i = 0; i < dgvcuadrofinal.Columns.Count; i++)
            {
                datatable.AddCell(dgvcuadrofinal.Columns[i].HeaderText);
            }
            datatable.HeaderRows = 1;
            datatable.DefaultCell.BorderWidth = 1;
            for (i = 0; i < dgvcuadrofinal.Rows.Count; i++)
            {
                for (j = 0; j < dgvcuadrofinal.Columns.Count; j++)
                {
                    if (dgvcuadrofinal[j, i].Value != null)
                    {
                        datatable.AddCell(new Phrase(dgvcuadrofinal[j, i].Value.ToString()));
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


        public class PDFFooter : PdfPageEventHelper
        {
            public override void OnEndPage(PdfWriter writer, Document document)
            {
                //base.OnEndPage(writer, document); 
                // Writing Footer on Page 
                PdfPTable tab = new PdfPTable(1);
                PdfPCell cell = new PdfPCell(new Phrase("© Derechos Reservados 2018 Universidad Don Bosco Todos los Derechos Reservados."));
                cell.Border = 0;
                tab.TotalWidth = 600F;
                tab.AddCell(cell);
                tab.WriteSelectedRows(0, -1, 150, 30, writer.DirectContent);
            }


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

        private void button1_Click_1(object sender, EventArgs e)
        {
            toPDF();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Actividades f = new Actividades();
            f.Show();
            this.Hide();
        }

        private void regresarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Menu m = new Menu();
            m.Show();
            this.Hide();
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
            Activar();
        }

        private void cbMateria_SelectedIndexChanged(object sender, EventArgs e)
        {
            Activar();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Graficos g = new Graficos();
            g.Show();
        }

       



    }
}
