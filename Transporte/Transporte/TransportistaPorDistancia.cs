using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transporte
{
    class TransportistaPorDistancia : Transportista
    {
        public double tarifaLocal { get; set; }
        public double otraTarifa { get; set; }

        public override double cotizar(Envio envio) {
            if (envio.esLocal())
            {
                return tarifaLocal * envio.paquete.peso;
            }
            return this.otraTarifa * envio.paquete.peso;
        }



    }

}