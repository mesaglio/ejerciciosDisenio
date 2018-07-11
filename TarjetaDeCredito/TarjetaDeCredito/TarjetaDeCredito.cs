using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarjetaDeCredito
{
    class TarjetaDeCredito
    {
        State state;

        public TarjetaDeCredito(string state)
        {
            if (state.ToLower() == "normal")
                this.state = new Normal();
            else
            {
                if (state.ToLower() == "rojo")
                     this.state = new Rojo();
              else
                     this.state = new Inhabilitada();
            }
        }

       public Boolean puedeRetirar(int monto) => state.tieneLimite(monto);
    }
}
