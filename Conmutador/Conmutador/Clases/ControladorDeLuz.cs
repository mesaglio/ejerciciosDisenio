using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conmutador.Clases
{
	class ControladorDeLuz
	{
		private bool estado;

		public ControladorDeLuz() => estado = false;

		public void Encender()
		{
			if (estado)
			{
				Console.WriteLine("[La Luz ya esta Encendida.]");
				return;
			}

			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine(" - LUZ ENCENDIDA -");
			Console.ResetColor();
			estado = true;			
		}

		public void Apagar()
		{
			if (!estado)
			{
				Console.WriteLine("[La Luz ya esta Apagada.]");
				return;
			}

			Console.ForegroundColor = ConsoleColor.DarkGray;
			Console.WriteLine(" - LUZ APAGADA -");
			Console.ResetColor();
			estado = false;
		}
	}
}
