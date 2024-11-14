using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaComercio.Models
{
    public class Pago: Ticket
    {
        CtaCte cc;
        public Pago(CtaCte c)
        {
            cc = c;
        }
        public CtaCte VerCC()
        {
            return cc;
        }
    }
}
