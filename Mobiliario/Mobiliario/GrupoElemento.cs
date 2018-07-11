using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobiliario
{
    class GrupoElemento : Elemento
    {
        public List<ElementoSimple> elementos = new List<ElementoSimple>();
        public override double calcularPrecio()
        {
            return elementos.Sum(elemento => elemento.precio);   
        }
    }
}
