using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transporte;

namespace Transporte
{
    class Program
    {
        static void Main(string[] args)
        {
            //creo obejtos para testear en terminal
            //creo una lista con todos los transportistas disponibles
            List<Transportista> transList = new List<Transportista>(); 
            //Transportistas
                TransportistaPorDistancia fedex = new TransportistaPorDistancia();
            fedex.nombre = "Fedex";
            fedex.tarifaLocal = 50;
            fedex.tarifaLargaDistancia = 100;
                TransportistaPorPeso andre = new TransportistaPorPeso();
            andre.nombre = "Andre";
            andre.tarifa = 20;
            //agrego los transportistas a la lista
            transList.Add(fedex);
            transList.Add(andre);
            //envio
                Envio envio1 = new Envio();
            //paquete
                Paquete paq = new Paquete();
            //cliente
                Cliente cliente1 = new Cliente();
            //seteo los objetos
            cliente1.id = 1;
            cliente1.nombre = "pedro";
            paq.peso = 100;
            envio1.paquete = paq;
            envio1.distancia = 0;
            envio1.descripcion = "El envio tiene un paquete con un peso de 100, con destino de larga distancia";
            while (true)
            {   
                Console.WriteLine();
                Console.WriteLine("El cliente {0}, tiene el envio con descripcion \n {1}", cliente1.nombre, envio1.descripcion);
                Console.WriteLine();
                Console.WriteLine("Para calcular el Transportista ingrese la letra 'a' \n");
                Console.WriteLine("Si desea sair, ingrese 0 \n");
                Console.WriteLine();
                string input = Console.ReadLine();
                char c = input[0];
                if (c == 'a')
                {
                    Console.WriteLine("El precio calculado con las empresas de trasporte son : \n");
                    
                    foreach (Transportista tran in transList) {
                        Console.WriteLine("Precio con {0}, es de : {1} ",tran.nombre,tran.cotizar(envio1));
                    }
                }
                if(c == '0') { break; }

            }
           Environment.Exit(0);
        }
    }
}
