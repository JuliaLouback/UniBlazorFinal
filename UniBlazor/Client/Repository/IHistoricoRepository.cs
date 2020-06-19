using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniBlazor.Shared.DTOs;
using UniBlazor.Shared.Models;

namespace UniBlazor.Client.Repository
{
    public interface IHistoricoRepository
    {
        Task CreateHistorico(Historico Historico);
        Task<Historico> GetHistorico(int Historico);
        Task<List<Historico>> GetHistorico();
        Task UpdateHistorico(Historico Historico);
        Task DeleteHistorico(int Id);
        Task<List<Historico>> GetHistoricoFilter(FilterProduto filterProduto);

    }
}
