using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Historial
{
    class Historial
    {
        private static Historial _instancia;

        private Historial() { }

        public static Historial Instancia
        {
            get
            {
                if (_instancia == null) _instancia = new Historial();
                return _instancia;
            }
        }

        public void Log(string idUsuario, string buttonName)
        {
            var linea = "[{0} {1}] [ El usuario ID:{2} presiono el botón:{3} ]";
            var path = @"C:\Logs";
            var file = "HistorialLog.txt";
            Directory.CreateDirectory(path);
            try
            {
                using (StreamWriter writer = File.AppendText(Path.Combine(path,file)))
                {
                    linea = String.Format(linea, DateTime.Now.ToLongDateString(), DateTime.Now.ToLongTimeString(), idUsuario, buttonName);
                    writer.WriteLine(linea);                    
                }
                    
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error: {0}", ex.Message);         
            }
        }
    }
}
