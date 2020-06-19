using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniBlazor.Shared.DTOs;
using UniBlazor.Shared.Models;

namespace UniBlazor.Client.Repository
{
    public interface IHistoricoSalarioRepository
    {
        Task CreateHistoricoSalario(HistoricoSalario HistoricoSalario);
        Task<HistoricoSalario> GetHistoricoSalario(string HistoricoSalario);
        Task<List<HistoricoSalario>> GetHistoricoSalario();
        Task UpdateHistoricoSalario(HistoricoSalario HistoricoSalario);
        Task DeleteHistoricoSalario(string Id);

        Task<List<HistoricoSalario>> GetHistoricoSalarioFilter(FilterHistoricoSalario filterHistoricoSalario);

    }
}
