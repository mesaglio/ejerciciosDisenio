using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tallerMecanico
{
    class Taller
    {
        public string Name { get; set; }
        public Taller(string _name) {
            Name = _name;
        }

        public List<Componente> _children = new List<Componente>();
        public  void Add(Componente component)
        {
            _children.Add(component);
        }

        public  void Display()
        {// Display = visualizar

            // Recursively display child nodes
            foreach (Componente c in _children)
            {
                c.Display();
            }
        }




        public void Facturar()
        {
            
            Console.WriteLine("-------- FACTURANDO -------\n");
            Console.WriteLine("NOMBRE               PRECIO    \n");
            double total = 0;
            foreach (Componente c in _children)
            {
               
                Console.WriteLine("{0}  \t  {1} \n", c.nombre,c.Precio());
                total += c.Precio();
            }
            Console.WriteLine("Total  \t {0}\n", total);

        }



    }

}


