using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tallerMecanico
{
    class Pieza : Componente
    {
        public Pieza(double _precio, string _nombre, int id, int tdi) : base(_precio, _nombre, id, tdi)
        {
        }

        public override double Precio()
        {
            return precio;
        }
        public override void Add(Componente c)
        {
            Console.WriteLine("Cannot add to a leaf");
        }

        public override void Remove(Componente c)
        {
            Console.WriteLine("Cannot remove from a leaf");
        }

        public override void Display()
        {
            Console.WriteLine("{0} \t\t {1}\n", nombre,precio);
        }
    }
}
