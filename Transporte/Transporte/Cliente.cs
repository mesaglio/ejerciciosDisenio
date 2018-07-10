using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transporte
{

    public class Cliente
    {
        public string nombre { set; get; }
        public int id { set; get; }

        private List<Envio> envios = new List<Envio>();



    }
}
