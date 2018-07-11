
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

    abstract class Extension
    {
        abstract public void Abrir();
    }

    class Visio : Extension
    {
        public override void Abrir() { }
    }
    class Pdf : Extension
    {
        public override void Abrir() { }
    }
}
