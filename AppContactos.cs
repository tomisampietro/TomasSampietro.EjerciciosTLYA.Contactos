using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TomasSampietro.EjerciciosTLYA.Contactos
{
    internal class AppContactos
    {
        Validador validador;

        List<Contacto> contactos;

        public AppContactos()
        {
            validador = new Validador();
            contactos = new List<Contacto>();
        }


        public void ejecutar()
        {
            string opcion = "";
            do
            {
                opcion = validador.pedirStringNoVacio("Ingrese una opcion: \n A. nuevo contacto \n B. Buscar Contacto \n C.Salir \n ");

                if (opcion == "A")
                {
                    nuevoContacto();
                }
                else if (opcion == "B")
                {
                    buscarContacto();
                }
                else if (opcion == "C")
                {
                    Console.WriteLine("Ha salido del programa");
                }
                else
                {
                    Console.WriteLine("Opcion no valida.");
                }

            } while (opcion != "C");
        }

        public void nuevoContacto()
        {
            string emailContacto = validador.pedirStringNoVacio("Ingrese email: ");
            Contacto contactoAAgregar = new Contacto(0, "", "", "", emailContacto);

            //ver si existe un contacto con ese mail. 
            if (contactos.Contains(contactoAAgregar))
            {
                Console.WriteLine("Ya existe un contacto con ese email.");
            }
            else
            {
                string nombreContacto = validador.pedirStringNoVacio("Ingrese nombre: ");
                string apellidoContacto = validador.pedirStringNoVacio("Ingrese apellido: ");
                string orgContacto = validador.pedirStringNoVacio("Ingrese Org: ");
                int IdContacto = getId();

                contactos.Add(new Contacto(IdContacto, nombreContacto, apellidoContacto, orgContacto, emailContacto));
            }

        }

        public void buscarContacto()
        {
            string orgABuscar = validador.pedirStringNoVacio("Ingrese Org: ");
            foreach(Contacto contacto in contactos)
            {
                if(contacto.Organizacion == orgABuscar)
                {
                    Console.WriteLine(contacto.ToString());
                }
            }
        }

        public int getId()
        {
            int retorno;
            if (contactos.Count() == 0)
            {
                retorno = 1;
            }
            else
            {
                retorno = contactos.Count() + 1;
            }
            
            return retorno;
        }
    }
}
