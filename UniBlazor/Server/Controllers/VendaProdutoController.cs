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
    public class VendaProdutoController : ControllerBase
    {
        private readonly ApplicationDbContext _db;

        public VendaProdutoController(ApplicationDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<ActionResult<List<VendaProduto>>> Get()
        {
            return await _db.VendaProduto.ToListAsync();
        }

        [HttpGet("{id}", Name = "GetByVendaProduto")]
        public async Task<ActionResult<List<VendaProduto>>> GetByVendaProduto(int id)
        {
            return await _db.VendaProduto.Include(x => x.Produto).Where(x => x.Venda_Id_venda == id).ToListAsync();
        }

        
        [HttpPost]
        public async Task<ActionResult> Post(VendaProduto vendaProduto)
        {
            _db.Add(vendaProduto);
            await _db.SaveChangesAsync();
            return new CreatedAtRouteResult(nameof(GetByVendaProduto), new { vendaProduto.Id_vendaProduto }, vendaProduto);
        }

        [HttpPut]
        public async Task<ActionResult> Put(VendaProduto vendaProduto)
        {
            _db.Entry(vendaProduto).State = EntityState.Modified;
            await _db.SaveChangesAsync();
            return NoContent();
        }


        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var vendaProduto = await _db.VendaProduto.FirstOrDefaultAsync(x => x.Id_vendaProduto == id);
            _db.Remove(vendaProduto);
            await _db.SaveChangesAsync();
            return NoContent();
        } 
    }
}
