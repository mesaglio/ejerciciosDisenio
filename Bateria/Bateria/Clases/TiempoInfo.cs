using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bateria.Clases
{
    class TiempoInfo : Observador
    {
        private BateriaSubject observado;
        private int tiempo;
        private bool estado;

        public TiempoInfo(BateriaSubject obs)
        {
            observado = obs;
            observado.AgregarObservador(this);
        }

        public override void Actualizar()
        {
            if(estado != observado.Conectado)
            {
                estado = observado.Conectado;
                if (estado) Console.WriteLine("[Soy un observador de tiempo! La bateria se conecto]");
                else Console.WriteLine("[Soy un observador de tiempo! La bateria se desconecto]");
            }
            if (tiempo != observado.Tiempo)
            {
                tiempo = observado.Tiempo;
                Console.WriteLine("[Soy un observador de tiempo! El tiempo restante de la bateria es de: {0} minutos]", observado.Tiempo);
            }
            
        }

    }
}
