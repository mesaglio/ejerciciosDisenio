using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transporte
{
    abstract class Transportista
    {
        abstract public double cotizar(Envio envio);
        public string nombre;


    }

}