using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sucursales
{
    class OficinaStandar : ProtoOficina
    {
        public OficinaStandar(int escri,bool ventana,int perso)
        {
            cantidadDeEscritorio = escri;
            tieneVentanas = ventana;
            cantidadDePersonas = perso;
        }
        public override ProtoOficina clonar()
        {
            OficinaStandar ofi = new OficinaStandar(4, false, 4);
            return ofi;
        }
    }
}
