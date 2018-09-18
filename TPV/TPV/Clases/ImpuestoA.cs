using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPV.Clases
{
	class ImpuestoA : Visitor
	{
		public ImpuestoA() { }

		public override double VisitTPV(Terminal tpv)
		{
			return 0.125;
		}
	}
}
