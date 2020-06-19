using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniBlazor.Client.Helpers;
using UniBlazor.Shared.DTOs;
using UniBlazor.Shared.Models;

namespace UniBlazor.Client.Repository
{
    public class ProdutoRepository:IProdutoRepository
    {
        private readonly IHttpService httpService;
        private string url = "api/Produto";

        public ProdutoRepository(IHttpService httpService)
        {
            this.httpService = httpService;
        }

        public async Task<List<Produto>> GetProduto()
        {
            var response = await httpService.Get<List<Produto>>(url);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }
        public async Task<Produto> GetProduto(int Id)
        {
            var response = await httpService.Get<Produto>($"{url}/{Id}");
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }

        public async Task CreateProduto(Produto Produto)
        {
            var response = await httpService.Post(url, Produto);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }

        public async Task UpdateProduto(Produto Produto)
        {
            var response = await httpService.Put(url, Produto);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }

        public async Task DeleteProduto(int Id)
        {
            var response = await httpService.Delete($"{url}/{Id}");
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }

        public async Task<List<Produto>> GetProdutoFilter(FilterProduto filterProduto)
        {
            var response = await httpService.Post<FilterProduto, List<Produto>>($"{url}/filter", filterProduto);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;

        }
    }
}
