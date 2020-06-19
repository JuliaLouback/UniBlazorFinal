using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniBlazor.Client.Helpers;
using UniBlazor.Shared.DTOs;
using UniBlazor.Shared.Models;

namespace UniBlazor.Client.Repository
{
    public class FornecedorRepository: IFornecedorRepository
    {
        private readonly IHttpService httpService;
        private string url = "api/fornecedor";

        public FornecedorRepository(IHttpService httpService)
        {
            this.httpService = httpService;
        }

        public async Task<List<Fornecedor>> GetFornecedor()
        {
            var response = await httpService.Get<List<Fornecedor>>(url);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }
        public async Task<Fornecedor> GetFornecedor(int Id)
        {
            var response = await httpService.Get<Fornecedor>($"{url}/{Id}");
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }

        public async Task CreateFornecedor(Fornecedor Fornecedor)
        {
            var response = await httpService.Post(url, Fornecedor);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }

        public async Task UpdateFornecedor(Fornecedor Fornecedor)
        {
            var response = await httpService.Put(url, Fornecedor);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }

        public async Task DeleteFornecedor(int Id)
        {
            var response = await httpService.Delete($"{url}/{Id}");
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }
        public async Task<List<Fornecedor>> GetFornecedorFilter(FilterFornecedor filterFornecedor)
        {
            var response = await httpService.Post<FilterFornecedor, List<Fornecedor>>($"{url}/filter", filterFornecedor);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;

        }
    }
}
