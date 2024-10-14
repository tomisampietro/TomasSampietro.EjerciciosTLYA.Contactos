using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TomasSampietro.EjerciciosTLYA.Contactos
{
    internal class Validador
    {
        public string pedirStringNoVacio(string mensaje)
        {
            string retorno = "";
            do
            {
                Console.WriteLine(mensaje);
                retorno = Console.ReadLine().ToUpper();

                if (retorno == "")
                {
                    Console.WriteLine("Debe ingresar un valor no vacio.");
                }

            } while (retorno =="");

            return retorno;
        }
    }
}
