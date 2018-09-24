using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conmutador.Clases
{
	abstract class Conmutador
	{
		public Conmutador() { }

		public abstract void Activar();
		public abstract void Desactivar();
	}
}
