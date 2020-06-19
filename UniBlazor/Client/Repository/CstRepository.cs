using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniBlazor.Client.Helpers;
using UniBlazor.Shared.DTOs;
using UniBlazor.Shared.Models;

namespace UniBlazor.Client.Repository
{
    public class CstRepository: ICstRepository
    {
        private readonly IHttpService httpService;
        private string url = "api/cst";

        public CstRepository(IHttpService httpService)
        {
            this.httpService = httpService;
        }

        public async Task<List<CST>> GetCST()
        {
            var response = await httpService.Get<List<CST>>(url);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }
        public async Task<CST> GetCST(string Id)
        {
            var response = await httpService.Get<CST>($"{url}/{Id}");
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }

        public async Task CreateCst(CST cst)
        {
            var response = await httpService.Post(url, cst);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }

        public async Task UpdateCst(CST cst)
        {
            var response = await httpService.Put(url, cst);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }

        public async Task DeleteCst(string Id)
        {
            var response = await httpService.Delete($"{url}/{Id}");
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }
    }
}
