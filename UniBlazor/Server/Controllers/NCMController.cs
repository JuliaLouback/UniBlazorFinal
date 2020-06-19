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
    public class NCMController : ControllerBase
    {
        private readonly ApplicationDbContext _db;

        public NCMController(ApplicationDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<ActionResult<List<NCM>>> Get()
        {
            return await _db.NCM.ToListAsync();
        }

        [HttpGet("{id}", Name = "GetByNCM")]
        public async Task<ActionResult<NCM>> GetByNCM(long id)
        {
            return await _db.NCM.FirstOrDefaultAsync(x => x.Codigo == id);
        }

        [HttpPut]
        public async Task<ActionResult> Put(NCM ncm)
        {
            _db.Entry(ncm).State = EntityState.Modified;
            await _db.SaveChangesAsync();
            return NoContent();
        }

        [HttpPost]
        public async Task<ActionResult> Post(NCM ncm)
        {
            _db.Add(ncm);
            await _db.SaveChangesAsync();
            return new CreatedAtRouteResult(nameof(GetByNCM), new { ncm.Codigo }, ncm);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(long id)
        {
            var ncm = await _db.NCM.FirstOrDefaultAsync(x => x.Codigo == id);
            _db.Remove(ncm);
            await _db.SaveChangesAsync();
            return NoContent();
        }
    }
}
