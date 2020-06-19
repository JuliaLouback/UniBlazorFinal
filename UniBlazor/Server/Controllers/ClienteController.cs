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
    public class ClienteController : ControllerBase
    {
        private readonly ApplicationDbContext _db;

        public ClienteController(ApplicationDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<ActionResult<List<Cliente>>> Get()
        {
            return await _db.Cliente.ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult> Post(Cliente cliente)
        {
            _db.Add(cliente);
            await _db.SaveChangesAsync();
            return new CreatedAtRouteResult(nameof(GetByCpf), new { cliente.Cpf }, cliente);
        }

        [HttpPut]
        public async Task<ActionResult> Put(Cliente cliente)
        {
            _db.Entry(cliente).State = EntityState.Modified;
            await _db.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(string id)
        {
            var cliente = await _db.Cliente.FirstOrDefaultAsync(x => x.Cpf == id);
            _db.Remove(cliente);
            await _db.SaveChangesAsync();
            return NoContent();
        }

        [HttpGet("{id}", Name = "GetByCpf")]
        public async Task<ActionResult<Cliente>> GetByCpf(string id)
        {
            return await _db.Cliente.Include(x => x.Telefone).Include(x => x.Endereco).FirstOrDefaultAsync(x => x.Cpf == id);
        }

        [HttpPost("filter")]
        public async Task<ActionResult<List<Cliente>>> Filter(FilterCliente filterCliente)
        {
            var cliente = from m in _db.Cliente.Include(v => v.Telefone)
                          select m;

            if (!string.IsNullOrEmpty(filterCliente.Nome))
            {
                cliente = cliente.Where(s => s.Nome.Contains(filterCliente.Nome));
            }

            if (!string.IsNullOrEmpty(filterCliente.Cpf))
            {
                cliente = cliente.Where(s => s.Cpf == filterCliente.Cpf);
            }

            return await cliente.ToListAsync();
        }
    }
}