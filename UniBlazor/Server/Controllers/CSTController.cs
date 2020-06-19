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
    public class CSTController : ControllerBase
    {
        private readonly ApplicationDbContext _db;

        public CSTController(ApplicationDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<ActionResult<List<CST>>> Get()
        {
            return await _db.CST.ToListAsync();
        }

        [HttpGet("{id}", Name = "GetByCST")]
        public async Task<ActionResult<CST>> GetByCST(string id)
        {
            return await _db.CST.FirstOrDefaultAsync(x => x.Codigo == id);
        }

        [HttpPut]
        public async Task<ActionResult> Put(CST cst)
        {
            _db.Entry(cst).State = EntityState.Modified;
            await _db.SaveChangesAsync();
            return NoContent();
        }

        [HttpPost]
        public async Task<ActionResult> Post(CST cst)
        {
            _db.Add(cst);
            await _db.SaveChangesAsync();
            return new CreatedAtRouteResult(nameof(GetByCST), new { cst.Codigo }, cst);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(string id)
        {
            var cst = await _db.CST.FirstOrDefaultAsync(x => x.Codigo == id);
            _db.Remove(cst);
            await _db.SaveChangesAsync();
            return NoContent();
        }
    }
}
