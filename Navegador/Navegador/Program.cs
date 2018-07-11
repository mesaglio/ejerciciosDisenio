
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Navegador

{
    class NavegadorWeb
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Estas en el navegador web");
            Console.ReadKey();
        }
        List<Extension> extensiones = new List<Extension>();

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
