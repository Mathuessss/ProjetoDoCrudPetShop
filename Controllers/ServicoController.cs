using System.Threading.Tasks;
using Crud_do_petshop.Data;
using Crud_do_petshop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Crud_do_petshop.Controllers
{
    [Controller]
    [Route("[controller]")]
    public class ServicoController : ControllerBase
    {
        private DataContext dc;
        public ServicoController(DataContext context)
        {
            this.dc = context;
        }

        [HttpPost("Servico")]
        public async Task<ActionResult> casdastrar([FromBody] Servico p)
        {
            dc.Servico.Add(p);
            await dc.SaveChangesAsync();

            return Created("Servico", p);
        }

        [HttpGet("Servico")]
        public async Task<ActionResult> listar()
        {
            var dados = await dc.Servico.ToListAsync();
            return Ok(dados);
        }

        [HttpGet("Servico/{Codigo}")]
        public Servico filtrar(int Codigo)
        {
            Servico p = dc.Servico.Find(Codigo);
            return p;
        }
        [HttpPut("Servico")]
        public async Task<ActionResult> editar([FromBody] Servico p)
        {
            dc.Servico.Update(p);
            await dc.SaveChangesAsync();
            return Ok(p);
        }

        [HttpDelete("Servico/{codigo}")]
        public async Task<ActionResult> deletar(int codigo)
        {
            Servico p = filtrar(codigo);
            if (p == null)
            {
                return NotFound();
            }
            else
            {
                dc.Servico.Remove(p);
                await dc.SaveChangesAsync();
                return Ok();
            }
        }

        [HttpGet("oi")]
        public string oi()
        {
            return "Hello World";
        }
    }
}