using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tiendaOnline
{
    class MasterCard : Empresa
    {
        public MasterCard()
        {
        }

       // public void identificarTarjeta(Tarjeta tarjeta);
  
        public int Cobrar(Tarjeta tarjeta)
        {
            return 2000;
        }

    }
}
