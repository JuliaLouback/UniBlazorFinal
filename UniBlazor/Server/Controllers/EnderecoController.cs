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
    public class EnderecoController : ControllerBase
    {
        private readonly ApplicationDbContext _db;

        public EnderecoController(ApplicationDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<ActionResult<List<Endereco>>> Get()
        {
            return await _db.Endereco.ToListAsync();
        }

        [HttpGet("{id}", Name = "GetByEndereco")]
        public async Task<ActionResult<Endereco>> GetByEndereco(int id)
        {
            return await _db.Endereco.FirstOrDefaultAsync(x => x.Id_endereco == id);
        }

        [HttpPut]
        public async Task<ActionResult> Put(Endereco endereco)
        {
            _db.Entry(endereco).State = EntityState.Modified;
            await _db.SaveChangesAsync();
            return NoContent();
        }

        [HttpPost]
        public async Task<ActionResult> Post(Endereco endereco)
        {
            _db.Add(endereco);
            await _db.SaveChangesAsync();
            return new CreatedAtRouteResult(nameof(GetByEndereco), new { endereco.Id_endereco }, endereco);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(long id)
        {
            var endereco = await _db.Endereco.FirstOrDefaultAsync(x => x.Id_endereco == id);
            _db.Remove(endereco);
            await _db.SaveChangesAsync();
            return NoContent();
        }

    }
}
