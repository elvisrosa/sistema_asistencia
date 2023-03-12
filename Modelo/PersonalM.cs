using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Asistencia_Personal.Modelo
{
    internal class PersonalM
    {
        public PersonalM() { }

        private string nombre;
        private string identificacion;
        private string pais;
        private int idCargo;
        private string estado;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Identificacion
        {
            get { return identificacion;  }
            set { identificacion = value; }
        }

        public string Pais
        {
            get { return pais; }
            set { pais = value; }
        }

        public string Estado
        {
            get { return estado; }
            set { estado=value; }
        }

        public int Cargo
        {
            get { return idCargo; }
            set { idCargo = value; }
        }


    }
}
