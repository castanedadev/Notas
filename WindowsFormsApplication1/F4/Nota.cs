using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApplication1.F4
{
    class Nota
    {
        SqlConnection conn;

        private int Idmateria;
        private string materia;
        private double[] nota;
        private double pFinal;
        private bool aprobada;
        public Nota()
        {
            conn = ConexionRepositorio.Cnn();

            Idmateria = 0;
            materia = "";
            nota = new double[3];
            pFinal=0;
            aprobada = true;

        }


        public string Materia
        {
            get { return materia; }
            set { materia = value; }
        
        }
        public double[] Notas
        {
            get { return nota; }
            set { nota = value; }
        
        }
        public int IdMateria
        {
            get { return Idmateria; }
            set { Idmateria = value; }
        }
        public double PFinal
        {
            get { return pFinal; }
            set { pFinal = value; }
        
        }
        public bool Aprobada
        {
            get { return aprobada; }
            set { aprobada = value; }
        
        }


        public void GetPromedioFinal()
        {
            for (int i = 0; i < Notas.Length; i++)
            {
                PFinal += Notas[i];
            }

            PFinal = Math.Round((PFinal/3), 2);

            if (PFinal < 6)
            {
                Aprobada = false;
            }
        
        
        }


        public void GetMateria()
        {

            string temp = "SELECT Materia FROM MATERIA WHERE IdMateria=" + IdMateria;
            SqlConnection temp1 = ConexionRepositorio.Cnn();
            SqlCommand temp2 = new SqlCommand(temp, temp1);
            temp1.Open();
            SqlDataReader temp3 = temp2.ExecuteReader();
        
            while (temp3.Read())
            {
                Materia = temp3["Materia"].ToString().Trim();

            }
        }


        

    }
}
