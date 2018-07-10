using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transporte
{
    class TransportistaPorPeso : Transportista
    {
        public double tarifa { get; set; }
        public abstract override void cotizar(Envio envio) {
            return tarifa * envio.paquete.peso();
        }



    }

}