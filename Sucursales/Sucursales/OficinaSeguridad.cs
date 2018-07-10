using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sucursales
{
    class OficinaSeguridad : ProtoOficina
    {
        public OficinaSeguridad(int escri, bool ventana, int perso)
        {
            cantidadDeEscritorio = escri;
            tieneVentanas = ventana;
            cantidadDePersonas = perso;
        }
        public override ProtoOficina clonar()
        {
            OficinaSeguridad ofi = new OficinaSeguridad(1, true, 3);
            return ofi;
        }
    }
}
