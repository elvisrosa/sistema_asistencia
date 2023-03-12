using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Asistencia_Personal.Modelo
{
    internal class Asistencia
    {
        private int idasistencia;
        private DateTime horaentrada;
        private DateTime horasalida;
        private string identificacionpersona;
        private string observacion;
        private float hora;
        private string estado;
        private DateTime fecha;

        public Asistencia()
        {
        }

        public int Id_Asistencia
        {
            get { return idasistencia; }
            set { idasistencia = value; }
        }

        public DateTime Hora_entrada
        {
            get { return horaentrada; }
            set { horaentrada = value; }
        }

        public DateTime Hora_salida
        {
            get { return horasalida; }
            set { horasalida = value; }
        }

        public string Identificacion_persona
        {
            get { return identificacionpersona; }
            set { identificacionpersona = value; }
        }

        public string Observacion
        {
            get { return observacion; }
            set { observacion = value; }
        }

        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public float Hora
        {
            get { return hora; }
            set { hora = value; }
        }

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha=value; }
        }
    }

}
