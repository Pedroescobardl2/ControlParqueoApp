using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlParqueoApp.Clases
{
    public class Nodo
    {
        public Vehiculo Vehiculo { get; set; }
        public Nodo Siguiente { get; set; }
        public Nodo Anterior { get; set; }

        public Nodo(Vehiculo vehiculo)
        {
            Vehiculo = vehiculo;
            Siguiente = null;
            Anterior = null;
        }
    }

}
