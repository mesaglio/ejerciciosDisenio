using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Navegador
{
    class Programa
    {
        static void Main(string[] args)
        {
            //creo las extensiones habilitadas para el navegador
            Pdf extPdf = new Pdf();
            Visio extVisio = new Visio();
            Photoshop extPhoto = new Photoshop();
            NavegadorWeb web = new NavegadorWeb(); //creo el singleton del navegador web
            //agrego las extensiones al navegador
            //web.agregarExtencion(extPdf);
            //web.agregarExtencion(extPhoto);
            //web.agregarExtencion(extVisio);
            //navegador cargado

            Documento documentoPdf = new Documento("formulario.pdf",extPdf);
            Documento documentoPhoto = new Documento("plano3.PSD",extPhoto);
            Documento documentoVisio = new Documento("diagrama.vsdx",extVisio);
            while (true) {
                Console.WriteLine("Estas en el navegador web.\n");
                Console.WriteLine("Ingrese 1 para abrir los documentos.\n");
                Console.WriteLine("Ingrese 2 para agregar extenciones.\n");
                string input = Console.ReadLine();
                if (input != "1" && input != "2")
                {
                    Console.WriteLine("Comando desconocido. Vuelva a intentarlo. \n");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                }
                if (input == "1") //abro todas
                {
                    Console.WriteLine("Usted tiene los siguientes archivos: {0}, {1}, {2} \n", documentoPdf.nombre, documentoPhoto.nombre, documentoVisio.nombre);
                    Console.WriteLine("Abriendo todos los archivos: \n");
                    documentoPdf.abrirEnWeb(web);
                    documentoPhoto.abrirEnWeb(web);
                    documentoVisio.abrirEnWeb(web);

                }
                if(input == "2") //agrego ext
                {
                    Boolean esc = true;
                    while (esc)
                    {
                        
                        Console.WriteLine("Usted esta agregando extensiones.\n");
                        Console.WriteLine("---------------------------------\n");
                        Console.WriteLine("Ingrese 1 para agregar una extension Visio.\n");
                        Console.WriteLine("Ingrese 2 para agregar una extension Pdf.\n");
                        Console.WriteLine("Ingrese 3 para agregar una extension Photoshop.\n");
                        Console.WriteLine("Ingrese 4 para volver al navegador .\n");
                        Console.WriteLine();
                        Console.WriteLine();
                        string entrada = Console.ReadLine();

                        int entry = Int32.Parse(entrada);
                        
                        switch (entry) {
                        
                            case 1:
                                web.agregarExtencion(extVisio);
                                Console.WriteLine("La extension Visio se agrego correctamente. \n");
                                break;
                            case 2:
                                web.agregarExtencion(extPdf);
                                Console.WriteLine("La extension Pdf se agrego correctamente. \n");
                                break;
                            case 3:
                                web.agregarExtencion(extPhoto);
                                Console.WriteLine("La extension Photoshop se agrego correctamente. \n");
                                break;
                            case 4:
                                esc = false;
                                break;
                        }

                    }
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();


                }
                
            }
        }
    }
}
