using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sucursales
{
    class Sucursales
    {
        public List<ProtoOficina> oficinas = new List<ProtoOficina>();
        public void imprimirLista()
        {
            foreach(ProtoOficina oficina in oficinas){
                oficina.imprimir();
            }
        } 
        OficinaStandar oficinaStandar = new OficinaStandar();
        OficinaSeguridad oficinaSeguridad = new OficinaSeguridad();
        OficinaGerencial oficinaGerencial = new OficinaGerencial();
        public void crearOficina(char a)
        {
            if (a == 'e')
            {
                oficinas.Add(oficinaStandar.clonar());
            }
            if (a == 'g')
            {

                oficinas.Add(oficinaGerencial.clonar());
            }
            if (a == 's')
            {

                oficinas.Add(oficinaSeguridad.clonar());
            }
        }

    }
}
