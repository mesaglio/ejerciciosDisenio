using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPV.Clases
{
	abstract class Visitor
	{
		public Visitor() { }

		public abstract double VisitTPV(Terminal tpv);
	}
}
