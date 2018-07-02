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

namespace WindowsFormsApplication1.F3
{
    public partial class DocenteR : Form
    {
        Procesos call = new Procesos();
       
        private F2.PropiedadMaestro maestro;
        private NGM materias;

        ProdTraslado mtd = new ProdTraslado();
        public DocenteR()
        {
            InitializeComponent();
            
        }
        public DocenteR(F2.PropiedadMaestro n,NGM ma)
        {
            InitializeComponent();
            maestro = n as F2.PropiedadMaestro;
            materias = ma as NGM;
            LlenarCampos();
            mtd.LlenarData(DGV_g_m, ma);
            RecuperarProfesores g=new RecuperarProfesores();
            this.Width=g.Width;
            this.Height=g.Height;

        }


        internal void LlenarCampos()
        {
            txtDui.Text = maestro.IdMaestro;
            txtNombre.Text = maestro.Nombre;
            TimeFecha.Text = maestro.Fecha;
            txtTelefono.Text = maestro.Telefono;
            txtDireccion.Text = maestro.Direccion;


            if (maestro.Grado != 1 && maestro.Seccion != 1)
            {

                ChecBTutor.Checked = true;
                CombMChanged();
                ComBGrado.SelectedIndex = maestro.Grado - 2;

                CombSecc();
                ComBSeccion.SelectedIndex = maestro.Seccion - 2;



            }
        
        
        }


        private void Docente_Load(object sender, EventArgs e)
        {
            call.LlenarGrados(ComBGrado2);
         
       
        }

        private void ChecBTutor_CheckedChanged(object sender, EventArgs e)
        {
            GB_tutor.Visible = true;
            ComBGrado.Enabled = true;
            call.LlenarGrados(ComBGrado);
        }

        private void ComBGrado_SelectedIndexChanged(object sender, EventArgs e)
        {
            CombMChanged();
        }
        internal void CombMChanged()
        {
            call.Limpiarcb(ComBSeccion);
            call.LlenarSeccion(ComBSeccion, ComBGrado);
            ComBSeccion.Enabled = true;
            
        }


        private void ComBGrado2_SelectedIndexChanged(object sender, EventArgs e)
        {
            CombSecc();
        }
        internal void CombSecc()
        {

            ComBMateria.Enabled = true;
            call.Limpiarcb(ComBMateria);
            call.LlenarMaterias(ComBMateria, ComBGrado2);   
        
        }


        private void ComBMateria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!VerificarTutoria())
                errorProvider1.SetError(ComBGrado, "Error al elegir grado o sección");
            else
                errorProvider1.Clear();

            ComboBNGS.Enabled = true;
            ComboBNGS.Items.Clear();
            call.Limpiarcb(ComboBNGS);
            call.LlenarSeccion(ComboBNGS, ComBGrado2);
        }

        private void cmb1seccion_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (!VerificarMaterias())
            {

                MessageBox.Show("Materia ya ocupada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else

            { 
                int materia=ComBMateria.SelectedIndex+1;
            
                int grado=ComBGrado2.SelectedIndex+2;
                int seccion=ComboBNGS.SelectedIndex+2;


                if (MessageBox.Show("   ¿ Desea Agregar ?\n\n Grado:   " + ComBGrado2.Text + "\n Materia: " + ComBMateria.Text + "\n Seccion: " + ComboBNGS.Text, "Agregar Grado y materia", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                      {
                            DGV_g_m.Rows.Add(ComBGrado2.Text, ComBMateria.Text, ComboBNGS.Text);
                       }
                materias.Grado.Add(grado);
                materias.Seccion.Add(seccion);
                materias.Materia.Add(materia);
            
            }
         
        }

        internal bool VerificarMaterias()
        {
            SqlConnection cn = Conexion.Cnn();                
            bool retorno = true;

            try
            {
                int materia=ComBMateria.SelectedIndex+1;
                int grado=ComBGrado2.SelectedIndex+2;
                int seccion=ComboBNGS.SelectedIndex+2;

                string cadena="SELECT * FROM NGM WHERE Materia="+materia+" AND Grado= "+grado+" AND Seccion= "+seccion;
                SqlCommand cmm = new SqlCommand(cadena, cn);
                SqlDataReader reader;
                reader = cmm.ExecuteReader();
                if (reader.HasRows)
                {
                    MessageBox.Show("Materia ya ocupada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                
                }
                reader.Close();

                NGM aux;

                for (int i = 0; i < ProdTraslado.pNGM.Count; i++)
                {
                    aux = ProdTraslado.pNGM[i];
                    if (aux.Maestro != materias.Maestro)
                    {
                        int d = 0;

                        foreach (int Grados in aux.Grado)
                        {
                            if (Grados == grado)
                            {
                                if (seccion == aux.Seccion[d])
                                {
                                    if (materia == aux.Materia[d])
                                    {

                                        return false;
                                    }
                                
                                }

                            
                            }

                            d++;
                            
                        }
                    
                    
                    
                    }
                    
                }
               






                cn.Close();
                return retorno;

            }
            catch
            {
                cn.Close();
                return false;

            }
        
        
        
        }
 



        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            maestro.Estado = 1;

            if (txtDireccion.Text == "")
            {
                errorProvider1.SetError(txtDireccion, "Campo vacio");
                return;
            }
            else
                errorProvider1.Clear();

            if (txtTelefono.Text == "" || (txtTelefono.Text.Length >8))
            {
                errorProvider1.SetError(txtTelefono, "Campo inválido");
                return;
            }
            else
                errorProvider1.Clear();

           




            if (ChecBTutor.Checked == true)
            {
                if (ComBGrado.SelectedIndex != -1 && ComBSeccion.SelectedIndex != -1)
                {


                    if (VerificarTutoria())
                    {
                        errorProvider1.Clear();
                        maestro.Grado = ComBGrado.SelectedIndex + 2;
                        maestro.Seccion = ComBSeccion.SelectedIndex + 2;
                        maestro.Telefono = txtTelefono.Text;
                        maestro.Direccion = txtDireccion.Text;
                        maestro.Tutor = 1;
                        this.Close();
                    }
                    else
                    {
                        errorProvider1.SetError(ComBGrado, "Error al llenar grado o sección");
                        return;
                    }


                }
            }
            else
            {
                maestro.Telefono = txtTelefono.Text;
                maestro.Direccion = txtDireccion.Text;
                
                maestro.Tutor = 0;
                this.Close();
            
            }
            
          
        
        }

       
  

      

       


   
        
        internal bool VerificarTutoria()
        {
            SqlConnection conn = Conexion.Cnn();
            bool retorno = true;
            
                try
                {
                    int grado = ComBGrado.SelectedIndex + 2;
                    int seccion = ComBSeccion.SelectedIndex + 2;
                    string cadena = "SELECT * FROM Maestros WHERE Grado_t=" + grado + " AND Seccion_t=" + seccion;

                    SqlDataReader reader;
                    SqlCommand cmm = new SqlCommand(cadena, conn);
                    reader = cmm.ExecuteReader();

                    if (reader.HasRows)
                    {
                        errorProvider1.SetError(ComBGrado, "Tutoria ocupada, cambie grado o sección");
                        retorno = false;
                    }
                    else
                    {
                        errorProvider1.Clear();

                        foreach (F2.PropiedadMaestro item in ProdTraslado.profes)
                        {
                            if (item.Nombre != maestro.Nombre)
                            {
                                if (item.Grado == grado)
                                {
                                    if (item.Seccion == seccion)
                                    {
                                        errorProvider1.SetError(ComBGrado, "Tutoria ocupada, cambie grado o sección");
                                        retorno = false;
                                        break;
                                    }
                                }
                            }

                        }

                       
                    }

                      conn.Close();
                    return retorno;

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                    conn.Close();
                    return false;
                }


            
        
        
        
        }



        private void DGV_g_m_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (MessageBox.Show("Grado:    " + DGV_g_m.Rows[e.RowIndex].Cells[0].Value + "\nMateria: " + DGV_g_m.Rows[e.RowIndex].Cells[1].Value + "\nSeccion: " + DGV_g_m.Rows[e.RowIndex].Cells[2].Value + "\n\n¿Dese eliminar estos datos?", "ELIMINAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DGV_g_m.Rows.RemoveAt(e.RowIndex);

                    materias.Grado.RemoveAt(e.RowIndex);


                    materias.Seccion.RemoveAt(e.RowIndex);
                    materias.Materia.RemoveAt(e.RowIndex);
                }
            }
            catch
            { 
            }
           
            //DGV_g_m.CurrentCell.Value = "";
            //DGV_g_m.Rows[e.RowIndex].Cells[0].Value = "";
            //DGV_g_m.Rows[e.RowIndex].Cells[1].Value = "";
            //DGV_g_m.Rows.RemoveAt(e.RowIndex);
            //DGV_g_m.Rows.RemoveAt(DGV_g_m.CurrentCell);
            //MessageBox.Show(DGV_g_m.SelectedRows.IsReadOnly + "");
        }

        //ver

     
       
      
       
   

        //actualiz
        



        private void ComBSeccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!VerificarTutoria())
            {
                errorProvider1.SetError(ComBGrado, "Tutoría ocupada");
                ComBGrado.SelectedIndex = -1;
                ComBSeccion.SelectedIndex = -1;
            }
            else
            {
                errorProvider1.Clear();
            }
        }

 




        


        
    }
}
