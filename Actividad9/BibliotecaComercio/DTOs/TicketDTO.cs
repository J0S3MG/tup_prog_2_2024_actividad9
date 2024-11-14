using BibliotecaComercio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaComercio.DTOs
{
    public class TicketDTO
    {
        public int Tipo {  get; set; }
        public int Nro { get; set; }
        public DateTime Fh { get; set; }
        public CtaCte Ficha { get; set; }
        public long DNI { get; set; }

        public TicketDTO(Ticket t)
        {
            Nro = t.VerNro();
            Fh = t.VerFh();
            if (t is Cliente c)
            {
                Tipo = 1;
                DNI = c.VerDNI();
            }
            else
            {
                if (t is Pago p)
                {
                    Tipo = 2;
                    Ficha = p.VerCC();
                }
            }
        }
    }
}
