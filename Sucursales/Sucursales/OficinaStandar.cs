using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sucursales
{
    class OficinaStandar : ProtoOficina
    {
        public OficinaStandar()
        {
            cantidadDeEscritorio = 4;
            tieneVentanas = false;
            cantidadDePersonas = 4;
        }
        public override ProtoOficina clonar()
        {

            return this;
        }
        public override void imprimir()
        {
            Console.WriteLine("Oficina Estandar");
        }
    }
}
