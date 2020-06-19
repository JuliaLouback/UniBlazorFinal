using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniBlazor.Client.Helpers;
using UniBlazor.Shared.DTOs;
using UniBlazor.Shared.Models;

namespace UniBlazor.Client.Repository
{
    public class FuncionarioRepository: IFuncionarioRepository
    {
        private readonly IHttpService httpService;
        private string url = "api/funcionario";

        public FuncionarioRepository(IHttpService httpService)
        {
            this.httpService = httpService;
        }

        public async Task<List<Funcionario>> GetFuncionario()
        {
            var response = await httpService.Get<List<Funcionario>>(url);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }
        public async Task<Funcionario> GetFuncionario(string Id)
        {
            var response = await httpService.Get<Funcionario>($"{url}/{Id}");
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }

        public async Task CreateFuncionario(Funcionario funcionario)
        {
            var response = await httpService.Post(url, funcionario);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }

        public async Task UpdateFuncionario(Funcionario funcionario)
        {
            var response = await httpService.Put(url, funcionario);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }

        public async Task DeleteFuncionario(string Id)
        {
            var response = await httpService.Delete($"{url}/{Id}");
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }
        public async Task<List<Funcionario>> GetFuncionarioFilter(FilterFuncionario filterFuncionario)
        {
            var response = await httpService.Post<FilterFuncionario, List<Funcionario>>($"{url}/filter", filterFuncionario);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;

        }
    }
}
