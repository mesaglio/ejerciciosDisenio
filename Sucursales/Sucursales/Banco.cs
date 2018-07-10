using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sucursales
{
    class Banco
    {
        public List<Sucursales> sucursales = new List<Sucursales>();

        public void cargarSucursal(Sucursales sucu)
        {
            sucursales.Add(sucu);
        }

    }
}
