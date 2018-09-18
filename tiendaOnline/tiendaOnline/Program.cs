using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tiendaOnline
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario cliente = new Usuario();
            string input = "a";

            Console.Clear();
            while ( input[0] != 'q') { 
            Console.WriteLine("Ingrece el numero de su tarjeta:");
            input = Console.ReadLine();
            Empresa losotro = new Empresa();
            Tarjeta tarjeta = cliente.ObtenerTarjeta(input);
            losotro.identificarTarjeta(tarjeta);
            Console.WriteLine("se cobro de su tarjeta " + tarjeta.getEmpresa());
            Console.WriteLine("presione la tecla q para salir o cualquier tecla pasa seguir");
                input = Console.ReadLine();
            }

        }
    }
}
