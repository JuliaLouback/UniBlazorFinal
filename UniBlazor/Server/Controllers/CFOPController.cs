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
    public class CFOPController : ControllerBase
    {
        private readonly ApplicationDbContext _db;

        public CFOPController(ApplicationDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<ActionResult<List<CFOP>>> Get()
        {
            return await _db.CFOP.ToListAsync();
        }

        [HttpGet("{id}", Name = "GetByCFOP")]
        public async Task<ActionResult<CFOP>> GetByCFOP(long id)
        {
            return await _db.CFOP.FirstOrDefaultAsync(x => x.Codigo == id);
        }

        [HttpPut]
        public async Task<ActionResult> Put(CFOP cfop)
        {
            _db.Entry(cfop).State = EntityState.Modified;
            await _db.SaveChangesAsync();
            return NoContent();
        }

        [HttpPost]
        public async Task<ActionResult> Post(CFOP cfop)
        {
            _db.Add(cfop);
            await _db.SaveChangesAsync();
            return new CreatedAtRouteResult(nameof(GetByCFOP), new { cfop.Codigo }, cfop);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(long id)
        {
            var cfop = await _db.CFOP.FirstOrDefaultAsync(x => x.Codigo == id);
            _db.Remove(cfop);
            await _db.SaveChangesAsync();
            return NoContent();
        }
    }
}
