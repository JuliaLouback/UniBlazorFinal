using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniBlazor.Client.Helpers;
using UniBlazor.Shared.DTOs;
using UniBlazor.Shared.Models;

namespace UniBlazor.Client.Repository
{
    public class HistoricoSalarioRepository: IHistoricoSalarioRepository
    {
        private readonly IHttpService httpService;
        private string url = "api/historicosalario";

        public HistoricoSalarioRepository(IHttpService httpService)
        {
            this.httpService = httpService;
        }

        public async Task<List<HistoricoSalario>> GetHistoricoSalario()
        {
            var response = await httpService.Get<List<HistoricoSalario>>(url);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }
        public async Task<HistoricoSalario> GetHistoricoSalario(string Id)
        {
            var response = await httpService.Get<HistoricoSalario>($"{url}/{Id}");
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }

        public async Task CreateHistoricoSalario(HistoricoSalario HistoricoSalario)
        {
            var response = await httpService.Post(url, HistoricoSalario);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }

        public async Task UpdateHistoricoSalario(HistoricoSalario HistoricoSalario)
        {
            var response = await httpService.Put(url, HistoricoSalario);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }

        public async Task DeleteHistoricoSalario(string Id)
        {
            var response = await httpService.Delete($"{url}/{Id}");
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }

        public async Task<List<HistoricoSalario>> GetHistoricoSalarioFilter(FilterHistoricoSalario filterHistoricoSalario)
        {
            var response = await httpService.Post<FilterHistoricoSalario, List<HistoricoSalario>>($"{url}/filter", filterHistoricoSalario);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;

        }
    }
}
