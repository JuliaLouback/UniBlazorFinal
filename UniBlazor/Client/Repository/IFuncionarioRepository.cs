using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniBlazor.Shared.DTOs;
using UniBlazor.Shared.Models;

namespace UniBlazor.Client.Repository
{
    public interface IFuncionarioRepository
    {
        Task CreateFuncionario(Funcionario funcionario);
        Task<Funcionario> GetFuncionario(string Funcionario);
        Task<List<Funcionario>> GetFuncionario();
        Task UpdateFuncionario(Funcionario funcionario);
        Task DeleteFuncionario(string Id);
        Task<List<Funcionario>> GetFuncionarioFilter(FilterFuncionario filterFuncionario);
    }
}
