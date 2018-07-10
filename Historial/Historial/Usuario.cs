using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Historial
{
    class Usuario
    {
        public string IdUsuario { get; set; }

        public Usuario(string id)
        {
            IdUsuario = id;
        }

        public void TocarBoton(Boton boton)
        {
            boton.OnClick(IdUsuario);
        }
    }
}
