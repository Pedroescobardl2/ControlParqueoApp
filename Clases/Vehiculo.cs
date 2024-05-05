using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlParqueoApp.Clases
{
    public class Vehiculo
    {
        public string Placa { get; set; }
        public string NombrePropietario { get; set; }
        public DateTime HoraIngreso { get; set; }
        public DateTime HoraSalida { get; set; }

        public Vehiculo(string placa, string nombrePropietario, DateTime horaIngreso, DateTime horaSalida)
        {
            Placa = placa;
            NombrePropietario = nombrePropietario;
            HoraIngreso = horaIngreso;
            HoraSalida = horaSalida;
        }
    }

}
