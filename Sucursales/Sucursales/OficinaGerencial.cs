using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sucursales
{
    class OficinaGerencial : ProtoOficina
    {
        public OficinaGerencial(int escri, bool ventana, int perso)
        {
            cantidadDeEscritorio = escri;
            tieneVentanas = ventana;
            cantidadDePersonas = perso;
        }
        public override ProtoOficina clonar()
        {
            OficinaGerencial ofi = new OficinaGerencial(2,true,2);
            return ofi;
        }
    }
}
