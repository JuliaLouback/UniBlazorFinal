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
    public class HistoricoController : ControllerBase
    {
        private readonly ApplicationDbContext _db;

        public HistoricoController(ApplicationDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<ActionResult<List<Historico>>> Get()
        {
            return await _db.Historico.Include(x => x.Produto).ToListAsync();
        }

        [HttpGet("{id}", Name = "GetByHistorico")]
        public async Task<ActionResult<Historico>> GetByHistorico(int id)
        {
            return await _db.Historico.FirstOrDefaultAsync(x => x.Produto_Id_produto == id && x.Data_final == null);
        }

        [HttpPost]
        public async Task<ActionResult> Post(Historico historico)
        {
            _db.Add(historico);
            await _db.SaveChangesAsync();
            return new CreatedAtRouteResult(nameof(GetByHistorico), new { historico.Id_historico }, historico);
        }

        [HttpPut]
        public async Task<ActionResult> Put(Historico historico)
        {
            _db.Entry(historico).State = EntityState.Modified;
            await _db.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var historico = await _db.Historico.Where(x => x.Produto_Id_produto == id).ToListAsync();
            _db.RemoveRange(historico);
            await _db.SaveChangesAsync();
            return NoContent();
        }


        [HttpPost("filter")]
        public async Task<ActionResult<List<Historico>>> Filter(FilterProduto filterProduto)
        {
            var historico = from m in _db.Historico.Include(v => v.Produto)
                          select m;

            if (!string.IsNullOrEmpty(filterProduto.Nome))
            {
                historico = historico.Where(s => s.Produto.Nome.Contains(filterProduto.Nome));
            }

            if (filterProduto.DataI != null && filterProduto.DataF != null)
            {


                var date = Convert.ToDateTime(filterProduto.DataI);
                var date1 = Convert.ToDateTime(filterProduto.DataF);
                var nextDay = date1.AddDays(1);

                historico = historico.Where(s => s.Data_inicio.Value.Date >= date && s.Data_final.Value.Date < nextDay);
            }
            else if (filterProduto.DataI != null)
            {

                var date = Convert.ToDateTime(filterProduto.DataI).Date;
                var nextDay = date.AddDays(1);
                historico = historico.Where(s => s.Data_inicio.Value.Date >= date && (s.Data_inicio.Value.Date < nextDay || s.Data_inicio.Value.Date == null));
            }

            return await historico.ToListAsync();
        }
    }
}
