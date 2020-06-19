using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniBlazor.Client.Helpers;
using UniBlazor.Shared.Models;

namespace UniBlazor.Client.Repository
{
    public class TelefoneRepository: ITelefoneRepository
    {
        private readonly IHttpService httpService;
        private string url = "api/telefone";

        public TelefoneRepository(IHttpService httpService)
        {
            this.httpService = httpService;
        }

        public async Task<List<Telefone>> GetTelefone()
        {
            var response = await httpService.Get<List<Telefone>>(url);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }
        public async Task<Telefone> GetTelefone(int Id)
        {
            var response = await httpService.Get<Telefone>($"{url}/{Id}");
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }

        public async Task CreateTelefone(Telefone Telefone)
        {
            var response = await httpService.Post(url, Telefone);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }

        public async Task UpdateTelefone(Telefone Telefone)
        {
            var response = await httpService.Put(url, Telefone);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }

        public async Task DeleteTelefone(int Id)
        {
            var response = await httpService.Delete($"{url}/{Id}");
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }
    }
}

