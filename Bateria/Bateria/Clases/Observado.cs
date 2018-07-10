using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bateria.Clases
{
    abstract class Observado
    {
        protected List<Observador> observadores = new List<Observador>();

        public Observado()
        {
        }

        public void AgregarObservador(Observador unObservador)
        {
            observadores.Add(unObservador);
        }

        public void QuitarObservador(Observador unObservador)
        {
            observadores.Remove(unObservador);
        }

        public abstract void Notificar();
    }
}
