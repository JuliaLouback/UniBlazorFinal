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
    public class HistoricoStatusController : ControllerBase
    {
        private readonly ApplicationDbContext _db;

        public HistoricoStatusController(ApplicationDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<ActionResult<List<HistoricoStatus>>> Get()
        {
            return await _db.HistoricoStatus.Include(x => x.Funcionario).ToListAsync();
        }

        [HttpGet("{id}", Name = "GetByStatus")]
        public async Task<ActionResult<HistoricoStatus>> GetByStatus(string id)
        {
            return await _db.HistoricoStatus.FirstOrDefaultAsync(x => x.Funcionario_Cpf == id && x.Data_final == null);
        }

        [HttpPost]
        public async Task<ActionResult> Post(HistoricoStatus historicoStatus)
        {
            _db.Add(historicoStatus);
            await _db.SaveChangesAsync();
            return new CreatedAtRouteResult(nameof(GetByStatus), new { historicoStatus.Id_historicoStatus }, historicoStatus);
        }

        [HttpPut]
        public async Task<ActionResult> Put(HistoricoStatus historicoStatus)
        {
            _db.Entry(historicoStatus).State = EntityState.Modified;
            await _db.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(string id)
        {
            var historicoStatus = await _db.HistoricoStatus.Where(x => x.Funcionario_Cpf == id).ToListAsync();
            _db.RemoveRange(historicoStatus);
            await _db.SaveChangesAsync();
            return NoContent();
        }

        [HttpPost("filter")]
        public async Task<ActionResult<List<HistoricoStatus>>> Filter(FilterHistoricoStatus filterHistoricoStatus)
        {
            var historico = from m in _db.HistoricoStatus.Include(v => v.Funcionario)
                          select m;

            if (!string.IsNullOrEmpty(filterHistoricoStatus.Status))
            {
                historico = historico.Where(s => s.Status.Contains(filterHistoricoStatus.Status));
            }

            if (filterHistoricoStatus.DataI != null && filterHistoricoStatus.DataF != null)
            {


                var date = Convert.ToDateTime(filterHistoricoStatus.DataI);
                var date1 = Convert.ToDateTime(filterHistoricoStatus.DataF);
                var nextDay = date1.AddDays(1);

                historico = historico.Where(s => s.Data_inicio.Value.Date >= date && s.Data_final.Value.Date < nextDay);
            }
            else if (filterHistoricoStatus.DataI != null)
            {

                var date = Convert.ToDateTime(filterHistoricoStatus.DataI).Date;
                var nextDay = date.AddDays(1);
                historico = historico.Where(s => s.Data_inicio.Value.Date >= date && (s.Data_inicio.Value.Date < nextDay || s.Data_inicio.Value.Date == null));
            }

            return await historico.ToListAsync();
        }

    }
}
