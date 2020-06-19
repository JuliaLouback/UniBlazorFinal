using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniBlazor.Shared.DTOs;
using UniBlazor.Shared.Models;

namespace UniBlazor.Client.Repository
{
    public interface IClienteRepository
    {
        Task CreateCliente(Cliente cliente);
        Task<Cliente> GetCliente(string cliente);
        Task<List<Cliente>> GetCliente();
        Task UpdateCliente(Cliente cliente);
        Task DeleteCliente(string Id);
        Task<List<Cliente>> GetClienteFilter(FilterCliente filterCliente);
    }
}
