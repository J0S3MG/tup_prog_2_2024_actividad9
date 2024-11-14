namespace BibliotecaComercio.Models
{
    public class Comercio
    {
        Queue<Pago> nuevoP = new Queue<Pago>();
        Queue<Cliente> nuevoC = new Queue<Cliente>();
        List<CtaCte> ctaCtes = new List<CtaCte>();
        public void AgregarTicket(Ticket t)
        {
            if (t is Cliente)
            {
                nuevoC.Enqueue((Cliente)t);
            }
            else
            {
                if (t is Pago)
                {
                    nuevoP.Enqueue((Pago)t);
                }
            }
        }
        public Ticket AtenderTicket(int tipo)
        {
            Ticket t = null;
            if (tipo == 1)
            {
                t = nuevoC.Dequeue();
            }
            else
            {
                if (tipo == 2)
                {
                    t = nuevoP.Dequeue();
                }
            }
            return t;
        }
        public CtaCte VerCtaCte(int nro)
        {
            CtaCte cc = new CtaCte(nro, null);
            ctaCtes.Sort();
            int idx = ctaCtes.BinarySearch(cc);
            if (idx > -1) return ctaCtes[idx];
            return null;
        }
        public CtaCte AgregarCtaCte(int nroCC, string dni)
        {
            CtaCte cc = VerCtaCte(nroCC);
            if (cc == null)
            {
                Cliente c = new Cliente(dni);
                cc = new CtaCte(nroCC, c);
                ctaCtes.Add(cc);
                return cc;
            }
            return null;
        }

    }
}
