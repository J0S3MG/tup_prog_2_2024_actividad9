using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaComercio.Models
{
    public class Cliente:Ticket
    {
        long dni;
        public Cliente(string dni)
        {
            this.dni = Convert.ToInt64(dni);
            
        }
        public long VerDNI()
        {
            return dni;
        }
    }
}
