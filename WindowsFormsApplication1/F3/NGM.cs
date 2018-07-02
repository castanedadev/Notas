using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.F3
{
    public class NGM
    {
        private string maestro;
        private List<int> grado;
        private List<int> materia;
        private List<int> seccion;
        private List<int> estado;
        private string año;

        public NGM()
        {
            grado = new List<int>();
            materia = new List<int>();
            seccion = new List<int>();
            estado = new List<int>();
        
        }

        public string Maestro
        {
            get { return maestro; }
            set { maestro = value; }

        }
        public List<int> Grado
        {
            get { return grado; }
            set { grado = value; }
        }
        public List<int> Materia
        {
            get { return materia; }
            set { materia = value; }
        }
        public List<int> Seccion
        {
            get { return seccion; }
            set { seccion = value; }
        }
        public List<int> Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public string Año
        {
            get { return año; }
            set { año = value; }
        }

    }
}
