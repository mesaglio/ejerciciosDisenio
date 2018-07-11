using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarjetaDeCredito
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean exit = true;
            Boolean back = true;
            char first;
            char first2;
            string input;
            string input2;
            TarjetaDeCredito visa = new TarjetaDeCredito("normal");
            Console.WriteLine("Tarjeta de Credito creada visa estado normal");

            TarjetaDeCredito master = new TarjetaDeCredito("inhabilitada");
            Console.WriteLine("Tarjeta de Credito creada master estado inhabilitada ");

            TarjetaDeCredito american = new TarjetaDeCredito("rojo");
            Console.WriteLine("Tarjeta de Credito creada american estado rojo ");

        


            while (exit)
            {
                Console.WriteLine("ingrese la primera letra de la tarjeta que quiere gestionar \n V para Visa\n M para master\n A para american \n precione Q para salir\n ");
                input = Console.ReadLine();
                input.ToLower();
                first = input[0];
                if (first == 'q')
                    exit = false;
                else
                {
                    back = true;
                    while (back)
                    {
                        Console.WriteLine("Ingrese el monto a retirar, para volver al menu principal precione 0");
                        input2 = Console.ReadLine();
                        first2 = input[0];
                        if (Convert.ToInt32(input2) == 0)
                            back = false;
                        else
                        {
                            if (first == 'v')
                                Console.WriteLine( visa.puedeRetirar(Convert.ToInt32(input2)));
                            else
                            {
                                if (first == 'm')
                                    Console.WriteLine( master.puedeRetirar(Convert.ToInt32(input2)));
                                else
                                {
                                    if (first == 'a')
                                        Console.WriteLine(american.puedeRetirar(Convert.ToInt32(input2)));
                                    else
                                        back = false;
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
