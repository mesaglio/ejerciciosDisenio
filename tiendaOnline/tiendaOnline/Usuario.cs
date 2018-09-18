using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tiendaOnline
{
    class Usuario

    {

        public Tarjeta ObtenerTarjeta(string numero)
        {

            Tarjeta tarjeta = new Tarjeta(numero);
            return tarjeta;
        }

    }
}
