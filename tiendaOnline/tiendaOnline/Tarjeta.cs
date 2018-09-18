using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tiendaOnline
{
    class Tarjeta
    {
        private string Empresa { get; set; }
        private string Numero { get; set; }
        private string Tipo { get; set; }

        public string getEmpresa(){ return this.Empresa;}

        public Tarjeta(string numero)
        {

            string empresa = getEmpresa(numero);
            string tipo = getTipo(numero);



            Empresa = empresa;
            Tipo = tipo;
            Numero = numero;
        }

        private string getEmpresa(string numero)
        {
            char tmp = numero[0];
            if (tmp == '4')
            {
                return "VISA";
            }
            else
            {
                if (tmp == '5')
                    return "MASTERCARD";
                else return "ERROR";

                    }

        }

        private string getTipo(string numero)
        {
            if (numero.Contains('0'))
                return "DEVITO";
            else
                return "CREDITO";
        }
    }
}
