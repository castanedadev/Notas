using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class PropiedadMaestro
    {
        private string idMaestro;
        private string nombre;
        private string fecha;
        private string telefono;
        private string direccion;
        private int tutor;
        private int grado;
        private int seccion;
        private int estado;


        public string IdMaestro
        {
            get { return idMaestro; }
            set { idMaestro = value; }

        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        public int Grado
        {
            get { return grado; }
            set { grado = value; }
        }
        public int Seccion
        {
            get { return seccion; }
            set { seccion = value; }
        }
        public int Estado
        {
            get { return estado; }
            set { estado = value; }
        }
        public int Tutor
        {
            get { return tutor; }
            set { tutor = value; }
        }




    }
}
