using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarjetaDeCredito
{
    class Normal : State
    {
        public override Boolean tieneLimite(int monto)
        {
            return true;
        }
    }
}
