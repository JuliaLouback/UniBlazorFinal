using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniBlazor.Client.Helpers;
using UniBlazor.Shared.DTOs;
using UniBlazor.Shared.Models;

namespace UniBlazor.Client.Repository
{
    public class ClienteRepository: IClienteRepository
    {
        private readonly IHttpService httpService;
        private string url = "api/cliente";

        public ClienteRepository(IHttpService httpService)
        {
            this.httpService = httpService;
        }

        public async Task<List<Cliente>> GetCliente()
        {
            var response = await httpService.Get<List<Cliente>>(url);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }
        public async Task<Cliente> GetCliente(string Id)
        {
            var response = await httpService.Get<Cliente>($"{url}/{Id}");
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }

        public async Task CreateCliente(Cliente cliente)
        {
            var response = await httpService.Post(url, cliente);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }

        public async Task UpdateCliente(Cliente cliente)
        {
            var response = await httpService.Put(url, cliente);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }

        public async Task DeleteCliente(string Id)
        {
            var response = await httpService.Delete($"{url}/{Id}");
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }

        public async Task<List<Cliente>> GetClienteFilter(FilterCliente filterCliente)
        {
            var response = await httpService.Post<FilterCliente, List<Cliente>>($"{url}/filter", filterCliente);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;

        }
    }
}

