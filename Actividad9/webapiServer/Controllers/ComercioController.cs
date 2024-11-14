using BibliotecaComercio.DTOs;
using BibliotecaComercio.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace webapiServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComercioController : ControllerBase
    {
        readonly static Comercio c = new Comercio();

        [HttpGet("AgregarTicket")]
        public IActionResult GetAgregarTicket(int tipo,int nro,string dni)//Manda un mensaje al cliente
        {
            Ticket t = null;
            if(tipo == 1)
            {
                t = new Cliente(dni);
            }
            else
            {
                if (tipo == 2)
                {
                    CtaCte cc = c.VerCtaCte(nro);
                    t = new Pago(cc);
                }
            }
            
            if (t != null)
            {
                c.AgregarTicket(t);
                return Ok("Turno solicitado ok!");
            }
            return NoContent();
        }

        [HttpGet("AtenderTicket")]
        public IActionResult GetAgregarTicket(int tipo)//Manda un mensaje al cliente
        {
            Ticket atendido = c.AtenderTicket(tipo);
            if (atendido != null)
            {
                TicketDTO dto = new TicketDTO(atendido);
                return Ok(dto);
            }    
            return NotFound("No se encontraron tickets");
        }

        [HttpGet("AgregarCtaCte")]
        public IActionResult GetAgregarCtaCte(int nroCC, string dni)//Manda un mensaje al cliente
        {
            CtaCte cc = c.AgregarCtaCte(nroCC,dni);
            if (cc != null) return Ok("Se agrego correctamente ");
            return NoContent();
        }

    }
}
