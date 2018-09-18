using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tallerMecanico
{
    class Program
    {
        static void Main(string[] args)
        {


            while (true)
            {
                Kit cambioAceite = new Kit(3, "KIT :aceite pegajoso", 9647, 100);
                cambioAceite.Add(new Pieza(150, "Aceite", 145, 20));
                cambioAceite.Add(new Pieza(200, "Tapa", 729, 50));
                cambioAceite.Add(new Pieza(300, "Filtro de aceite", 911, 30));

                Kit pegajosos = new Kit(3, "KIT :pegajoso", 9555, 10);
                pegajosos.Add(new Pieza(10, "Cinta", 1, 1));
                pegajosos.Add(new Pieza(10, "Pegamento", 1, 1));
                pegajosos.Add(new Pieza(10, "Cinta", 1, 1));

                cambioAceite.Add(pegajosos);

                Pieza tuerca = new Pieza(10, "Tuerca", 1, 1);
                Pieza tornillos = new Pieza(10, "Tornillo", 1, 1);

                Taller reparacion = new Taller("Reparacion para choque de auta nivel 2");
                reparacion.Add(cambioAceite);
                reparacion.Add(tuerca);
                reparacion.Add(tornillos);

                Console.WriteLine("Estas en el Taller y tienes un problema en el vehiculo.\n");
                Console.WriteLine("Ingrese 1 para visualizar las  piezas.\n");
                Console.WriteLine("Ingrese 2 si esta de acuerdo para proceder a facturar.\n");
                string input = Console.ReadLine();
                if (input != "1" && input != "2")
                {
                    Console.WriteLine();
                    Console.WriteLine("Comando desconocido. Vuelva a intentarlo. \n");
                    Console.WriteLine("\n");

                }
                if (input == "1") 
                {
                    Console.WriteLine();
                    Console.WriteLine("La reparacion {0} tiene las siguientes piezas\n",reparacion.Name);
                    Console.WriteLine("NOMBRE               PRECIO    \n");
                    reparacion.Display();
                    Console.WriteLine();
                   
                }
                if (input == "2") //agrego ext
                {
                    Console.WriteLine();
                    //Console.WriteLine("{0} \n", reparacion.nombre);

                    reparacion.Facturar();
                    Console.WriteLine();

                }

            }
        }
    }
}

