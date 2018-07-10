using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Historial
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario usuarioActual = null;
            ConsoleKeyInfo input;
            Usuario usuario1 = new Usuario("1001");
            Usuario usuario2 = new Usuario("2202");
            Usuario usuario3 = new Usuario("3004");
            List<Boton> botones = new List<Boton>();
            botones.Add(new Boton("boton_opcion_1"));
            botones.Add(new Boton("boton_opcion_2"));
            botones.Add(new Boton("boton_opcion_3"));
            botones.Add(new Boton("boton_opcion_4"));

            inicio:
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("- Ejercicio Historial - En Casa Compilaba -");
            Console.WriteLine("");
            Console.WriteLine("1) Usar Usuario 1.");
            Console.WriteLine("2) Usar Usuario 2.");
            Console.WriteLine("3) Usar Usuario 3.");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("(El log se encuentra en C:/Logs/HistorialLog.txt)");
            Console.WriteLine("Pulse ESC para salir");
            Console.ResetColor();

            input = Console.ReadKey();
            if (input.Key == ConsoleKey.Escape) Environment.Exit(0);
            switch (input.Key)
            {
                case ConsoleKey.D1:
                    usuarioActual = usuario1;
                    goto panel;
                case ConsoleKey.D2:
                    usuarioActual = usuario2;
                    goto panel;
                case ConsoleKey.D3:
                    usuarioActual = usuario3;
                    goto panel;
                default:
                    goto inicio;                   

            }

            panel:
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("- Loggeado como Usuario ID: {0} - Presione ESC para volver.", usuarioActual.IdUsuario);
            Console.WriteLine("");
            Console.WriteLine("1) Opcion 1");
            Console.WriteLine("2) Opcion 2");
            Console.WriteLine("3) Opcion 3");
            Console.WriteLine("4) Opcion 4");
            Console.WriteLine("");
            Console.Write("Seleccione una Opcion: ");
            input = Console.ReadKey();
            Console.WriteLine("");
            while (input.Key != ConsoleKey.Escape)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                switch (input.Key)
                {
                    case ConsoleKey.D1:
                        usuarioActual.TocarBoton(botones[0]);
                        Console.WriteLine("Opcion 1 Ejecutada. Revise su log");
                        Console.WriteLine("");
                        break;
                    case ConsoleKey.D2:
                        usuarioActual.TocarBoton(botones[1]);
                        Console.WriteLine("Opcion 2 Ejecutada. Revise su log");
                        Console.WriteLine("");
                        break;
                    case ConsoleKey.D3:
                        usuarioActual.TocarBoton(botones[2]);
                        Console.WriteLine("Opcion 3 Ejecutada. Revise su log");
                        Console.WriteLine("");
                        break;
                    case ConsoleKey.D4:
                        usuarioActual.TocarBoton(botones[3]);
                        Console.WriteLine("Opcion 4 Ejecutada. Revise su log");
                        Console.WriteLine("");
                        break;
                    default:
                        Console.ResetColor();                        
                        Console.WriteLine("Tiene que elegir entre las opciones dadas.");
                        Console.WriteLine("");                        
                        break;

                }
                Console.ResetColor();
                Console.Write("Seleccione una opcion: ");
                input = Console.ReadKey();
                Console.WriteLine("");
            }
            usuarioActual = null;
            goto inicio;
        }
    }
}
