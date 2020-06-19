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
    public class VendaController : ControllerBase
    {
        private readonly ApplicationDbContext _db;

        public VendaController(ApplicationDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<ActionResult<List<Venda>>> Get()
        {
            return await _db.Venda.Include(x => x.Funcionario).Include(x => x.Cliente).ToListAsync();
        }

        [HttpGet("{id}", Name = "GetByVenda")]
        public async Task<ActionResult<Venda>> GetByVenda(int id)
        {
            return await _db.Venda.Include(x => x.Funcionario).Include(x => x.Cliente).FirstOrDefaultAsync(x => x.Id_venda == id);
        }

        [HttpPost]
        public async Task<ContentResult> Post(Venda venda)
        {
            _db.Add(venda);
            await _db.SaveChangesAsync();
            return Content(Convert.ToString(venda.Id_venda));
        }

        [HttpPut]
        public async Task<ActionResult> Put(Venda venda)
        {
            _db.Entry(venda).State = EntityState.Modified;
            await _db.SaveChangesAsync();
            return NoContent();
        }


        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var venda = await _db.Venda.FirstOrDefaultAsync(x => x.Id_venda == id);
            _db.Remove(venda);
            await _db.SaveChangesAsync();
            return NoContent();
        }

        [HttpPost("filter")]
        public async Task<ActionResult<List<Venda>>> Filter(FilterVenda filterVenda)
        {
            var venda = from m in _db.Venda.Include(v => v.Cliente).Include(v => v.Funcionario)
                            select m;

            if (filterVenda.DataI != null && filterVenda.DataF != null)
            {


                var date = Convert.ToDateTime(filterVenda.DataI);
                var date1 = Convert.ToDateTime(filterVenda.DataF);
                var nextDay = date1.AddDays(1);

                venda = venda.Where(s => s.Data_venda.Date >= date && s.Data_venda.Date < nextDay);
            }
            else if (filterVenda.DataI != null)
            {

                var date = Convert.ToDateTime(filterVenda.DataI).Date;
                var nextDay = date.AddDays(1);
                venda = venda.Where(s => s.Data_venda.Date >= date && (s.Data_venda.Date < nextDay || s.Data_venda.Date == null));
            }

            return await venda.ToListAsync();
        }
    }
}
