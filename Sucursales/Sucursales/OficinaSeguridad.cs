using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sucursales
{
    class OficinaSeguridad : ProtoOficina
    {
        public OficinaSeguridad()
        {
            cantidadDeEscritorio = 1;
            tieneVentanas = true;
            cantidadDePersonas = 3;
        }
        public override ProtoOficina clonar()
        {
            return this;
        }
        public override void imprimir()
        {
            Console.WriteLine("Oficina de Seguridad");
        }
    }
}
