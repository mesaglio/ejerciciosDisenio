using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobiliario
{
    class Kit
    {
        public Kit (int _codigo)
        {
            codigo = _codigo;
        }
        public List<Elemento> elementos = new List<Elemento>();
        public void agregarElemento(Elemento elem)
        {
            elementos.Add(elem);
        }
        public double precio;
        public int codigo;
        public double calcularPrecio()
        {
            double _precio = elementos.Sum(elem => elem.calcularPrecio() * 0.90);
            precio = _precio;
            return precio;
        }
    }
}
