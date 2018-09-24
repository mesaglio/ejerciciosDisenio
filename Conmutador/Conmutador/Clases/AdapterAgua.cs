using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conmutador.Clases
{
	class AdapterAgua : Conmutador
	{
		private ControladorDeAgua controlador;

		public AdapterAgua(ControladorDeAgua controlador) => this.controlador = controlador;

		public override void Activar()
		{
			controlador.Abrir();
		}

		public override void Desactivar()
		{
			controlador.Cerrar();
		}
	}
}
