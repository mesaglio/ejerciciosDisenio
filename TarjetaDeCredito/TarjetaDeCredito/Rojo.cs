using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarjetaDeCredito
{
    class Rojo : State
    {
        int limite = 1000;


        public override Boolean tieneLimite(int monto)
        {
            return (monto < limite);
        }
    }
}
