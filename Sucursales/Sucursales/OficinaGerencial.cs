using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sucursales
{
    class OficinaGerencial : ProtoOficina
    {
        public OficinaGerencial()
        {
            cantidadDeEscritorio = 2;
            tieneVentanas = true;
            cantidadDePersonas = 2;
        }
        public override ProtoOficina clonar()
        {
            return this;
        }
        public override void imprimir()
        {
            Console.WriteLine("Oficina Gerencial");
        }
    }
}
