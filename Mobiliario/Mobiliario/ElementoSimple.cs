using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobiliario
{
    class ElementoSimple : Elemento
    {
        public double precio;
        public int codigo;
        public ElementoSimple(double _precio, int _codigo){
            precio = _precio;
            codigo = _codigo;
        }
        public override double calcularPrecio()
        {
            return precio;
        }
    }
}
