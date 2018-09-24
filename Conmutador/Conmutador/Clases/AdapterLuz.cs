using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conmutador.Clases
{
	class AdapterLuz : Conmutador
	{
		private ControladorDeLuz controlador;

		public AdapterLuz(ControladorDeLuz controlador) => this.controlador = controlador;

		public override void Activar()
		{
			controlador.Encender();
		}

		public override void Desactivar()
		{
			controlador.Apagar();
		}
	}
}
