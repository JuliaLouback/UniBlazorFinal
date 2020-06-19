using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniBlazor.Client.Helpers;
using UniBlazor.Shared.DTOs;
using UniBlazor.Shared.Models;

namespace UniBlazor.Client.Repository
{
    public class HistoricoRepository: IHistoricoRepository
    {
        private readonly IHttpService httpService;
        private string url = "api/historico";

        public HistoricoRepository(IHttpService httpService)
        {
            this.httpService = httpService;
        }

        public async Task<List<Historico>> GetHistorico()
        {
            var response = await httpService.Get<List<Historico>>(url);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }
        public async Task<Historico> GetHistorico(int Id)
        {
            var response = await httpService.Get<Historico>($"{url}/{Id}");
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }

        public async Task CreateHistorico(Historico Historico)
        {
            var response = await httpService.Post(url, Historico);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }

        public async Task UpdateHistorico(Historico Historico)
        {
            var response = await httpService.Put(url, Historico);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }

        public async Task DeleteHistorico(int Id)
        {
            var response = await httpService.Delete($"{url}/{Id}");
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }

        public async Task<List<Historico>> GetHistoricoFilter(FilterProduto filterProduto)
        {
            var response = await httpService.Post<FilterProduto, List<Historico>>($"{url}/filter", filterProduto);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;

        }
    }
}
