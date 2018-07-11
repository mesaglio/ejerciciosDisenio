using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Navegador
{
    class Documento
    {
        public Extension extension;
        public string nombre;
        public Documento(String _nombre, Extension _extension)
        {
            nombre = _nombre;
            extension = _extension;
        }
        public void abrirEnWeb(NavegadorWeb web)
        {
            if (webTieneMiExtension(web))
            {
                extension.Abrir();
            }
            else
            {
                Console.WriteLine("El documento {0} tiene una extension desconocida.\n", this.nombre);
            }
        }
        public bool webTieneMiExtension(NavegadorWeb web)
        {
            return web.extensiones.Contains(this.extension);
        }
    }
}
