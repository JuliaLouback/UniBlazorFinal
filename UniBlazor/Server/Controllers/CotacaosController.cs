using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UniBlazor.Server.Data;
using UniBlazor.Shared.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UniBlazor.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CotacaosController : Controller
    {
        private readonly ApplicationDbContext _db;

        public CotacaosController(ApplicationDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<ActionResult<List<Cotacao>>> Get()
        {
            return await _db.Cotacao.Include(x => x.Funcionario).Include(x => x.Cliente).ToListAsync();
        }


        [HttpGet("{id}", Name = "GetByCotacao")]
        public async Task<ActionResult<Cotacao>> GetByCotacao(int id)
        {
            return await _db.Cotacao.Include(x => x.Funcionario).Include(x => x.Cliente).FirstOrDefaultAsync(x => x.Id_cotacao == id);
        }

        [HttpPost]
        public async Task<ContentResult> Post(Cotacao cotacao)
        {
            _db.Add(cotacao);
            await _db.SaveChangesAsync();
            return Content(Convert.ToString(cotacao.Id_cotacao));
        }

        [HttpPut]
        public async Task<ActionResult> Put(Cotacao cotacao)
        {
            _db.Entry(cotacao).State = EntityState.Modified;
            await _db.SaveChangesAsync();
            return NoContent();
        }


        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var cotacao = await _db.Cotacao.FirstOrDefaultAsync(x => x.Id_cotacao == id);
            _db.Remove(cotacao);
            await _db.SaveChangesAsync();
            return NoContent();
        }
    }
}

