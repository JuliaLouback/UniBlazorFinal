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
    public class HistoricoSalarioController : ControllerBase
    {
        private readonly ApplicationDbContext _db;

        public HistoricoSalarioController(ApplicationDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<ActionResult<List<HistoricoSalario>>> Get()
        {
            return await _db.HistoricoSalario.Include(x => x.Funcionario).ToListAsync();
        }

        [HttpGet("{id}", Name = "GetByCargo")]
        public async Task<ActionResult<HistoricoSalario>> GetByCargo(string id)
        {
            return await _db.HistoricoSalario.FirstOrDefaultAsync(x => x.Funcionario_Cpf == id && x.Data_final == null);
        }

        [HttpPut]
        public async Task<ActionResult> Put(HistoricoSalario historicoSalario)
        {
            _db.Entry(historicoSalario).State = EntityState.Modified;
            await _db.SaveChangesAsync();
            return NoContent();
        }

        [HttpPost]
        public async Task<ActionResult> Post(HistoricoSalario historicoSalario)
        {
            _db.Add(historicoSalario);
            await _db.SaveChangesAsync();
            return new CreatedAtRouteResult(nameof(GetByCargo), new { historicoSalario.Id_historicoSalario }, historicoSalario);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(string id)
        {
           var historico = await _db.HistoricoSalario.Where(x => x.Funcionario_Cpf == id).ToListAsync();
            _db.RemoveRange(historico);
            await _db.SaveChangesAsync();
            return NoContent();
        }

        [HttpPost("filter")]
        public async Task<ActionResult<List<HistoricoSalario>>> Filter(FilterHistoricoSalario filterHistoricoSalario)
        {
            var historicosalario = from m in _db.HistoricoSalario.Include(v => v.Funcionario)
                                   select m;

            if (!string.IsNullOrEmpty(filterHistoricoSalario.Cargo))
            {
                historicosalario = historicosalario.Where(s => s.Cargo.Contains(filterHistoricoSalario.Cargo));
            }

            if (filterHistoricoSalario.DataI != null && filterHistoricoSalario.DataF != null)
            {


                var date = Convert.ToDateTime(filterHistoricoSalario.DataI);
                var date1 = Convert.ToDateTime(filterHistoricoSalario.DataF);
                var nextDay = date1.AddDays(1);

                historicosalario = historicosalario.Where(s => s.Data_inicio.Value.Date >= date && s.Data_final.Value.Date < nextDay);
            }
            else if (filterHistoricoSalario.DataI != null)
            {

                var date = Convert.ToDateTime(filterHistoricoSalario.DataI).Date;
                var nextDay = date.AddDays(1);
                historicosalario = historicosalario.Where(s => s.Data_inicio.Value.Date >= date && (s.Data_inicio.Value.Date < nextDay || s.Data_inicio.Value.Date == null));
            }

            return await historicosalario.ToListAsync();
        }

    }
}
