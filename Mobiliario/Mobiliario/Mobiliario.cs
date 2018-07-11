using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobiliario
{
    class Mobiliario
    {
        public List<Kit> kits = new List<Kit>();
        public List<ElementoSimple> elemSimples = new List<ElementoSimple>();

        public void agregarKit(Kit _kit)
        {
            kits.Add(_kit);
        }
        public void agregarElementoSimple(ElementoSimple elem)
        {
            elemSimples.Add(elem);
        }
        public double venderKit()
        {
            return kits.Sum(kit => kit.calcularPrecio());
        }
        public double venderElementosSimples()
        {
            return elemSimples.Sum(elemento => elemento.calcularPrecio());
        }
    }
}
