using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bateria.Clases
{
    class BateriaSubject : Observado
    {
        private bool conectado, cargando;
        private int carga, tiempo;
        
        public BateriaSubject() :base()
        {
            conectado = false;
            cargando = false;
            carga = 0;
            tiempo = 0;
        }

        public int Carga
        {
            get => carga;
            set
            {
                carga = value;
                Notificar();
            }
        }

        public int Tiempo
        {
            get => tiempo;
            set
            {
                tiempo = value;
                Notificar();
            }
        }

        public bool Conectado
        {
            get => conectado;
            set
            {
                conectado = value;
                Notificar();
            }
        }

        public bool Cargando
        {
            get => cargando;
            set
            {
                cargando = value;
                Notificar();
            }
        }

        public override void Notificar()
        {
            foreach (Observador obs in observadores)
            {
                obs.Actualizar();
            }
        }
    }
}
