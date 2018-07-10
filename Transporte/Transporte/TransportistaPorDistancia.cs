using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transporte
{
    class TransportistaPorDistancia : Transportista
    {
        public double tarifa { get; set; }
        public double otraTarifa { get; set; }

        public override abstract void cotizar(Envio envio) {
            if (envio.esLocal())
            {
                return this.tarifaLocal() * envio.paquete.peso();
            }
            return this.otraTarifa() * envio.paquete.peso();
        }



    }

}