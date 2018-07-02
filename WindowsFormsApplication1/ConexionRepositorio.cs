using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace WindowsFormsApplication1
{
    class ConexionRepositorio
    {
        public static SqlConnection Cnn()
        {
            string cadena = "server=(localdb)\\Escuelas;pwd=;uid=;database=Repositorio";
            SqlConnection conn = new SqlConnection(cadena);
             return conn;

        }
    }
}
