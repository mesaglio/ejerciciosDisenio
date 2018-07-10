using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sucursales
{
    abstract class ProtoOficina
    {
        
        public int cantidadDeEscritorio;
        public bool tieneVentanas;
        public int cantidadDePersonas;

        public abstract ProtoOficina clonar();
        public abstract void imprimir();

    }
}
