using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conmutador.Clases
{
	class ControladorDeAgua
	{
		public bool estado;

		public ControladorDeAgua() => estado = false;

		public void Abrir()
		{
			if (estado)
			{
				Console.WriteLine("[El agua ya esta abierta.]");
				return;
			}
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine(" - AGUA CORRIENDO -");
			Console.ResetColor();
			estado = true;
		}

		public void Cerrar()
		{
			if (!estado)
			{
				Console.WriteLine("[El agua ya esta cerrada.]");
				return;
			}
			Console.ForegroundColor = ConsoleColor.DarkGray;
			Console.WriteLine(" - AGUA CERRADA -");
			Console.ResetColor();
			estado = false;
		}
	}
}
