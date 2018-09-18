using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPV.Clases
{
	abstract class Servicio
	{
		public Servicio() { }

		public abstract double Accept(Visitor visitor);
	}
}
