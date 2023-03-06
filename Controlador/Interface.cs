using Sistema_Asistencia_Personal.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Asistencia_Personal.Controlador
{
    internal interface Interface<T>
    {
        T agregar(T objeto);
        void eliminar(string id);
        T actualizar(T objeto);
        List<T> obtenerTodo();
        void buscar(int codigo);


    }
}
