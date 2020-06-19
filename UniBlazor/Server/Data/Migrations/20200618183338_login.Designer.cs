﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UniBlazor.Server.Data;

namespace UniBlazor.Server.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20200618183338_login")]
    partial class login
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("IdentityServer4.EntityFramework.Entities.DeviceFlowCodes", b =>
                {
                    b.Property<string>("UserCode")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("ClientId")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Data")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasMaxLength(50000);

                    b.Property<string>("DeviceCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<DateTime?>("Expiration")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<string>("SubjectId")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.HasKey("UserCode");

                    b.HasIndex("DeviceCode")
                        .IsUnique();

                    b.HasIndex("Expiration");

                    b.ToTable("DeviceCodes");
                });

            modelBuilder.Entity("IdentityServer4.EntityFramework.Entities.PersistedGrant", b =>
                {
                    b.Property<string>("Key")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("ClientId")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Data")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasMaxLength(50000);

                    b.Property<DateTime?>("Expiration")
                        .HasColumnType("datetime2");

                    b.Property<string>("SubjectId")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Key");

                    b.HasIndex("Expiration");

                    b.HasIndex("SubjectId", "ClientId", "Type");

                    b.ToTable("PersistedGrants");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("UniBlazor.Server.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("UniBlazor.Shared.Models.CFOP", b =>
                {
                    b.Property<long>("Codigo")
                        .HasColumnType("bigint");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Codigo");

                    b.ToTable("CFOP");
                });

            modelBuilder.Entity("UniBlazor.Shared.Models.CST", b =>
                {
                    b.Property<string>("Codigo")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Codigo");

                    b.ToTable("CST");
                });

            modelBuilder.Entity("UniBlazor.Shared.Models.Cliente", b =>
                {
                    b.Property<string>("Cpf")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(60)")
                        .HasMaxLength(60);

                    b.Property<int>("Endereco_Id_Endereco")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(80)")
                        .HasMaxLength(80);

                    b.Property<int>("Telefone_Id_telefone")
                        .HasColumnType("int");

                    b.HasKey("Cpf");

                    b.HasIndex("Endereco_Id_Endereco");

                    b.HasIndex("Telefone_Id_telefone");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("UniBlazor.Shared.Models.Cotacao", b =>
                {
                    b.Property<int>("Id_cotacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cliente_Cpf")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("Data_venda")
                        .HasColumnType("datetime2");

                    b.Property<string>("Funcionario_Cpf")
                        .HasColumnType("nvarchar(450)");

                    b.Property<decimal>("Valor_total")
                        .HasColumnType("decimal(10, 2)");

                    b.HasKey("Id_cotacao");

                    b.HasIndex("Cliente_Cpf");

                    b.HasIndex("Funcionario_Cpf");

                    b.ToTable("Cotacao");
                });

            modelBuilder.Entity("UniBlazor.Shared.Models.CotacaoProduto", b =>
                {
                    b.Property<int>("Id_vendaProduto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Cotacao_Id_cotacao")
                        .HasColumnType("int");

                    b.Property<int>("Produto_Id_produto")
                        .HasColumnType("int");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(10, 2)");

                    b.Property<string>("Valor_unitario")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id_vendaProduto");

                    b.HasIndex("Cotacao_Id_cotacao");

                    b.HasIndex("Produto_Id_produto");

                    b.ToTable("CotacaoProduto");
                });

            modelBuilder.Entity("UniBlazor.Shared.Models.Endereco", b =>
                {
                    b.Property<int>("Id_endereco")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasColumnType("nvarchar(45)")
                        .HasMaxLength(45);

                    b.Property<string>("Cep")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("nvarchar(45)")
                        .HasMaxLength(45);

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<int>("Numero")
                        .HasColumnType("int");

                    b.Property<string>("Rua")
                        .IsRequired()
                        .HasColumnType("nvarchar(60)")
                        .HasMaxLength(60);

                    b.HasKey("Id_endereco");

                    b.ToTable("Endereco");
                });

            modelBuilder.Entity("UniBlazor.Shared.Models.Fornecedor", b =>
                {
                    b.Property<string>("Cnpj")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(60)")
                        .HasMaxLength(60);

                    b.Property<int>("Endereco_Id_Endereco")
                        .HasColumnType("int");

                    b.Property<string>("Inscricao_estadual")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Inscricao_municipal")
                        .HasColumnType("bigint");

                    b.Property<string>("Nome_empresa")
                        .IsRequired()
                        .HasColumnType("nvarchar(80)")
                        .HasMaxLength(80);

                    b.Property<int>("Telefone_Id_telefone")
                        .HasColumnType("int");

                    b.HasKey("Cnpj");

                    b.HasIndex("Endereco_Id_Endereco");

                    b.HasIndex("Telefone_Id_telefone");

                    b.ToTable("Fornecedor");
                });

            modelBuilder.Entity("UniBlazor.Shared.Models.Funcionario", b =>
                {
                    b.Property<string>("Cpf")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Cargo")
                        .IsRequired()
                        .HasColumnType("nvarchar(45)")
                        .HasMaxLength(45);

                    b.Property<DateTime?>("Data_nascimento")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Endereco_Id_endereco")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(80)")
                        .HasMaxLength(80);

                    b.Property<string>("Salario")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<string>("Senha")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(45)")
                        .HasMaxLength(45);

                    b.Property<int>("Telefone_Id_telefone")
                        .HasColumnType("int");

                    b.HasKey("Cpf");

                    b.HasIndex("Endereco_Id_endereco");

                    b.HasIndex("Telefone_Id_telefone");

                    b.ToTable("Funcionario");
                });

            modelBuilder.Entity("UniBlazor.Shared.Models.Historico", b =>
                {
                    b.Property<int>("Id_historico")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("Data_final")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Data_inicio")
                        .HasColumnType("datetime2");

                    b.Property<int>("Produto_Id_produto")
                        .HasColumnType("int");

                    b.Property<string>("Valor")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id_historico");

                    b.HasIndex("Produto_Id_produto");

                    b.ToTable("Historico");
                });

            modelBuilder.Entity("UniBlazor.Shared.Models.HistoricoSalario", b =>
                {
                    b.Property<int>("Id_historicoSalario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cargo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Data_final")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Data_inicio")
                        .HasColumnType("datetime2");

                    b.Property<string>("Funcionario_Cpf")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Salario")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id_historicoSalario");

                    b.HasIndex("Funcionario_Cpf");

                    b.ToTable("HistoricoSalario");
                });

            modelBuilder.Entity("UniBlazor.Shared.Models.HistoricoStatus", b =>
                {
                    b.Property<int>("Id_historicoStatus")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("Data_final")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Data_inicio")
                        .HasColumnType("datetime2");

                    b.Property<string>("Funcionario_Cpf")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id_historicoStatus");

                    b.HasIndex("Funcionario_Cpf");

                    b.ToTable("HistoricoStatus");
                });

            modelBuilder.Entity("UniBlazor.Shared.Models.NCM", b =>
                {
                    b.Property<long>("Codigo")
                        .HasColumnType("bigint");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Codigo");

                    b.ToTable("NCM");
                });

            modelBuilder.Entity("UniBlazor.Shared.Models.Produto", b =>
                {
                    b.Property<int>("Id_produto")
                        .HasColumnType("int");

                    b.Property<long>("CFOP_Codigo")
                        .HasColumnType("bigint");

                    b.Property<string>("CST_Codigo")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Estoque_atual")
                        .HasColumnType("bigint");

                    b.Property<long>("Estoque_maximo")
                        .HasColumnType("bigint");

                    b.Property<long>("Estoque_minimo")
                        .HasColumnType("bigint");

                    b.Property<string>("Fornecedor_Cnpj")
                        .HasColumnType("nvarchar(450)");

                    b.Property<long>("NCM_Codigo")
                        .HasColumnType("bigint");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(80)")
                        .HasMaxLength(80);

                    b.Property<string>("Peso_bruto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Peso_liquido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Unidade_medida")
                        .IsRequired()
                        .HasColumnType("nvarchar(60)")
                        .HasMaxLength(60);

                    b.Property<string>("Valor_unitario")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.HasKey("Id_produto");

                    b.HasIndex("CFOP_Codigo");

                    b.HasIndex("CST_Codigo");

                    b.HasIndex("Fornecedor_Cnpj");

                    b.HasIndex("NCM_Codigo");

                    b.ToTable("Produto");
                });

            modelBuilder.Entity("UniBlazor.Shared.Models.Telefone", b =>
                {
                    b.Property<int>("Id_telefone")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Telefones")
                        .IsRequired()
                        .HasColumnType("nvarchar(14)")
                        .HasMaxLength(14);

                    b.HasKey("Id_telefone");

                    b.ToTable("Telefone");
                });

            modelBuilder.Entity("UniBlazor.Shared.Models.Venda", b =>
                {
                    b.Property<int>("Id_venda")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cliente_Cpf")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("Data_venda")
                        .HasColumnType("datetime2");

                    b.Property<string>("Funcionario_Cpf")
                        .HasColumnType("nvarchar(450)");

                    b.Property<decimal>("Valor_total")
                        .HasColumnType("decimal(10, 2)");

                    b.HasKey("Id_venda");

                    b.HasIndex("Cliente_Cpf");

                    b.HasIndex("Funcionario_Cpf");

                    b.ToTable("Venda");
                });

            modelBuilder.Entity("UniBlazor.Shared.Models.VendaProduto", b =>
                {
                    b.Property<int>("Id_vendaProduto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Produto_Id_produto")
                        .HasColumnType("int");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(10, 2)");

                    b.Property<string>("Valor_unitario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Venda_Id_venda")
                        .HasColumnType("int");

                    b.HasKey("Id_vendaProduto");

                    b.HasIndex("Produto_Id_produto");

                    b.HasIndex("Venda_Id_venda");

                    b.ToTable("VendaProduto");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("UniBlazor.Server.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("UniBlazor.Server.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UniBlazor.Server.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("UniBlazor.Server.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("UniBlazor.Shared.Models.Cliente", b =>
                {
                    b.HasOne("UniBlazor.Shared.Models.Endereco", "Endereco")
                        .WithMany()
                        .HasForeignKey("Endereco_Id_Endereco")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UniBlazor.Shared.Models.Telefone", "Telefone")
                        .WithMany()
                        .HasForeignKey("Telefone_Id_telefone")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("UniBlazor.Shared.Models.Cotacao", b =>
                {
                    b.HasOne("UniBlazor.Shared.Models.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("Cliente_Cpf");

                    b.HasOne("UniBlazor.Shared.Models.Funcionario", "Funcionario")
                        .WithMany()
                        .HasForeignKey("Funcionario_Cpf");
                });

            modelBuilder.Entity("UniBlazor.Shared.Models.CotacaoProduto", b =>
                {
                    b.HasOne("UniBlazor.Shared.Models.Cotacao", "Cotacao")
                        .WithMany("CotacaoProdutos")
                        .HasForeignKey("Cotacao_Id_cotacao")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UniBlazor.Shared.Models.Produto", "Produto")
                        .WithMany()
                        .HasForeignKey("Produto_Id_produto")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("UniBlazor.Shared.Models.Fornecedor", b =>
                {
                    b.HasOne("UniBlazor.Shared.Models.Endereco", "Endereco")
                        .WithMany()
                        .HasForeignKey("Endereco_Id_Endereco")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UniBlazor.Shared.Models.Telefone", "Telefone")
                        .WithMany()
                        .HasForeignKey("Telefone_Id_telefone")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("UniBlazor.Shared.Models.Funcionario", b =>
                {
                    b.HasOne("UniBlazor.Shared.Models.Endereco", "Endereco")
                        .WithMany()
                        .HasForeignKey("Endereco_Id_endereco")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UniBlazor.Shared.Models.Telefone", "Telefone")
                        .WithMany()
                        .HasForeignKey("Telefone_Id_telefone")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("UniBlazor.Shared.Models.Historico", b =>
                {
                    b.HasOne("UniBlazor.Shared.Models.Produto", "Produto")
                        .WithMany()
                        .HasForeignKey("Produto_Id_produto")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("UniBlazor.Shared.Models.HistoricoSalario", b =>
                {
                    b.HasOne("UniBlazor.Shared.Models.Funcionario", "Funcionario")
                        .WithMany()
                        .HasForeignKey("Funcionario_Cpf");
                });

            modelBuilder.Entity("UniBlazor.Shared.Models.HistoricoStatus", b =>
                {
                    b.HasOne("UniBlazor.Shared.Models.Funcionario", "Funcionario")
                        .WithMany()
                        .HasForeignKey("Funcionario_Cpf");
                });

            modelBuilder.Entity("UniBlazor.Shared.Models.Produto", b =>
                {
                    b.HasOne("UniBlazor.Shared.Models.CFOP", "CFOP")
                        .WithMany()
                        .HasForeignKey("CFOP_Codigo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UniBlazor.Shared.Models.CST", "CST")
                        .WithMany()
                        .HasForeignKey("CST_Codigo");

                    b.HasOne("UniBlazor.Shared.Models.Fornecedor", "Fornecedor")
                        .WithMany()
                        .HasForeignKey("Fornecedor_Cnpj");

                    b.HasOne("UniBlazor.Shared.Models.NCM", "NCM")
                        .WithMany()
                        .HasForeignKey("NCM_Codigo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("UniBlazor.Shared.Models.Venda", b =>
                {
                    b.HasOne("UniBlazor.Shared.Models.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("Cliente_Cpf");

                    b.HasOne("UniBlazor.Shared.Models.Funcionario", "Funcionario")
                        .WithMany()
                        .HasForeignKey("Funcionario_Cpf");
                });

            modelBuilder.Entity("UniBlazor.Shared.Models.VendaProduto", b =>
                {
                    b.HasOne("UniBlazor.Shared.Models.Produto", "Produto")
                        .WithMany()
                        .HasForeignKey("Produto_Id_produto")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UniBlazor.Shared.Models.Venda", "Venda")
                        .WithMany("VendaProdutos")
                        .HasForeignKey("Venda_Id_venda")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
