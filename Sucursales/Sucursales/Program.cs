using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sucursales
{
    class Program
    {
        static void Main(string[] args)
        {
            Banco banco = new Banco();
            Console.WriteLine("Un banco fue creado.\n");
            Console.WriteLine("Creando una sucursal.\n");
            Sucursales sucursal = new Sucursales();
            while (true)
            {
                Console.WriteLine("Cree sus oficinas: \n");
                Console.WriteLine("---------------------------------------------\n");
                Console.WriteLine("Ingrese e para crear una Oficina Estandar\n");
                Console.WriteLine("Ingrese g para crear una Oficina Gerencial\n");
                Console.WriteLine("Ingrese s para crear una Oficina de Seguridad\n");
                Console.WriteLine("Si desea ver sus oficinas actuales ingrese 1 \n");
                Console.WriteLine("Si decea salir ingrese el 0 \n");
                Console.WriteLine("---------------------------------------------\n");
                string input = Console.ReadLine();
                char c = input[0];
                Console.WriteLine();
                if (c == '0') { break; }
                if((c == 'g' || c == 'e' || c == 's'))
                {
                    
                    sucursal.crearOficina(c);
                    Console.WriteLine("Oficina creada correctamente. \n");
                    Console.WriteLine();
                }
                else
                {

                    sucursal.crearOficina(c);
                    Console.WriteLine("Codigo de oficina incorecto. Intente nuevamente. \n");
                    Console.WriteLine();
                }
                if (c == '1')
                {
                    Console.WriteLine();
                    Console.WriteLine("Usted tiene : ");
                    sucursal.imprimirLista();
                    Console.WriteLine();
                    Console.WriteLine();

                }
                
                Console.WriteLine();


            }
            Environment.Exit(0);
        }
    }
}
