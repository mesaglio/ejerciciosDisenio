using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bateria.Clases
{
    class CargaInfo : Observador
    {
        private BateriaSubject observado;
        private int carga;
        private bool estado;

        public CargaInfo(BateriaSubject obs)
        {
            observado = obs;
            observado.AgregarObservador(this);
        }

        public override void Actualizar()
        {
            if (estado != observado.Cargando)
            {
                estado = observado.Cargando;
                if (estado) Console.WriteLine("[Soy un observador de carga! La bateria esta cargandose]");
                else Console.WriteLine("[Soy un observador de carga! La bateria no esta cargandose]");
            }
            if (carga != observado.Carga)
            {
                carga = observado.Carga;
                Console.WriteLine("[Soy un observador de carga! La carga de la bateria es del: {0}%]", carga);
            }
        }
    }
}
