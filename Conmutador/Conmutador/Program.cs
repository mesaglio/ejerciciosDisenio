using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Conmutador.Clases;

namespace Conmutador
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.CursorVisible = false;
			ConsoleKeyInfo input;
			ControladorDeAgua agua = new ControladorDeAgua();
			ControladorDeLuz luz = new ControladorDeLuz();
			AdapterAgua aguaAdapter = null;
			AdapterLuz luzAdapter = null;			
					
			Menu();						
			input = Console.ReadKey(true);
			while (input.Key != ConsoleKey.Escape) {

				Menu();

				switch (input.Key)
				{
					case ConsoleKey.D1:
						if (aguaAdapter == null) { Console.WriteLine("[El ControladorDeAgua no entiende el Mensaje.]"); break; }
						aguaAdapter.Activar();
						break;
					case ConsoleKey.D2:
						if (aguaAdapter == null) { Console.WriteLine("[El ControladorDeAgua no entiende el Mensaje.]"); break; }
						aguaAdapter.Desactivar();
						break;
					case ConsoleKey.D3:
						if (luzAdapter == null) { Console.WriteLine("[El ControladorDeLuz no entiende el Mensaje.]"); break; }
						luzAdapter.Activar();
						break;
					case ConsoleKey.D4:
						if (luzAdapter == null) { Console.WriteLine("[El ControladorDeLuz no entiende el Mensaje.]"); break; }
						luzAdapter.Desactivar();
						break;
					case ConsoleKey.D5:
						if (aguaAdapter != null)
						{
							Console.WriteLine("[El ControladorDeAgua ya esta Adaptado.]");
							break;
						}
						aguaAdapter = new AdapterAgua(agua);
						Console.WriteLine("[ControladorDeAgua Adaptado Satisfactoriamente.]");
						break;
					case ConsoleKey.D6:
						if (luzAdapter != null)
						{
							Console.WriteLine("[El ControladorDeLuz ya esta Adaptado.]");
							break;
						}
						luzAdapter = new AdapterLuz(luz);
						Console.WriteLine("[ControladorDeLuz Adaptado Satisfactoriamente.]");
						break;
					default:
						Console.WriteLine("[Tiene que elegir entre las opciones dadas.]");
						break;
				}

				input = Console.ReadKey(true);
			}
		}

		private static void Menu()
		{
			Console.Clear();
			Console.WriteLine("");
			Console.WriteLine("- Ejercicio Conmutador - En Casa Compilaba -");
			Console.WriteLine("");		
			Console.WriteLine("--------------------------------------------");
			Console.WriteLine("");
			Console.WriteLine("1) Activar Agua.");
			Console.WriteLine("2) Desactivar Agua.");
			Console.WriteLine("3) Activar Luz.");
			Console.WriteLine("4) Desactivar Luz.");
			Console.WriteLine("5) Adaptar Agua.");
			Console.WriteLine("6) Adaptar Luz.");
			Console.WriteLine("");
			Console.ForegroundColor = ConsoleColor.DarkGray;
			Console.WriteLine("Pulse ESC para salir");
			Console.ResetColor();
			Console.WriteLine("");
		}
		
	}
}
