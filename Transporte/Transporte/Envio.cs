using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transporte
{
    class Envio
    {
        public Transportista transportista { get; set; }
        public Paquete paquete { get; set; }
        public double precio { get; set; }
        public int distancia { get; set; } //0 Local,1 LargaDistancia
        public string descripcion { get; set; }

        public void calcularEnvio()
        {
            precio = transportista.cotizar(this);
        }

		public bool esLocal()
        {
            return distancia == 0;
        }


    }
}