using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tiendaOnline
{
    class Empresa
    {
        public void identificarTarjeta(Tarjeta tarjeta)
        {
            if (tarjeta.getEmpresa() == "VISA")
            { 
                Visa card = new Visa();
                card.Cobrar(tarjeta);
            }
            else
            {
                MasterCard card = new MasterCard();
                card.Cobrar(tarjeta);
            }
            
        }
    }
}
