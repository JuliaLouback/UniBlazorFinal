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
    public class FuncionarioController : ControllerBase
    {
        private readonly ApplicationDbContext _db;

        public FuncionarioController(ApplicationDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<ActionResult<List<Funcionario>>> Get()
        {
            return await _db.Funcionario.ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult> Post(Funcionario funcionario)
        {
            _db.Add(funcionario);
            await _db.SaveChangesAsync();
            return new CreatedAtRouteResult(nameof(GetByCpfs), new { funcionario.Cpf }, funcionario);

        }

        [HttpPut]
        public async Task<ActionResult> Put(Funcionario funcionario)
        {
            _db.Entry(funcionario).State = EntityState.Modified;
            await _db.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(string id)
        {

            var funcionario = await _db.Funcionario.FirstOrDefaultAsync(x => x.Cpf == id);
            _db.Remove(funcionario);
            await _db.SaveChangesAsync();
            return NoContent();
        }

    
        [HttpGet("{id}", Name = "GetByCpfs")]
        public async Task<ActionResult<Funcionario>> GetByCpfs(string id)
        {
             return await _db.Funcionario.Include(v => v.Endereco).Include(v => v.Telefone).FirstOrDefaultAsync(x => x.Cpf == id);
        }
        [HttpPost("filter")]
        public async Task<ActionResult<List<Funcionario>>> Filter(FilterFuncionario filterFuncionario)
        {
            var funcionario = from m in _db.Funcionario.Include(v => v.Telefone)
                              select m;

            if (!string.IsNullOrEmpty(filterFuncionario.Nome))
            {
                funcionario = funcionario.Where(s => s.Nome.Contains(filterFuncionario.Nome));
            }

            if (!string.IsNullOrEmpty(filterFuncionario.Cpf))
            {
                funcionario = funcionario.Where(s => s.Cpf == filterFuncionario.Cpf);
            }

            if (!string.IsNullOrEmpty(filterFuncionario.Email))
            {
                funcionario = funcionario.Where(s => s.Email == filterFuncionario.Cpf);
            }

            return await funcionario.ToListAsync();
        }

        [HttpPost("filters")]
        public async Task<ActionResult<Funcionario>> Filters(FilterFuncionario filterFuncionario)
        {

                return await _db.Funcionario.Include(v => v.Endereco).Include(v => v.Telefone).FirstOrDefaultAsync(x => x.Email == filterFuncionario.Email);
        }
    }
}
