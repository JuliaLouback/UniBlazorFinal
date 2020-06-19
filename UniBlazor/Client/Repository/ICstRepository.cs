using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniBlazor.Shared.DTOs;
using UniBlazor.Shared.Models;

namespace UniBlazor.Client.Repository
{
    public interface ICstRepository
    {
        Task CreateCst(CST cst);
        Task<CST> GetCST(string cst);
        Task<List<CST>> GetCST();
        Task UpdateCst(CST cst);
        Task DeleteCst(string Id);
    }
}
