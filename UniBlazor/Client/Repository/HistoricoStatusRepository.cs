using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniBlazor.Client.Helpers;
using UniBlazor.Shared.DTOs;
using UniBlazor.Shared.Models;

namespace UniBlazor.Client.Repository
{
    public class HistoricoStatusRepository : IHistoricoStatusRepository
    {
        private readonly IHttpService httpService;
        private string url = "api/historicostatus";

        public HistoricoStatusRepository(IHttpService httpService)
        {
            this.httpService = httpService;
        }

        public async Task<List<HistoricoStatus>> GetHistoricoStatus()
        {
            var response = await httpService.Get<List<HistoricoStatus>>(url);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }
        public async Task<HistoricoStatus> GetHistoricoStatus(string Id)
        {
            var response = await httpService.Get<HistoricoStatus>($"{url}/{Id}");
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }

        public async Task CreateHistoricoStatus(HistoricoStatus HistoricoStatus)
        {
            var response = await httpService.Post(url, HistoricoStatus);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }

        public async Task UpdateHistoricoStatus(HistoricoStatus HistoricoStatus)
        {
            var response = await httpService.Put(url, HistoricoStatus);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }

        public async Task DeleteHistoricoStatus(string Id)
        {
            var response = await httpService.Delete($"{url}/{Id}");
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }

        public async Task<List<HistoricoStatus>> GetHistoricoStatusFilter(FilterHistoricoStatus filterHistoricoStatus)
        {
            var response = await httpService.Post<FilterHistoricoStatus, List<HistoricoStatus>>($"{url}/filter", filterHistoricoStatus);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;

        }
    }
}

