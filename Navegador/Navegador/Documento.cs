using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Navegador
{
    class Documento
    {
        NavegadorWeb web;//= new NavegadorWeb();
        Extension extension;
        public Documento(NavegadorWeb _web, Extension _extension)
        {
            web = _web;
            extension = _extension;
        }
        public void abrirEnWeb()
        {

            bool tengoLaExtencion = web.ExtensionesDisponibles().Contains(extension);
            if (tengoLaExtencion)
            {
                extension.Abrir();
            }
            else { Console.WriteLine("Este documento tiene una extension desconocida"); }
        }
    }
}
