using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobiliario
{
    abstract class Elemento
    {
        public double precio;
        public int codigo;
        abstract public double calcularPrecio();
    }
}
