using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UniBlazor.Server.Data.Migrations
{
    public partial class login : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CFOP",
                columns: table => new
                {
                    Codigo = table.Column<long>(nullable: false),
                    Descricao = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CFOP", x => x.Codigo);
                });

            migrationBuilder.CreateTable(
                name: "CST",
                columns: table => new
                {
                    Codigo = table.Column<string>(nullable: false),
                    Descricao = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CST", x => x.Codigo);
                });

            migrationBuilder.CreateTable(
                name: "Endereco",
                columns: table => new
                {
                    Id_endereco = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cep = table.Column<string>(nullable: false),
                    Numero = table.Column<int>(nullable: false),
                    Rua = table.Column<string>(maxLength: 60, nullable: false),
                    Bairro = table.Column<string>(maxLength: 45, nullable: false),
                    Cidade = table.Column<string>(maxLength: 45, nullable: false),
                    Estado = table.Column<string>(maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Endereco", x => x.Id_endereco);
                });

            migrationBuilder.CreateTable(
                name: "NCM",
                columns: table => new
                {
                    Codigo = table.Column<long>(nullable: false),
                    Descricao = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NCM", x => x.Codigo);
                });

            migrationBuilder.CreateTable(
                name: "Telefone",
                columns: table => new
                {
                    Id_telefone = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Telefones = table.Column<string>(maxLength: 14, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Telefone", x => x.Id_telefone);
                });

            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    Cpf = table.Column<string>(nullable: false),
                    Nome = table.Column<string>(maxLength: 80, nullable: false),
                    Email = table.Column<string>(maxLength: 60, nullable: false),
                    Telefone_Id_telefone = table.Column<int>(nullable: false),
                    Endereco_Id_Endereco = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.Cpf);
                    table.ForeignKey(
                        name: "FK_Cliente_Endereco_Endereco_Id_Endereco",
                        column: x => x.Endereco_Id_Endereco,
                        principalTable: "Endereco",
                        principalColumn: "Id_endereco",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cliente_Telefone_Telefone_Id_telefone",
                        column: x => x.Telefone_Id_telefone,
                        principalTable: "Telefone",
                        principalColumn: "Id_telefone",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Fornecedor",
                columns: table => new
                {
                    Cnpj = table.Column<string>(nullable: false),
                    Nome_empresa = table.Column<string>(maxLength: 80, nullable: false),
                    Email = table.Column<string>(maxLength: 60, nullable: false),
                    Inscricao_estadual = table.Column<string>(nullable: false),
                    Inscricao_municipal = table.Column<long>(nullable: false),
                    Telefone_Id_telefone = table.Column<int>(nullable: false),
                    Endereco_Id_Endereco = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fornecedor", x => x.Cnpj);
                    table.ForeignKey(
                        name: "FK_Fornecedor_Endereco_Endereco_Id_Endereco",
                        column: x => x.Endereco_Id_Endereco,
                        principalTable: "Endereco",
                        principalColumn: "Id_endereco",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Fornecedor_Telefone_Telefone_Id_telefone",
                        column: x => x.Telefone_Id_telefone,
                        principalTable: "Telefone",
                        principalColumn: "Id_telefone",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Funcionario",
                columns: table => new
                {
                    Cpf = table.Column<string>(nullable: false),
                    Nome = table.Column<string>(maxLength: 80, nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Cargo = table.Column<string>(maxLength: 45, nullable: false),
                    Data_nascimento = table.Column<DateTime>(nullable: false),
                    Senha = table.Column<string>(maxLength: 100, nullable: true),
                    Salario = table.Column<string>(maxLength: 10, nullable: false),
                    Status = table.Column<string>(maxLength: 45, nullable: false),
                    Endereco_Id_endereco = table.Column<int>(nullable: false),
                    Telefone_Id_telefone = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Funcionario", x => x.Cpf);
                    table.ForeignKey(
                        name: "FK_Funcionario_Endereco_Endereco_Id_endereco",
                        column: x => x.Endereco_Id_endereco,
                        principalTable: "Endereco",
                        principalColumn: "Id_endereco",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Funcionario_Telefone_Telefone_Id_telefone",
                        column: x => x.Telefone_Id_telefone,
                        principalTable: "Telefone",
                        principalColumn: "Id_telefone",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Produto",
                columns: table => new
                {
                    Id_produto = table.Column<int>(nullable: false),
                    Nome = table.Column<string>(maxLength: 80, nullable: false),
                    Valor_unitario = table.Column<string>(maxLength: 10, nullable: false),
                    Unidade_medida = table.Column<string>(maxLength: 60, nullable: false),
                    Descricao = table.Column<string>(nullable: false),
                    Estoque_minimo = table.Column<long>(nullable: false),
                    Estoque_maximo = table.Column<long>(nullable: false),
                    Estoque_atual = table.Column<long>(nullable: false),
                    Peso_bruto = table.Column<string>(nullable: false),
                    Peso_liquido = table.Column<string>(nullable: false),
                    Fornecedor_Cnpj = table.Column<string>(nullable: true),
                    CST_Codigo = table.Column<string>(nullable: true),
                    NCM_Codigo = table.Column<long>(nullable: false),
                    CFOP_Codigo = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produto", x => x.Id_produto);
                    table.ForeignKey(
                        name: "FK_Produto_CFOP_CFOP_Codigo",
                        column: x => x.CFOP_Codigo,
                        principalTable: "CFOP",
                        principalColumn: "Codigo",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Produto_CST_CST_Codigo",
                        column: x => x.CST_Codigo,
                        principalTable: "CST",
                        principalColumn: "Codigo",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Produto_Fornecedor_Fornecedor_Cnpj",
                        column: x => x.Fornecedor_Cnpj,
                        principalTable: "Fornecedor",
                        principalColumn: "Cnpj",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Produto_NCM_NCM_Codigo",
                        column: x => x.NCM_Codigo,
                        principalTable: "NCM",
                        principalColumn: "Codigo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cotacao",
                columns: table => new
                {
                    Id_cotacao = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Data_venda = table.Column<DateTime>(nullable: false),
                    Valor_total = table.Column<decimal>(type: "decimal(10, 2)", nullable: false),
                    Funcionario_Cpf = table.Column<string>(nullable: true),
                    Cliente_Cpf = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cotacao", x => x.Id_cotacao);
                    table.ForeignKey(
                        name: "FK_Cotacao_Cliente_Cliente_Cpf",
                        column: x => x.Cliente_Cpf,
                        principalTable: "Cliente",
                        principalColumn: "Cpf",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Cotacao_Funcionario_Funcionario_Cpf",
                        column: x => x.Funcionario_Cpf,
                        principalTable: "Funcionario",
                        principalColumn: "Cpf",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HistoricoSalario",
                columns: table => new
                {
                    Id_historicoSalario = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Data_inicio = table.Column<DateTime>(nullable: true),
                    Data_final = table.Column<DateTime>(nullable: true),
                    Funcionario_Cpf = table.Column<string>(nullable: true),
                    Salario = table.Column<string>(nullable: true),
                    Cargo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistoricoSalario", x => x.Id_historicoSalario);
                    table.ForeignKey(
                        name: "FK_HistoricoSalario_Funcionario_Funcionario_Cpf",
                        column: x => x.Funcionario_Cpf,
                        principalTable: "Funcionario",
                        principalColumn: "Cpf",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HistoricoStatus",
                columns: table => new
                {
                    Id_historicoStatus = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Data_inicio = table.Column<DateTime>(nullable: true),
                    Data_final = table.Column<DateTime>(nullable: true),
                    Funcionario_Cpf = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistoricoStatus", x => x.Id_historicoStatus);
                    table.ForeignKey(
                        name: "FK_HistoricoStatus_Funcionario_Funcionario_Cpf",
                        column: x => x.Funcionario_Cpf,
                        principalTable: "Funcionario",
                        principalColumn: "Cpf",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Venda",
                columns: table => new
                {
                    Id_venda = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Data_venda = table.Column<DateTime>(nullable: false),
                    Valor_total = table.Column<decimal>(type: "decimal(10, 2)", nullable: false),
                    Funcionario_Cpf = table.Column<string>(nullable: true),
                    Cliente_Cpf = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Venda", x => x.Id_venda);
                    table.ForeignKey(
                        name: "FK_Venda_Cliente_Cliente_Cpf",
                        column: x => x.Cliente_Cpf,
                        principalTable: "Cliente",
                        principalColumn: "Cpf",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Venda_Funcionario_Funcionario_Cpf",
                        column: x => x.Funcionario_Cpf,
                        principalTable: "Funcionario",
                        principalColumn: "Cpf",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Historico",
                columns: table => new
                {
                    Id_historico = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Data_inicio = table.Column<DateTime>(nullable: true),
                    Data_final = table.Column<DateTime>(nullable: true),
                    Produto_Id_produto = table.Column<int>(nullable: false),
                    Valor = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Historico", x => x.Id_historico);
                    table.ForeignKey(
                        name: "FK_Historico_Produto_Produto_Id_produto",
                        column: x => x.Produto_Id_produto,
                        principalTable: "Produto",
                        principalColumn: "Id_produto",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CotacaoProduto",
                columns: table => new
                {
                    Id_vendaProduto = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantidade = table.Column<int>(nullable: false),
                    Valor_unitario = table.Column<string>(nullable: true),
                    Valor = table.Column<decimal>(type: "decimal(10, 2)", nullable: false),
                    Cotacao_Id_cotacao = table.Column<int>(nullable: false),
                    Produto_Id_produto = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CotacaoProduto", x => x.Id_vendaProduto);
                    table.ForeignKey(
                        name: "FK_CotacaoProduto_Cotacao_Cotacao_Id_cotacao",
                        column: x => x.Cotacao_Id_cotacao,
                        principalTable: "Cotacao",
                        principalColumn: "Id_cotacao",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CotacaoProduto_Produto_Produto_Id_produto",
                        column: x => x.Produto_Id_produto,
                        principalTable: "Produto",
                        principalColumn: "Id_produto",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VendaProduto",
                columns: table => new
                {
                    Id_vendaProduto = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantidade = table.Column<int>(nullable: false),
                    Valor_unitario = table.Column<string>(nullable: true),
                    Valor = table.Column<decimal>(type: "decimal(10, 2)", nullable: false),
                    Venda_Id_venda = table.Column<int>(nullable: false),
                    Produto_Id_produto = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VendaProduto", x => x.Id_vendaProduto);
                    table.ForeignKey(
                        name: "FK_VendaProduto_Produto_Produto_Id_produto",
                        column: x => x.Produto_Id_produto,
                        principalTable: "Produto",
                        principalColumn: "Id_produto",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VendaProduto_Venda_Venda_Id_venda",
                        column: x => x.Venda_Id_venda,
                        principalTable: "Venda",
                        principalColumn: "Id_venda",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_Endereco_Id_Endereco",
                table: "Cliente",
                column: "Endereco_Id_Endereco");

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_Telefone_Id_telefone",
                table: "Cliente",
                column: "Telefone_Id_telefone");

            migrationBuilder.CreateIndex(
                name: "IX_Cotacao_Cliente_Cpf",
                table: "Cotacao",
                column: "Cliente_Cpf");

            migrationBuilder.CreateIndex(
                name: "IX_Cotacao_Funcionario_Cpf",
                table: "Cotacao",
                column: "Funcionario_Cpf");

            migrationBuilder.CreateIndex(
                name: "IX_CotacaoProduto_Cotacao_Id_cotacao",
                table: "CotacaoProduto",
                column: "Cotacao_Id_cotacao");

            migrationBuilder.CreateIndex(
                name: "IX_CotacaoProduto_Produto_Id_produto",
                table: "CotacaoProduto",
                column: "Produto_Id_produto");

            migrationBuilder.CreateIndex(
                name: "IX_Fornecedor_Endereco_Id_Endereco",
                table: "Fornecedor",
                column: "Endereco_Id_Endereco");

            migrationBuilder.CreateIndex(
                name: "IX_Fornecedor_Telefone_Id_telefone",
                table: "Fornecedor",
                column: "Telefone_Id_telefone");

            migrationBuilder.CreateIndex(
                name: "IX_Funcionario_Endereco_Id_endereco",
                table: "Funcionario",
                column: "Endereco_Id_endereco");

            migrationBuilder.CreateIndex(
                name: "IX_Funcionario_Telefone_Id_telefone",
                table: "Funcionario",
                column: "Telefone_Id_telefone");

            migrationBuilder.CreateIndex(
                name: "IX_Historico_Produto_Id_produto",
                table: "Historico",
                column: "Produto_Id_produto");

            migrationBuilder.CreateIndex(
                name: "IX_HistoricoSalario_Funcionario_Cpf",
                table: "HistoricoSalario",
                column: "Funcionario_Cpf");

            migrationBuilder.CreateIndex(
                name: "IX_HistoricoStatus_Funcionario_Cpf",
                table: "HistoricoStatus",
                column: "Funcionario_Cpf");

            migrationBuilder.CreateIndex(
                name: "IX_Produto_CFOP_Codigo",
                table: "Produto",
                column: "CFOP_Codigo");

            migrationBuilder.CreateIndex(
                name: "IX_Produto_CST_Codigo",
                table: "Produto",
                column: "CST_Codigo");

            migrationBuilder.CreateIndex(
                name: "IX_Produto_Fornecedor_Cnpj",
                table: "Produto",
                column: "Fornecedor_Cnpj");

            migrationBuilder.CreateIndex(
                name: "IX_Produto_NCM_Codigo",
                table: "Produto",
                column: "NCM_Codigo");

            migrationBuilder.CreateIndex(
                name: "IX_Venda_Cliente_Cpf",
                table: "Venda",
                column: "Cliente_Cpf");

            migrationBuilder.CreateIndex(
                name: "IX_Venda_Funcionario_Cpf",
                table: "Venda",
                column: "Funcionario_Cpf");

            migrationBuilder.CreateIndex(
                name: "IX_VendaProduto_Produto_Id_produto",
                table: "VendaProduto",
                column: "Produto_Id_produto");

            migrationBuilder.CreateIndex(
                name: "IX_VendaProduto_Venda_Id_venda",
                table: "VendaProduto",
                column: "Venda_Id_venda");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CotacaoProduto");

            migrationBuilder.DropTable(
                name: "Historico");

            migrationBuilder.DropTable(
                name: "HistoricoSalario");

            migrationBuilder.DropTable(
                name: "HistoricoStatus");

            migrationBuilder.DropTable(
                name: "VendaProduto");

            migrationBuilder.DropTable(
                name: "Cotacao");

            migrationBuilder.DropTable(
                name: "Produto");

            migrationBuilder.DropTable(
                name: "Venda");

            migrationBuilder.DropTable(
                name: "CFOP");

            migrationBuilder.DropTable(
                name: "CST");

            migrationBuilder.DropTable(
                name: "Fornecedor");

            migrationBuilder.DropTable(
                name: "NCM");

            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "Funcionario");

            migrationBuilder.DropTable(
                name: "Endereco");

            migrationBuilder.DropTable(
                name: "Telefone");
        }
    }
}
