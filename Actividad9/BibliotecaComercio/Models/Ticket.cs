using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaComercio.Models
{
    public abstract class Ticket
    {
        protected int nroO;
        DateTime fh = DateTime.Now;

        public int VerNro()
        {
            return nroO;
        }
        public DateTime VerFh()
        {
            return fh;
        }
    }
}
