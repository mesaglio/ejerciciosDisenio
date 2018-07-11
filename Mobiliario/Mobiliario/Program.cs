using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobiliario
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo input;
            Mobiliario mobiliario = new Mobiliario();
            Kit kit = new Kit(1);

            ElementoSimple martillo = new ElementoSimple(100, 1);
            ElementoSimple destornillador = new ElementoSimple(200, 1);
            kit.agregarElemento(martillo);
            kit.agregarElemento(destornillador);
            mobiliario.agregarElementoSimple(martillo);
            mobiliario.agregarElementoSimple(destornillador);
            mobiliario.agregarKit(kit);
            while (true)
            { 
                Console.WriteLine("1) Calcular el precio del kit.");
                Console.WriteLine("2) Calcular el precio de venta de los elementos simples. ");
                Console.WriteLine("3) Calcular el precio de vender todos los elementos simples. ");
                Console.WriteLine("");
                Console.WriteLine("Pulse ESC para salir");

                input = Console.ReadKey();
                if (input.Key == ConsoleKey.Escape) Environment.Exit(0);
                if (input.Key == ConsoleKey.D1)
                {
                    Console.WriteLine("\n El valor con el descuento del kit es de : {0} \n", kit.calcularPrecio());
                    
                }
                if(input.Key == ConsoleKey.D2)
                {
                    foreach (ElementoSimple elem in mobiliario.elemSimples)
                    {
                        Console.WriteLine("\n El valor de {0} es de {1}", elem.codigo, elem.precio);
                    }
                }
                if(input.Key == ConsoleKey.D3)
                {
                    Console.WriteLine("\n El valor de vender todos los elementos simples es de : {0}", mobiliario.venderElementosSimples());
                }
            }

        }
    }
}
