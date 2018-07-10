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

        public void crearOficina(char a)
        {
            if(a == 'e')
            { 
                oficinas.Add(OficinaStandar.clonar());
            }
            if(a == 'g')
            { 
                
                oficinas.Add(OficinaGerencial.clonar());
            }
            if(a == 's')
            {
                
                oficinas.Add(OficinaSeguridad.clonar());
            }
        }
    }
}
