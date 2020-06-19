using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UniBlazor.Server.Data;
using UniBlazor.Shared.DTOs;
using UniBlazor.Shared.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UniBlazor.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProdutoController : ControllerBase
    {
        private readonly ApplicationDbContext _db;

        public ProdutoController(ApplicationDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<ActionResult<List<Produto>>> Get()
        {
            return await _db.Produto.Include(x => x.Fornecedor).Include(x => x.CFOP).Include(x => x.CST).Include(x => x.NCM).ToListAsync();
        }

        [HttpPut]
        public async Task<ActionResult> Put(Produto produto)
        {
            _db.Entry(produto).State = EntityState.Modified;
            await _db.SaveChangesAsync();
            return NoContent();
        }

        [HttpPost]
        public async Task<ActionResult> Post(Produto produto)
        {
            _db.Add(produto);
            await _db.SaveChangesAsync();
            return new CreatedAtRouteResult(nameof(GetByProduto), new { produto.Id_produto }, produto);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var produto = await _db.Produto.FirstOrDefaultAsync(x => x.Id_produto == id);
            _db.Remove(produto);
            await _db.SaveChangesAsync();
            return NoContent();
        }

         [HttpGet("{id}", Name = "GetByProduto")]
        public async Task<ActionResult<Produto>> GetByProduto(int id)
        {
            return await _db.Produto.Include(x => x.CFOP).FirstOrDefaultAsync(x => x.Id_produto == id);
        }

        [HttpPost("filter")]
        public async Task<ActionResult<List<Produto>>> Filter(FilterProduto filterProduto)
        {
            var produto = from m in _db.Produto.Include(v => v.Fornecedor)
                          select m;

            if (!string.IsNullOrEmpty(filterProduto.Nome))
            {
                produto = produto.Where(s => s.Nome.Contains(filterProduto.Nome));
            }

            if (!string.IsNullOrEmpty(filterProduto.Descricao))
            {
                produto = produto.Where(f => f.Descricao.Contains(filterProduto.Descricao));
            }

            return await produto.ToListAsync();
        }
    }
}
