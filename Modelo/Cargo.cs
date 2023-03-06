using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Asistencia_Personal.Modelo
{
    internal class Cargo
    {
        private string nombrecargo;
        private float sueldoporhora;
        private int id;

        public Cargo() { }
        public string Nombrecargo
        {
            get { return nombrecargo; }
            set { nombrecargo = value; }
        }

        public float SueldoHora
        {
            get { return sueldoporhora; }
            set { sueldoporhora = value; }
        }

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

    }
}
