using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TomasSampietro.EjerciciosTLYA.Contactos
{
    internal class Contacto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Organizacion { get; set; }
        public string Email { get; set; }
    
    
         public Contacto(int pId, string pNombre, string pApellido, string pOrganizacion, string pEmail)
        {
            Id = pId;
            Nombre = pNombre;
            Apellido = pApellido;
            Organizacion = pOrganizacion;
            Email = pEmail;
        }

        public override bool Equals(object otro)
        {
            bool retorno = false;

            if(otro != null && otro is Contacto)
            {
                Contacto otroContacto = (Contacto)otro;

                if(otroContacto.Email == this.Email)
                {
                    retorno = true;
                }
            }
            return retorno;
        }

    }
}
