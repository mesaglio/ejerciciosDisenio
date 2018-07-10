using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Historial
{
    class Boton
    {
        public string Name { get; set; }

        public Boton(string nombre)
        {
            Name = nombre;
        }

        public void OnClick(string usuario)
        {
            Historial.Instancia.Log(usuario, Name);
        }
    }
}
