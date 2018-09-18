using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace tallerMecanico
{
    class Kit  : Componente
    {

        public List<Componente> _children = new List<Componente>();
        public Kit(double _precio, string _nombre, int id, int tdi) : base(_precio, _nombre, id, tdi)
        {

        }

        public void agregarComponente(Componente c) { _children.Add(c); }

        public override void Add(Componente component)
        {
            _children.Add(component);
        }

        public override void Remove(Componente component)
        {
            _children.Remove(component);
        }

        public override void Display()
        {// Display = visualizar

            // Recursively display child nodes
            foreach (Componente c in _children)
            {
                c.Display();
            }
        }
    



    public override double Precio(){
            double total = 0;
            foreach (Componente c in _children)
            {
               
                total += c.Precio();
               
            }
            return total*0.9;
        }

         

    }
}
