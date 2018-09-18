using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPV.Clases
{
	class ImpuestoB : Visitor
	{
		public ImpuestoB() { }

		public override double VisitTPV(Terminal tpv)
		{
			return 0.034;
		}
	}
}
