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
    public class TelefoneController : ControllerBase
    {
        private readonly ApplicationDbContext _db;

        public TelefoneController(ApplicationDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<ActionResult<List<Telefone>>> Get()
        {
            return await _db.Telefone.ToListAsync();
        }

        [HttpGet("{id}", Name = "GetById")]
        public async Task<ActionResult<Telefone>> GetById(int id)
        {
            return await _db.Telefone.FirstOrDefaultAsync(x => x.Id_telefone == id);
        }

        [HttpPut]
        public async Task<ActionResult> Put(Telefone telefone)
        {
            _db.Entry(telefone).State = EntityState.Modified;
            await _db.SaveChangesAsync();
            return NoContent();
        }

        [HttpPost]
        public async Task<ActionResult> Post(Telefone telefone)
        {
            _db.Add(telefone);
            await _db.SaveChangesAsync();
            return new CreatedAtRouteResult(nameof(GetById), new { telefone.Id_telefone }, telefone);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(long id)
        {
            var telefone = await _db.Telefone.FirstOrDefaultAsync(x => x.Id_telefone == id);
            _db.Remove(telefone);
            await _db.SaveChangesAsync();
            return NoContent();
        }

    }
}
