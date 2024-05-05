using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlParqueoApp.Clases
{
    public class ListaDobleEnlazada
    {
        private Nodo primero;
        private Nodo ultimo;

        public ListaDobleEnlazada()
        {
            primero = null;
            ultimo = null;
        }

        public void InsertarAlInicio(Vehiculo vehiculo)
        {
            Nodo nuevoNodo = new Nodo(vehiculo);
            if (primero == null)
            {
                primero = nuevoNodo;
                ultimo = nuevoNodo;
            }
            else
            {
                nuevoNodo.Siguiente = primero;
                primero.Anterior = nuevoNodo;
                primero = nuevoNodo;
            }
        }

        public void InsertarAlFinal(Vehiculo vehiculo)
        {
            Nodo nuevoNodo = new Nodo(vehiculo);
            if (ultimo == null)
            {
                primero = nuevoNodo;
                ultimo = nuevoNodo;
            }
            else
            {
                nuevoNodo.Anterior = ultimo;
                ultimo.Siguiente = nuevoNodo;
                ultimo = nuevoNodo;
            }
        }

    }
}
