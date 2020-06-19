using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniBlazor.Shared.Models;

namespace UniBlazor.Client.Repository
{
    public interface IEnderecoRepository
    {
        Task CreateEndereco(Endereco telefone);
        Task<Endereco> GetEndereco(int id);
        Task<List<Endereco>> GetEndereco();
        Task UpdateEndereco(Endereco genre);
        Task DeleteEndereco(int Id);
    }
}
