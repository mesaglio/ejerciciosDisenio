using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPV.Clases
{
	class Terminal : Servicio
	{
		private List<Visitor> impuestos;

		public Terminal()
		{
			impuestos = new List<Visitor>();
			impuestos.Add(new ImpuestoA());
			impuestos.Add(new ImpuestoB());
		}

		public override double Accept(Visitor visitor)
		{
			return visitor.VisitTPV(this);
		}

		public double CalcularTotal(double valor)
		{
			double tax = 0;
			foreach (var v in impuestos)
			{
				tax += valor * Accept(v);
			}

			return valor + tax;
		}
	}
}
