using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniBlazor.Shared.DTOs;
using UniBlazor.Shared.Models;

namespace UniBlazor.Client.Repository
{
    public interface IHistoricoStatusRepository
    {
        Task CreateHistoricoStatus(HistoricoStatus HistoricoStatus);
        Task<HistoricoStatus> GetHistoricoStatus(string HistoricoStatus);
        Task<List<HistoricoStatus>> GetHistoricoStatus();
        Task UpdateHistoricoStatus(HistoricoStatus HistoricoStatus);
        Task DeleteHistoricoStatus(string Id);

        Task<List<HistoricoStatus>> GetHistoricoStatusFilter(FilterHistoricoStatus filterHistoricoStatus);


    }
}
