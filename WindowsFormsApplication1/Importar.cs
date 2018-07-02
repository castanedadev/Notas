using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;

namespace WindowsFormsApplication1
{
    class Importar
    {
        public void importwithquestion(DataGridView DgvEyesight)
        {
            try
            {
                DgvEyesight.Columns.Clear();
                DgvEyesight.Rows.Clear();
                String ruta = "";
                OpenFileDialog file1 = new OpenFileDialog();
                file1.Title = "Seleccione archivo de Excel";
                if (file1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (file1.FileName.Equals("") == false)
                    {
                        ruta = file1.FileName;
                        OleDbConnection conn = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0;Data Source =" + ruta + " ;Extended Properties = 'Excel 12.0 XML;HDR = YES'");
                        OleDbDataAdapter adap = new OleDbDataAdapter("Select * from [Hoja1$]", conn);
                        DataTable dt = new DataTable();
                        adap.Fill(dt);
                        DgvEyesight.DataSource = dt;
                        conn.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Error\n" + file1.FileName + "");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "");
            }
        }
    }
}
