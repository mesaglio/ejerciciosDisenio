using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tallerMecanico
{
    abstract class Componente
    {
        public double precio { get; set; }
        public string nombre { get; set; }
        public int numero { get; set; }
        public int tiempoInstalacion{ get; set; }

       

        public Componente(double _precio, string _nombre,int id,int tdi)
        {
            precio = _precio;
            nombre = _nombre;
            numero = id;
            tiempoInstalacion = tdi;
        }
        public abstract double Precio();
        public abstract void Add(Componente c);
        public abstract void Remove(Componente c);
        public abstract void Display();
    }
}
