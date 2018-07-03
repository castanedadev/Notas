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
    public partial class DatosDocente : Form
    {
        Procesos call = new Procesos();
        private SqlConnection conectar;
        private SqlCommand cmd;
        private SqlDataAdapter adap;        
        private SqlDataReader dr;
        private String Nombre = "", Telefono = "", Direccion = "", Contra = "", ID = "";

        public DatosDocente()
        {
            InitializeComponent();
            MenuDOC cal = new MenuDOC();
            Nombre = cal.LblDOC.Text;
        }

        private void DatosDocente_Load(object sender, EventArgs e)
        {
            GetDatos();
            GetContra();                       
        }       

        private void GetContra()
        {
            conectar = Conexion.Cnn();
            String consulta = "select * from Usuarios where Usuario = '" + ID+"'";
            adap = new SqlDataAdapter(consulta, conectar);
            SqlParameter prm = new SqlParameter("Usuario", SqlDbType.VarChar);
            prm.Value = ID;
            adap.SelectCommand.Parameters.Add(prm);
            dr = adap.SelectCommand.ExecuteReader();
            while (dr.Read())
            {
                txtContra.Text = dr["Pass"].ToString().Trim();
            }
            conectar.Close(); Contra = txtContra.Text;                       
        }

        private void GetDatos()
        {
            conectar = Conexion.Cnn();
            String consulta2 = "select  IdMaestro, Fecha, Telefono, Direccion from Maestros where Nombre='" + Nombre + "'";
            adap = new SqlDataAdapter(consulta2, conectar);
            dr = adap.SelectCommand.ExecuteReader();
            while (dr.Read())
            {
                ID = dr["IdMaestro"].ToString();
                txtUsuario.Text = ID;
                txtNombre.Text = Nombre;
                txtFecha.Text = dr["Fecha"].ToString();
                txtTelefono.Text = dr["Telefono"].ToString();
                txtDireccion.Text = dr["Direccion"].ToString();
            } conectar.Close();
            Telefono = txtTelefono.Text; Direccion = txtDireccion.Text; 
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (vacio())
            {
                if (Cambios())
                {
                    if (txtContraConfirmar.Text!="")
                    {
                        if (txtTelefono.TextLength == 8)
                        {
                            if (txtContra.Text == txtContraConfirmar.Text)
                            {
                                Actualizar();
                            }
                            else MessageBox.Show("No coinciden las contraseñas\nVerficar...", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else MessageBox.Show("\tIngrese un número de telefono valido\n\tDe 8 digitos", "E R R OR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else MessageBox.Show("Ingrese la confirmacion de Contraseña", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else MessageBox.Show("Por favor llene todos los datos requeridos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Actualizar()
        {
            conectar = Conexion.Cnn();
            String consulta2 = "Update Maestros set Telefono = '" + txtTelefono.Text.Trim() + "', Direccion = '" + txtDireccion.Text.Trim() + "',Estado = 2 where IdMaestro = '" + ID + "'";
            cmd = new SqlCommand(consulta2, conectar);
            cmd.ExecuteNonQuery();
            conectar.Close();

            conectar = Conexion.Cnn();
            String consulta = "Update Usuarios set Pass = '" + txtContra.Text.Trim() + "' where Usuario = '" + ID + "'";
            cmd = new SqlCommand(consulta, conectar);
            cmd.ExecuteNonQuery();
            conectar.Close();
            MessageBox.Show("Sus datos han sido actualizados....", "ACTUALIZACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool Cambios()
        {
            if (Telefono != txtTelefono.Text || Direccion != txtDireccion.Text || Contra != txtContra.Text) return true;
            else { MessageBox.Show("No se ha realizado ningun cambio", "Proceso de Actualizacón", MessageBoxButtons.OK, MessageBoxIcon.Information); return false; }
        }

        private bool vacio()
        {
            if (txtTelefono.Text != "" && txtDireccion.Text != "" && txtContra.Text != "") return true;
            else return false;
        }

    }
}
