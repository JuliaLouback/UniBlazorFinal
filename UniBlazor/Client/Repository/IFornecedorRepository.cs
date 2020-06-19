using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniBlazor.Shared.DTOs;
using UniBlazor.Shared.Models;

namespace UniBlazor.Client.Repository
{
    public interface IFornecedorRepository
    {
        Task CreateFornecedor(Fornecedor Fornecedor);
        Task<Fornecedor> GetFornecedor(int Fornecedor);
        Task<List<Fornecedor>> GetFornecedor();
        Task UpdateFornecedor(Fornecedor Fornecedor);
        Task DeleteFornecedor(int Id);
        Task<List<Fornecedor>> GetFornecedorFilter(FilterFornecedor filterFornecedor);
    }
}
