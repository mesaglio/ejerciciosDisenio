using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bateria.Clases;
using System.Windows.Input;

namespace Bateria
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            ConsoleKeyInfo input;
            BateriaSubject unaBateria = new BateriaSubject();
            CargaInfo cargaInfo = new CargaInfo(unaBateria);
            TiempoInfo tiempoInfo = new TiempoInfo(unaBateria);

            inicio:
            Console.Clear();            
            Console.WriteLine("");
            Console.WriteLine("- Ejercicio Bateria - En Casa Compilaba -");
            Console.WriteLine("");
            Console.WriteLine("1) Ver Bateria Actual");
            Console.WriteLine("2) Cambiar Valores de la Bateria");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("(Para ver funcionar el patron observer cambie los valores de la bateria)");
            Console.WriteLine("Pulse ESC para salir");
            Console.ResetColor();

            input = Console.ReadKey();
            if (input.Key == ConsoleKey.Escape) Environment.Exit(0);
            switch (input.Key)
            {
                case ConsoleKey.D1:
                    Console.Clear();
                    Console.WriteLine("");
                    Console.WriteLine("- Estado Actual de la Bateria - Presione cualquier tecla para volver.");
                    Console.WriteLine("");
                    Console.WriteLine("Estado Conectado: {0}", unaBateria.Conectado);
                    Console.WriteLine("Estado Cargando: {0}", unaBateria.Cargando);
                    Console.WriteLine("Carga: {0}", unaBateria.Carga);
                    Console.WriteLine("Tiempo: {0}", unaBateria.Tiempo);                                        
                    Console.ReadKey();
                    goto inicio;                    
                case ConsoleKey.D2:
                    Console.Clear();
                    Console.WriteLine("");
                    Console.WriteLine("- Cambiar valores de la Bateria - Presione ESC para volver");
                    Console.WriteLine("");
                    Console.WriteLine("1) Conectar/Desconectar");
                    Console.WriteLine("2) Enchufar/Desenchufar");
                    Console.WriteLine("3) Setear Carga");
                    Console.WriteLine("4) Setear Tiempo");                    
                    Console.WriteLine("");
                    Console.Write("Seleccione una Opcion: ");
                    input = Console.ReadKey();
                    Console.WriteLine("");
                    while (input.Key != ConsoleKey.Escape)
                    {
                        switch (input.Key)
                        {
                            case ConsoleKey.D1:
                                Console.ForegroundColor = ConsoleColor.Green;
                                unaBateria.Conectado = !unaBateria.Conectado;
                                Console.WriteLine("");                                
                                break;
                            case ConsoleKey.D2:
                                Console.ForegroundColor = ConsoleColor.Green;
                                unaBateria.Cargando = !unaBateria.Cargando;
                                Console.WriteLine("");                                
                                break;
                            case ConsoleKey.D3:                                
                                Console.Write("Carga: ");
                                if (Int32.TryParse(Console.ReadLine(), out x) != false)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    unaBateria.Carga = x;
                                }
                                else
                                {
                                    Console.WriteLine("Tiene que ser un numero..");
                                }
                                Console.WriteLine("");                                
                                break;
                            case ConsoleKey.D4:                                
                                Console.Write("Tiempo: ");                                
                                if (Int32.TryParse(Console.ReadLine(), out x) != false)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    unaBateria.Tiempo = x;
                                }
                                else
                                {
                                    Console.WriteLine("Tiene que ser un numero..");
                                }
                                Console.WriteLine("");                                
                                break;                            
                            default:                                
                                Console.WriteLine("Tiene que elegir entre las opciones dadas.");
                                Console.WriteLine("");                                
                                break;
                        }
                        Console.ResetColor();
                        Console.Write("Seleccione una opcion: ");
                        input = Console.ReadKey();
                        Console.WriteLine("");
                    }
                    goto inicio;
                default:
                    goto inicio;
                    
            }

        }
    }
}
