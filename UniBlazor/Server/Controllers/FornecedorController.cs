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
    public class FornecedorController : ControllerBase
    {
        private readonly ApplicationDbContext _db;

        public FornecedorController(ApplicationDbContext db)
        {
            _db = db;
        }
        
        [HttpGet]
        public async Task<ActionResult<List<Fornecedor>>> Get()
        {
            return await _db.Fornecedor.ToListAsync();
        }

        [HttpGet("{id}",Name = "GetByCpnj")]
        public async Task<ActionResult<Fornecedor>> GetByCpnj(int id)
        {
            
            return await _db.Fornecedor.Include(x => x.Telefone).Include(x => x.Endereco).FirstOrDefaultAsync(x => x.Telefone_Id_telefone == id);
        }

        [HttpPost]
        public async Task<ActionResult> Post(Fornecedor fornecedor)
        {
            _db.Add(fornecedor);
            await _db.SaveChangesAsync(); 
            return new CreatedAtRouteResult(nameof(GetByCpnj), new { fornecedor.Cnpj}, fornecedor);
        }

        [HttpPut]
        public async Task<ActionResult> Put(Fornecedor fornecedor)
        {
            _db.Entry(fornecedor).State = EntityState.Modified;
            await _db.SaveChangesAsync();
            return NoContent();
        }


        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var fornecedor = await _db.Fornecedor.FirstOrDefaultAsync(x => x.Telefone_Id_telefone == id);
            _db.Remove(fornecedor);
            await _db.SaveChangesAsync();
            return NoContent();
        }
        [HttpPost("filter")]
        public async Task<ActionResult<List<Fornecedor>>> Filter(FilterFornecedor filterFornecedor)
        {
            var fornecedor = from m in _db.Fornecedor.Include(v => v.Telefone)
                             select m;

            if (!string.IsNullOrEmpty(filterFornecedor.Nome_empresa))
            {
                fornecedor = fornecedor.Where(s => s.Nome_empresa.Contains(filterFornecedor.Nome_empresa));
            }

            if (!string.IsNullOrEmpty(filterFornecedor.Cidade))
            {
                fornecedor = fornecedor.Where(s => s.Endereco.Cidade.Contains(filterFornecedor.Cidade));
            }

            return await fornecedor.ToListAsync();
        }

    }
}
