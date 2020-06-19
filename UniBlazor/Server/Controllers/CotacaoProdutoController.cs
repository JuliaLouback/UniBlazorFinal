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
    public class CotacaoProdutoController : ControllerBase
    {
        private readonly ApplicationDbContext _db;

        public CotacaoProdutoController(ApplicationDbContext db)
        {
            _db = db;
        }

        [HttpGet("{id}", Name = "GetByCotacaoProduto")]
        public async Task<ActionResult<List<CotacaoProduto>>> GetByCotacaoProduto(int id)
        {
            return await _db.CotacaoProduto.Include(x => x.Produto).Where(x => x.Cotacao_Id_cotacao == id).ToListAsync();
        }
        

        [HttpPost]
        public async Task<ActionResult> Post(CotacaoProduto cotacaoProduto)
        {
            _db.Add(cotacaoProduto);
            await _db.SaveChangesAsync();
            return new CreatedAtRouteResult(nameof(GetByCotacaoProduto), new { cotacaoProduto.Id_vendaProduto }, cotacaoProduto);
        }

        [HttpPut]
        public async Task<ActionResult> Put(CotacaoProduto cotacaoProduto)
        {
            _db.Entry(cotacaoProduto).State = EntityState.Modified;
            await _db.SaveChangesAsync();
            return NoContent();
        }


        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var cotacaoProduto = await _db.CotacaoProduto.FirstOrDefaultAsync(x => x.Id_vendaProduto == id);
            _db.Remove(cotacaoProduto);
            await _db.SaveChangesAsync();
            return NoContent();
        }
        
    }
}
