using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPV.Clases;


namespace TPV
{
	class Program
	{
		static void Main(string[] args)
		{
			string input;
			Terminal tpv = new Terminal();
		
			Console.Clear();
			Console.WriteLine("");
			Console.WriteLine("- Ejercicio TPV - En Casa Compilaba -");
			Console.WriteLine("");
			Console.ForegroundColor = ConsoleColor.DarkGray;
			Console.WriteLine("Escriba exit para salir");
			Console.ResetColor();
			Console.WriteLine("");
			Console.WriteLine("Inserte un Precio para calcular su total.");
			Console.WriteLine("");
			Console.Write("Precio: ");
			input = Console.ReadLine();
			while (input != "exit")
			{				
				if (Double.TryParse(input, out double x) != false)
				{
					Console.ForegroundColor = ConsoleColor.Green;
					Console.WriteLine(String.Format("Total = {0}", tpv.CalcularTotal(x)));
					Console.ResetColor();
				}
				else
				{
					Console.WriteLine("Tiene que ser un numero..");
				}
				Console.WriteLine("");
				Console.Write("Ingrese otro precio: ");
				input = Console.ReadLine();
			}
		}
	}
}
