using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej2.Models
{
    internal class Viaje
    {
        Colectivo colectivo;
        public Viaje(int hInicio, int mInicio, int asientos)
        {
            colectivo = new Colectivo(asientos);
        }
    }
}
