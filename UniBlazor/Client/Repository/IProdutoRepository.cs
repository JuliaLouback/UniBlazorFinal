using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniBlazor.Shared.DTOs;
using UniBlazor.Shared.Models;

namespace UniBlazor.Client.Repository
{
    public interface IProdutoRepository
    {
        Task CreateProduto(Produto Produto);
        Task<Produto> GetProduto(int Produto);
        Task<List<Produto>> GetProduto();
        Task UpdateProduto(Produto Produto);
        Task DeleteProduto(int Id);
        Task<List<Produto>> GetProdutoFilter(FilterProduto filterProduto);
    }
}
