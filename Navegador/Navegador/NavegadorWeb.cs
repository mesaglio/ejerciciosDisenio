
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Navegador

{
    class NavegadorWeb
    {
        public List<Extension> extensiones = new List<Extension>();

        public void agregarExtencion(Extension extension)
        {
            extensiones.Add(extension);
        }

        public List<Extension> ExtensionesDisponibles()
        {
            return extensiones;
        }
    }

    

    

    
    
}
