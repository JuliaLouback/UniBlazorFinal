using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniBlazor.Client.Helpers;
using UniBlazor.Shared.Models;

namespace UniBlazor.Client.Repository
{
    public class EnderecoRepository: IEnderecoRepository
    {
        private readonly IHttpService httpService;
        private string url = "api/endereco";

        public EnderecoRepository(IHttpService httpService)
        {
            this.httpService = httpService;
        }

        public async Task<List<Endereco>> GetEndereco()
        {
            var response = await httpService.Get<List<Endereco>>(url);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }
        public async Task<Endereco> GetEndereco(int Id)
        {
            var response = await httpService.Get<Endereco>($"{url}/{Id}");
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }

        public async Task CreateEndereco(Endereco Endereco)
        {
            var response = await httpService.Post(url, Endereco);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }

        public async Task UpdateEndereco(Endereco Endereco)
        {
            var response = await httpService.Put(url, Endereco);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }

        public async Task DeleteEndereco(int Id)
        {
            var response = await httpService.Delete($"{url}/{Id}");
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }
    }
}
