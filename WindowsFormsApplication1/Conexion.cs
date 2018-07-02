using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    class Conexion
    {
        public static SqlConnection Cnn()
        {
            string cadena = "server=(localdb)\\Escuelas;pwd=;uid=;database=Escuela";
            SqlConnection conn = new SqlConnection(cadena);
            conn.Open();
            return conn;
       
        }
    }
}
