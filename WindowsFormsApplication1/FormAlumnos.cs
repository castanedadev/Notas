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

namespace WindowsFormsApplication1
{
    public partial class FormAlumnos : Form
    {
        string nom, apel, aux;
        Procesos pr = new Procesos();
        private SqlCommand scomand;
        private SqlDataReader sreader;
        public FormAlumnos()
        {
            InitializeComponent();
            pr.LlenarGrados(cbGrado);
            cbSeccion.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (validacion() && valnie() && valnombre())
            {

                try
                {

                    SqlConnection getconexion = Conexion.Cnn();


                    string spinsertar = "Ingresaralumnos";
                    scomand = new SqlCommand(spinsertar, getconexion);
                    scomand.Parameters.AddWithValue("@NIE", txtNIE.Text);
                    scomand.Parameters.AddWithValue("@Nombre", txtApell.Text + "," + txtNom.Text);
                    scomand.Parameters.Add(new SqlParameter("@Fecha_Nac", SqlDbType.Date));
                    scomand.Parameters["@Fecha_Nac"].Value = dTDFechaN.Text;
                    scomand.Parameters.AddWithValue("@Telefono", txtTelefono.Text);
                    scomand.Parameters.AddWithValue("@Direccion", txtDic.Text);
                    scomand.Parameters.AddWithValue("@Responsable", txtResponsable.Text);
                    scomand.Parameters.AddWithValue("@Grado", pr.idgrado(cbGrado));
                    scomand.Parameters.AddWithValue("@Seccion", pr.idseccion(cbSeccion.Text));

                    scomand.CommandType = CommandType.StoredProcedure;
                    scomand.ExecuteNonQuery();
                    getconexion.Close();
                    MessageBox.Show("Agregado con exito", "REGISTRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNIE.Clear();
                    txtNom.Clear();
                    txtApell.Clear();
                    dTDFechaN.ResetText();
                    txtTelefono.Clear();
                    txtDic.Clear();
                    txtResponsable.Clear();
                    cbGrado.Text ="";
                    cbSeccion.Text = "";
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Error en registro", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNIE.Clear();
                txtNom.Clear();
                txtApell.Clear();
                dTDFechaN.ResetText();
                txtTelefono.Clear();
                txtDic.Clear();
                txtResponsable.Clear();
                cbGrado.Text = "";
                cbSeccion.Text = "";
            }
          

        }

        private void FormAlumnos_Load(object sender, EventArgs e)
        {
            label10.Visible = false;
            btnIngresar.Enabled = false;
            txtNIE.Enabled = false;
            txtApell.Enabled = false;
            txtNom.Enabled = false;
            dTDFechaN.Enabled = false;
            txtTelefono.Enabled = false;
            txtDic.Enabled = false;
            txtResponsable.Enabled = false;
            cbGrado.Enabled = false;
            cbSeccion.Enabled = false;
            btnActualizar.Enabled = false;
            btnBorrar.Enabled = false;
            cbSelec.Visible = false;
            label11.Visible = false;
            cbEstado.Visible = false;
        }
        public bool validacion()
        {
            if (txtNIE.Text == "" || txtDic.Text == "" || txtNom.Text == "" || txtResponsable.Text == "" || txtTelefono.Text == "" || txtApell.Text == "")
            {

                return (false);
            }
            else
                return (true);
        }
        public bool valnie()
        {
            if (validacion())
            {
                string nie = "";
                SqlConnection getconexion = Conexion.Cnn();

                string validarnie = "Select NIE from ALUMNO WHERE NIE=@NIE";
                scomand = new SqlCommand(validarnie, getconexion);
                scomand.Parameters.AddWithValue("@NIE", txtNIE.Text);
                scomand.ExecuteNonQuery();
                sreader = scomand.ExecuteReader();
                while (sreader.Read())
                {
                    nie = sreader["NIE"].ToString();
                }
                getconexion.Close();
                if (txtNIE.Text==nie)
                {
                    MessageBox.Show("NIE Existente", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return (false);
                }
                else
                {
                    return (true);
                }
            }
            else
            {
                return (false);
            }

        }

        public bool valnombre()
        {
            if (validacion())
            {
                string nombre = "";
                SqlConnection getconexion = Conexion.Cnn();

                string validarnie = "Select Nombre from ALUMNO WHERE Nombre=@Nombre";
                scomand = new SqlCommand(validarnie, getconexion);
                scomand.Parameters.AddWithValue("@Nombre", txtApell.Text+","+txtNom.Text);
                scomand.ExecuteNonQuery();
                sreader = scomand.ExecuteReader();
                while (sreader.Read())
                {
                    nombre = sreader["Nombre"].ToString();
                }
                getconexion.Close();
                if (txtApell.Text + "," + txtNom.Text == nombre)
                {
                    MessageBox.Show("Ese nombre ya fue registrado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return (false);
                }
                else
                {
                    return (true);
                }
            }
            else
            {
                return (false);
            }

        }
        public bool valnombreactu()
        {
            if (validacion())
            {
                string nombre = "";
                string nie = "";
                SqlConnection getconexion = Conexion.Cnn();

                string validarnie = "Select Nombre,NIE from ALUMNO WHERE Nombre=@Nombre";
                scomand = new SqlCommand(validarnie, getconexion);
                scomand.Parameters.AddWithValue("@Nombre", txtApell.Text + "," + txtNom.Text);
                scomand.ExecuteNonQuery();
                sreader = scomand.ExecuteReader();
                while (sreader.Read())
                {
                    nombre = sreader["Nombre"].ToString();
                    nie = sreader["NIE"].ToString();
                }
                getconexion.Close();
                if (txtNIE.Text != nie)
                {
                    MessageBox.Show("Ese nombre ya fue registrado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return (false);
                }
                else
                {
                    return (true);
                }
            }
            else
            {
                return (false);
            }

        }




        public string separacionapellido(string ax)
        {
            int cm = 0;
            for (int i = 0; i < ax.Length; i++)
            {
                if (ax[i].ToString() == ",")
                {
                    cm = i;
                }
            }

            apel = ax.Substring(0, cm);

            return (apel);

        }
        public string separacionnombre(string ax)
        {
            int cm = 0, ck = 0;
            for (int i = 0; i < ax.Length; i++)
            {
                if (ax[i].ToString() == ",")
                {
                    cm = i;
                    ck = i + 1;
                }
            }


            nom = ax.Substring(ck, ax.Length - cm - 1);
            return (nom);

        }

        private void cbGrado_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbSeccion.Items.Clear();
            pr.LlenarSeccion(cbSeccion, cbGrado);
            cbSeccion.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (validacion() && valnombre())
            {
                try
                {

                    SqlConnection getconexion = Conexion.Cnn();
                    string udtalumnos = "updatealumnos";
                    scomand = new SqlCommand(udtalumnos, getconexion);

                    scomand.Parameters.AddWithValue("@NIE", txtNIE.Text);
                    scomand.Parameters.AddWithValue("@Nombre", txtApell.Text + "," + txtNom.Text);
                    scomand.Parameters.Add(new SqlParameter("@Fecha_Nac", SqlDbType.Date));
                    scomand.Parameters["@Fecha_Nac"].Value = dTDFechaN.Text;
                    scomand.Parameters.AddWithValue("@Telefono", txtTelefono.Text);
                    scomand.Parameters.AddWithValue("@Direccion", txtDic.Text);
                    scomand.Parameters.AddWithValue("@Responsable", txtResponsable.Text);
                    scomand.Parameters.AddWithValue("@Grado", pr.idgrado(cbGrado));
                    scomand.Parameters.AddWithValue("@Seccion", pr.idseccion(cbSeccion.Text));
                    scomand.Parameters.AddWithValue("@Estado", cbEstado.Text.ToString());

                    scomand.CommandType = CommandType.StoredProcedure;
                    scomand.ExecuteNonQuery();
                    getconexion.Close();
                    MessageBox.Show("Actualizacion exitosa", "ACTUALIZACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtNIE.Clear();
                    txtNom.Clear();
                    txtApell.Clear();
                    dTDFechaN.ResetText();
                    txtTelefono.Clear();
                    txtDic.Clear();
                    txtResponsable.Clear();
                    btnActualizar.Enabled = false;
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Error en registro", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNom.Clear();
                txtApell.Clear();
                dTDFechaN.ResetText();
                txtTelefono.Clear();
                txtDic.Clear();
                txtResponsable.Clear();
            }
            
        }



        private void button4_Click(object sender, EventArgs e)
        {
            if (txtNIE.Text != "")
            {
                try
                {
                    SqlConnection getconexion = Conexion.Cnn();
                    string borrar = "borrar_alumno";
                    scomand = new SqlCommand(borrar, getconexion);
                    scomand.Parameters.AddWithValue("@NIE", txtNIE.Text);
                    scomand.CommandType = CommandType.StoredProcedure;
                    scomand.ExecuteNonQuery();
                    getconexion.Close();
                    MessageBox.Show("Registro borrado exitosamente", "ELIMINADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNIE.Clear();
                    txtNom.Clear();
                    txtApell.Clear();
                    dTDFechaN.ResetText();
                    txtTelefono.Clear();
                    txtDic.Clear();
                    txtResponsable.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show("Error al borrar registro", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNIE.Clear();
                txtNom.Clear();
                txtApell.Clear();
                dTDFechaN.ResetText();
                txtTelefono.Clear();
                txtDic.Clear();
                txtResponsable.Clear();
            }
            
        }

        private void rbia_CheckedChanged(object sender, EventArgs e)
        {
            cbEstado.Items.Clear();
            cbEstado.Text = "";
            label10.Visible = false;
            cbSelec.Text = "";
            txtNIE.Clear();
            txtNom.Clear();
            txtApell.Clear();
            cbSelec.Items.Clear();
            dTDFechaN.ResetText();
            txtTelefono.Clear();
            txtDic.Clear();
            txtResponsable.Clear();
            btnIngresar.Enabled = true;
          txtNIE.Enabled=true;
        txtApell.Enabled=true;
            txtNom.Enabled=true;
           dTDFechaN.Enabled=true;
             txtTelefono.Enabled=true;
           txtDic.Enabled=true;
           txtResponsable.Enabled = true;
           cbGrado.Enabled = true;
           cbSeccion.Enabled = true;
           btnActualizar.Enabled = false;
           btnBorrar.Enabled = false;
           cbSelec.Visible = false;
           label11.Visible = false;
           cbEstado.Visible = false;

        }

        private void rbactu_CheckedChanged(object sender, EventArgs e)
        {
            cbEstado.Items.Clear();
            cbEstado.Text = "";
            label10.Visible = true;
            cbSelec.Text = "";
            cbSelec.Items.Clear();
            txtNIE.Clear();
            txtNom.Clear();
            txtApell.Clear();
            dTDFechaN.ResetText();
            txtTelefono.Clear();
            txtDic.Clear();
            txtResponsable.Clear();
            btnIngresar.Enabled = false;
            txtNIE.Enabled = false;
            txtApell.Enabled = false;
            txtNom.Enabled = false;
            dTDFechaN.Enabled = false;
            txtTelefono.Enabled = false;
            txtDic.Enabled = false;
            txtResponsable.Enabled = false;
            cbGrado.Enabled = false;
            cbSeccion.Enabled = false;
            btnActualizar.Enabled = true;
            btnBorrar.Enabled = false;
            cbSelec.Visible = true;
            label11.Visible = false;
            cbEstado.Visible = false;

        }

        private void rbdelete_CheckedChanged(object sender, EventArgs e)
        {
            cbEstado.Items.Clear();
            cbEstado.Text = "";
            label10.Visible = false;
            cbSelec.Text = "";
            cbSelec.Items.Clear();
            txtNIE.Clear();
            txtNom.Clear();
            txtApell.Clear();
            dTDFechaN.ResetText();
            txtTelefono.Clear();
            txtDic.Clear();
            txtResponsable.Clear();
            btnIngresar.Enabled = false;
            txtNIE.Enabled = true;
            txtApell.Enabled = false;
            txtNom.Enabled = false;
            dTDFechaN.Enabled = false;
            txtTelefono.Enabled = false;
            txtDic.Enabled = false;
            txtResponsable.Enabled = false;
            cbGrado.Enabled = false;
            cbSeccion.Enabled = false;
            btnActualizar.Enabled = false;
            btnBorrar.Enabled = true;
            cbSelec.Visible = false;
            label11.Visible = false;
            cbEstado.Visible = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Actividades f = new Actividades();
            f.Show();
            this.Hide();
        }

        private void cbSelec_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                SqlConnection getconexion = Conexion.Cnn();
                string selecinfo = "selecinfo_alumnos";
                scomand = new SqlCommand(selecinfo, getconexion);
                scomand.Parameters.AddWithValue("@Nombre", cbSelec.Text);
                scomand.CommandType = CommandType.StoredProcedure;
                scomand.ExecuteNonQuery();
                sreader = scomand.ExecuteReader();
                while (sreader.Read())
                {
                    ////////
                    txtNIE.Text = sreader["NIE"].ToString();
                    aux = sreader["Nombre"].ToString();
                    dTDFechaN.Text = sreader["Fecha_Nac"].ToString();
                    txtTelefono.Text = sreader["Telefono"].ToString();
                    txtDic.Text = sreader["Direccion"].ToString();
                    txtResponsable.Text = sreader["Responsable"].ToString();
                    cbGrado.Text = sreader["Grado"].ToString();
                    cbSeccion.Text = sreader["Seccion"].ToString();

                }
                txtApell.Text = separacionapellido(aux);
                txtNom.Text = separacionnombre(aux);
                sreader.Close();
                getconexion.Close();
                cbEstado.Items.Clear();
                pr.getestado(cbEstado,txtNom,txtApell);
                btnIngresar.Enabled = false;
                txtNIE.Enabled = true;
                txtApell.Enabled = true;
                txtNom.Enabled = true;
                dTDFechaN.Enabled = true;
                txtTelefono.Enabled = true;
                txtDic.Enabled = true;
                txtResponsable.Enabled = true;
                cbGrado.Enabled = true;
                cbSeccion.Enabled = true;
                btnActualizar.Enabled = true;
                btnBorrar.Enabled = false;
                label11.Visible = true;
                cbEstado.Visible = true;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error" + ex);
            }


        }

        private void cbSelec_TextChanged(object sender, EventArgs e)
        {
            cbSelec.Items.Clear();

            cbSelec.Focus();
            cbSelec.Select(cbSelec.Text.Length, 0);
            try
            {

                SqlConnection getconexion = Conexion.Cnn();
                string selecinfo = "getname";
                scomand = new SqlCommand(selecinfo, getconexion);
                scomand.Parameters.AddWithValue("@Nombre", cbSelec.Text);
                scomand.CommandType = CommandType.StoredProcedure;
                scomand.ExecuteNonQuery();
                sreader = scomand.ExecuteReader();
                while (sreader.Read())
                {
                    ////////

                    cbSelec.Items.Add(sreader["Nombre"].ToString());


                }

                sreader.Close();
                getconexion.Close();


            }
            catch (Exception ex)
            {

                MessageBox.Show("Error" + ex);
            }
           
        }

        private void regresarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Menu m = new Menu();
            m.Show();
            this.Hide();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (validacion() && valnie() && valnombre())
            {

                try
                {

                    SqlConnection getconexion = Conexion.Cnn();


                    string spinsertar = "Ingresaralumnos";
                    scomand = new SqlCommand(spinsertar, getconexion);
                    scomand.Parameters.AddWithValue("@NIE", txtNIE.Text);
                    scomand.Parameters.AddWithValue("@Nombre", txtApell.Text + "," + txtNom.Text);
                    scomand.Parameters.Add(new SqlParameter("@Fecha_Nac", SqlDbType.Date));
                    scomand.Parameters["@Fecha_Nac"].Value = dTDFechaN.Text;
                    scomand.Parameters.AddWithValue("@Telefono", txtTelefono.Text);
                    scomand.Parameters.AddWithValue("@Direccion", txtDic.Text);
                    scomand.Parameters.AddWithValue("@Responsable", txtResponsable.Text);
                    scomand.Parameters.AddWithValue("@Grado", pr.idgrado(cbGrado));
                    scomand.Parameters.AddWithValue("@Seccion", pr.idseccion(cbSeccion.Text));

                    scomand.CommandType = CommandType.StoredProcedure;
                    scomand.ExecuteNonQuery();
                    getconexion.Close();
                    MessageBox.Show("Agregado con exito", "REGISTRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNIE.Clear();
                    txtNom.Clear();
                    txtApell.Clear();
                    dTDFechaN.ResetText();
                    txtTelefono.Clear();
                    txtDic.Clear();
                    txtResponsable.Clear();
                    cbGrado.Text = "";
                    cbSeccion.Text = "";
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error" + ex);
                }
            }
            else
            {
                MessageBox.Show("Error en registro", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNIE.Clear();
                txtNom.Clear();
                txtApell.Clear();
                dTDFechaN.ResetText();
                txtTelefono.Clear();
                txtDic.Clear();
                txtResponsable.Clear();
                cbGrado.Text = "";
                cbSeccion.Text = "";
            }
          

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            if (validacion() && valnombreactu())
            {
                try
                {

                    SqlConnection getconexion = Conexion.Cnn();
                    string udtalumnos = "updatealumnos";
                    scomand = new SqlCommand(udtalumnos, getconexion);

                    scomand.Parameters.AddWithValue("@NIE", txtNIE.Text);
                    scomand.Parameters.AddWithValue("@Nombre", txtApell.Text + "," + txtNom.Text);
                    scomand.Parameters.Add(new SqlParameter("@Fecha_Nac", SqlDbType.Date));
                    scomand.Parameters["@Fecha_Nac"].Value = dTDFechaN.Text;
                    scomand.Parameters.AddWithValue("@Telefono", txtTelefono.Text);
                    scomand.Parameters.AddWithValue("@Direccion", txtDic.Text);
                    scomand.Parameters.AddWithValue("@Responsable", txtResponsable.Text);
                    scomand.Parameters.AddWithValue("@Grado", pr.idgrado(cbGrado));
                    scomand.Parameters.AddWithValue("@Seccion", pr.idseccion(cbSeccion.Text));
                    scomand.Parameters.AddWithValue("@Estado", cbEstado.Text.ToString());

                    scomand.CommandType = CommandType.StoredProcedure;
                    scomand.ExecuteNonQuery();
                    getconexion.Close();
                    MessageBox.Show("Actualizacion exitosa", "ACTUALIZACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtNIE.Clear();
                    txtNom.Clear();
                    txtApell.Clear();
                    dTDFechaN.ResetText();
                    txtTelefono.Clear();
                    txtDic.Clear();
                    txtResponsable.Clear();
                    btnActualizar.Enabled = false;
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Error en registro", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNom.Clear();
                txtApell.Clear();
                dTDFechaN.ResetText();
                txtTelefono.Clear();
                txtDic.Clear();
                txtResponsable.Clear();
            }

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (txtNIE.Text != "")
            {
                try
                {
                    SqlConnection getconexion = Conexion.Cnn();
                    string borrar = "borrar_alumno";
                    scomand = new SqlCommand(borrar, getconexion);
                    scomand.Parameters.AddWithValue("@NIE", txtNIE.Text);
                    scomand.CommandType = CommandType.StoredProcedure;
                    scomand.ExecuteNonQuery();
                    getconexion.Close();
                    MessageBox.Show("Registro borrado exitosamente", "ELIMINADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNIE.Clear();
                    txtNom.Clear();
                    txtApell.Clear();
                    dTDFechaN.ResetText();
                    txtTelefono.Clear();
                    txtDic.Clear();
                    txtResponsable.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show("Error al borrar registro", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNIE.Clear();
                txtNom.Clear();
                txtApell.Clear();
                dTDFechaN.ResetText();
                txtTelefono.Clear();
                txtDic.Clear();
                txtResponsable.Clear();
            }

        }
        /// <summary>

        /// </summary>
       

    }
}
