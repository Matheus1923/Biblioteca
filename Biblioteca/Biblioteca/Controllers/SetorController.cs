using Biblioteca.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biblioteca.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SetorController : ControllerBase
    {
        public Contexto Contexto { get; set; }

        public SetorController (Contexto novoContexto)
        {
            this.Contexto = novoContexto;
        }

        [HttpGet]
        public List<Setor> Get()
        {
            return Contexto.Setors.ToList();
        }

        [HttpGet("id")]
        public Setor Get(int id)
        {
            return Contexto.Setors.First(e => e.IdSetor == id);
        }

        [HttpGet("idsetor/{idsetor}")]
        public List<Setor> Filtrar(int id)
        {
            return Contexto.Setors.Where(e => e.IdSetor == id).ToList();
        }

        [HttpPost]
        [Route("add")]

        public async Task<ActionResult<Setor>> Create(Setor Setor)
        {
            Setor.IdSetor = 0;
            Contexto.Setors.Add(Setor);
            await Contexto.SaveChangesAsync();
            return CreatedAtAction(nameof(Get), new { id = Setor.IdSetor, Setor });
        }

        [HttpPost]
        [Route("update")]

        public async Task<ActionResult<Setor>> Update(Setor Setor)
        {
            Contexto.Setors.Update(Setor);
            await Contexto.SaveChangesAsync();
            return CreatedAtAction(nameof(Get), new { id = Setor.IdSetor, Setor });
        }

        [HttpPost]
        [Route("delete")]

        public async Task<ActionResult<Setor>> Delete(Setor Setor)
        {
            Contexto.Setors.Remove(Setor);
            await Contexto.SaveChangesAsync();
            return CreatedAtAction(nameof(Get), new { id = Setor.IdSetor, Setor });
        }
    }
}
