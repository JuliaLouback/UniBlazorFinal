using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniBlazor.Shared.Models;

namespace UniBlazor.Client.Repository
{
    public interface ITelefoneRepository
    {
        Task CreateTelefone(Telefone telefone);
        Task<Telefone> GetTelefone(int id);
        Task<List<Telefone>> GetTelefone();
        Task UpdateTelefone(Telefone telefone);
        Task DeleteTelefone(int Id);
    }
}
