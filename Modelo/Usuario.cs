using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Asistencia_Personal.Modelo
{
    internal class Usuario
    {
        private string identificacionpersonal;
        private string tipo;
        private string contrasenna;
        private string nombre;

        public Usuario() { }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string IdentificacionPersonal
        {
            get { return identificacionpersonal;}
            set { identificacionpersonal = value;}
        }

        public string Tipo
        {
            get { return tipo;}
            set { tipo = value;}
        }

        public string Contrsenna
        {
            get { return contrasenna;}
            set { contrasenna = value;}
        }


    }
}
