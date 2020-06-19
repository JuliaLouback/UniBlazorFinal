using UniBlazor.Server.Models;
using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniBlazor.Shared.Models;

namespace UniBlazor.Server.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }

        public DbSet<Fornecedor> Fornecedor { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Funcionario> Funcionario { get; set; }
        public DbSet<Telefone> Telefone { get; set; }
        public DbSet<Endereco> Endereco { get; set; }
        public DbSet<HistoricoStatus> HistoricoStatus { get; set; }
        public DbSet<HistoricoSalario> HistoricoSalario { get; set; }
        public DbSet<CFOP> CFOP { get; set; }
        public DbSet<CST> CST { get; set; }
        public DbSet<NCM> NCM { get; set; }
        public DbSet<Produto> Produto { get; set; }
        public DbSet<Historico> Historico { get; set; }
        public DbSet<Venda> Venda { get; set; }
        public DbSet<VendaProduto> VendaProduto { get; set; }
        public DbSet<Cotacao> Cotacao { get; set; }
        public DbSet<CotacaoProduto> CotacaoProduto { get; set; }
    }
}
