﻿// <auto-generated />
using GAM.Data;
using GAM.Models.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace GAM.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GAM.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
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

            modelBuilder.Entity("GAM.Models.Casal", b =>
                {
                    b.Property<int>("CasalID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AlturaHomem");

                    b.Property<int>("AlturaMulher");

                    b.Property<string>("CorCabeloHomem")
                        .HasMaxLength(20);

                    b.Property<string>("CorCabeloMulher")
                        .HasMaxLength(20);

                    b.Property<string>("CorOlhosHomem")
                        .HasMaxLength(20);

                    b.Property<string>("CorOlhosMulher")
                        .HasMaxLength(20);

                    b.Property<string>("CorPeleHomem")
                        .HasMaxLength(20);

                    b.Property<string>("CorPeleMulher")
                        .HasMaxLength(20);

                    b.Property<int>("GrupoSanguineoHomem");

                    b.Property<int>("GrupoSanguineoMulher");

                    b.Property<int>("IdadeHomem");

                    b.Property<int>("IdadeMulher");

                    b.Property<int>("NrFilhos");

                    b.Property<int>("OriginouGravidez");

                    b.Property<string>("RacaHomem")
                        .HasMaxLength(20);

                    b.Property<string>("RacaMulher")
                        .HasMaxLength(20);

                    b.Property<string>("TexturaCabeloHomem")
                        .HasMaxLength(20);

                    b.Property<string>("TexturaCabeloMulher")
                        .HasMaxLength(20);

                    b.HasKey("CasalID");

                    b.ToTable("Casal");
                });

            modelBuilder.Entity("GAM.Models.DadorViewModels.Consulta", b =>
                {
                    b.Property<int>("ConsultaId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("DadorId");

                    b.Property<DateTime>("DataConsulta");

                    b.HasKey("ConsultaId");

                    b.HasIndex("DadorId");

                    b.ToTable("Consulta");
                });

            modelBuilder.Entity("GAM.Models.DadorViewModels.Dador", b =>
                {
                    b.Property<int>("DadorId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Altura");

                    b.Property<string>("CorCabelo")
                        .HasMaxLength(256);

                    b.Property<string>("CorOlhos")
                        .HasMaxLength(256);

                    b.Property<string>("CorPele")
                        .HasMaxLength(256);

                    b.Property<int>("DadosDador");

                    b.Property<DateTime>("DataNasc");

                    b.Property<string>("DocIdentificacao")
                        .HasMaxLength(256);

                    b.Property<int>("EstadoCivil");

                    b.Property<int>("EstadoDador");

                    b.Property<string>("Etnia")
                        .HasMaxLength(256);

                    b.Property<int>("FaseDador");

                    b.Property<int>("GrauEscolaridade");

                    b.Property<int>("GrupoSanguineo");

                    b.Property<string>("IniciaisDador")
                        .HasMaxLength(256);

                    b.Property<string>("LocalNasc")
                        .HasMaxLength(256);

                    b.Property<string>("Morada")
                        .HasMaxLength(256);

                    b.Property<string>("Nacionalidade")
                        .HasMaxLength(256);

                    b.Property<string>("Nome")
                        .HasMaxLength(256);

                    b.Property<int>("NumAbortos");

                    b.Property<int>("NumFilhos");

                    b.Property<float>("Peso");

                    b.Property<string>("Profissao")
                        .HasMaxLength(256);

                    b.Property<string>("TexturaCabelo")
                        .HasMaxLength(256);

                    b.Property<int>("TotalGestacoes");

                    b.HasKey("DadorId");

                    b.ToTable("Dador");
                });

            modelBuilder.Entity("GAM.Models.Laboratorio.Amostra", b =>
                {
                    b.Property<int>("AmostraId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("DadorId");

                    b.Property<DateTime>("DataRecolha");

                    b.Property<int>("EstadoAmostra");

                    b.Property<int>("TipoAmostra");

                    b.HasKey("AmostraId");

                    b.HasIndex("DadorId");

                    b.ToTable("Amostra");
                });

            modelBuilder.Entity("GAM.Models.Laboratorio.Analise", b =>
                {
                    b.Property<int>("AnaliseId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AmostraId");

                    b.Property<DateTime>("Data");

                    b.Property<string>("Nome")
                        .HasMaxLength(100);

                    b.Property<int>("ResultadoAnaliseId");

                    b.HasKey("AnaliseId");

                    b.HasIndex("AmostraId");

                    b.HasIndex("ResultadoAnaliseId");

                    b.ToTable("Analise");
                });

            modelBuilder.Entity("GAM.Models.Laboratorio.Espermograma", b =>
                {
                    b.Property<int>("EspermogramaId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AmostraId");

                    b.Property<float>("ConcentracaoEspermatozoides");

                    b.Property<string>("Cor")
                        .HasMaxLength(20);

                    b.Property<DateTime>("DataEspermograma");

                    b.Property<int>("GrauA");

                    b.Property<int>("GrauB");

                    b.Property<int>("GrauC");

                    b.Property<int>("GrauD");

                    b.Property<float>("Leucocitos");

                    b.Property<string>("Liquefacao")
                        .HasMaxLength(50);

                    b.Property<string>("Observacoes")
                        .HasMaxLength(250);

                    b.Property<string>("ObservacoesConcentracao")
                        .HasMaxLength(250);

                    b.Property<float>("Ph");

                    b.Property<int>("ValidacaoDiretorLaboratorio");

                    b.Property<int>("ValidacaoEmbriologista");

                    b.Property<string>("Viscosidade")
                        .HasMaxLength(50);

                    b.Property<int>("Vitalidade");

                    b.Property<float>("Volume");

                    b.HasKey("EspermogramaId");

                    b.HasIndex("AmostraId")
                        .IsUnique();

                    b.ToTable("Espermograma");
                });

            modelBuilder.Entity("GAM.Models.Laboratorio.LocalizacaoAmostra", b =>
                {
                    b.Property<int>("LocalizacaoAmostraId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("AmostraId");

                    b.Property<string>("Banco");

                    b.Property<int>("Cannister");

                    b.Property<string>("GlobetCor");

                    b.Property<int>("GlobetNumero");

                    b.Property<string>("PalhetaCor");

                    b.Property<string>("Piso");

                    b.HasKey("LocalizacaoAmostraId");

                    b.HasIndex("AmostraId")
                        .IsUnique()
                        .HasFilter("[AmostraId] IS NOT NULL");

                    b.ToTable("LocalizacaoAmostra");
                });

            modelBuilder.Entity("GAM.Models.Laboratorio.Metodo", b =>
                {
                    b.Property<int>("MetodoId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AnaliseId");

                    b.Property<string>("InterpretacaoNeg");

                    b.Property<string>("InterpretacaoPos");

                    b.Property<string>("Nome");

                    b.Property<string>("Resultado");

                    b.Property<float>("ResultadoNumerico");

                    b.Property<float>("ValorReferenciaNeg");

                    b.Property<float>("ValorReferenciaPos");

                    b.HasKey("MetodoId");

                    b.HasIndex("AnaliseId");

                    b.ToTable("Metodo");
                });

            modelBuilder.Entity("GAM.Models.Laboratorio.ResultadoAnalise", b =>
                {
                    b.Property<int>("ResultadoAnaliseId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Data");

                    b.Property<string>("NomeEmbriologista")
                        .HasMaxLength(100);

                    b.Property<string>("NomeMedico")
                        .HasMaxLength(100);

                    b.Property<int>("ValidacaoLaboratorio");

                    b.Property<int>("ValidacaoMedico");

                    b.HasKey("ResultadoAnaliseId");

                    b.ToTable("ResultadoAnalise");
                });

            modelBuilder.Entity("GAM.Models.PedidoGametas", b =>
                {
                    b.Property<int>("PedidoGametasId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("AmostraId");

                    b.Property<int>("CasalId");

                    b.Property<string>("Centro");

                    b.Property<DateTime>("Data");

                    b.Property<int>("EstadoProcessoPedido");

                    b.Property<string>("RefExterna");

                    b.HasKey("PedidoGametasId");

                    b.HasIndex("AmostraId")
                        .IsUnique()
                        .HasFilter("[AmostraId] IS NOT NULL");

                    b.HasIndex("CasalId")
                        .IsUnique();

                    b.ToTable("PedidoGametas");
                });

            modelBuilder.Entity("GAM.Models.Questionarios.Pergunta", b =>
                {
                    b.Property<int>("PerguntaId")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Apagado");

                    b.Property<string>("Descricao");

                    b.Property<int>("QuestionarioId");

                    b.Property<int>("TipoResposta");

                    b.HasKey("PerguntaId");

                    b.HasIndex("QuestionarioId");

                    b.ToTable("Pergunta");
                });

            modelBuilder.Entity("GAM.Models.Questionarios.Questionario", b =>
                {
                    b.Property<int>("QuestionarioId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Area");

                    b.HasKey("QuestionarioId");

                    b.ToTable("Questionario");
                });

            modelBuilder.Entity("GAM.Models.Questionarios.Resposta", b =>
                {
                    b.Property<int>("RespostaId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("DadorId");

                    b.Property<int>("PerguntaId");

                    b.Property<string>("TextoResposta");

                    b.HasKey("RespostaId");

                    b.HasIndex("DadorId");

                    b.HasIndex("PerguntaId");

                    b.ToTable("Resposta");
                });

            modelBuilder.Entity("GAM.Models.RegistoMaterial.Material", b =>
                {
                    b.Property<int>("MaterialId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Categoria");

                    b.Property<int>("EspermogramaId");

                    b.Property<string>("Lote")
                        .HasMaxLength(20);

                    b.Property<string>("Nome")
                        .HasMaxLength(100);

                    b.Property<int>("QuantidadeUtilizada");

                    b.HasKey("MaterialId");

                    b.HasIndex("EspermogramaId");

                    b.ToTable("Material");
                });

            modelBuilder.Entity("GAM.Models.TestViewModels.Test", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Date");

                    b.Property<string>("Title");

                    b.HasKey("ID");

                    b.ToTable("Test");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
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
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("GAM.Models.DadorViewModels.Consulta", b =>
                {
                    b.HasOne("GAM.Models.DadorViewModels.Dador", "Dador")
                        .WithMany("Consultas")
                        .HasForeignKey("DadorId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("GAM.Models.Laboratorio.Amostra", b =>
                {
                    b.HasOne("GAM.Models.DadorViewModels.Dador", "Dador")
                        .WithMany("Amostras")
                        .HasForeignKey("DadorId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("GAM.Models.Laboratorio.Analise", b =>
                {
                    b.HasOne("GAM.Models.Laboratorio.Amostra", "Amostra")
                        .WithMany("Analise")
                        .HasForeignKey("AmostraId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("GAM.Models.Laboratorio.ResultadoAnalise", "ResultadoAnalise")
                        .WithMany("Analises")
                        .HasForeignKey("ResultadoAnaliseId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("GAM.Models.Laboratorio.Espermograma", b =>
                {
                    b.HasOne("GAM.Models.Laboratorio.Amostra", "Amostra")
                        .WithOne("Espermograma")
                        .HasForeignKey("GAM.Models.Laboratorio.Espermograma", "AmostraId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("GAM.Models.Laboratorio.LocalizacaoAmostra", b =>
                {
                    b.HasOne("GAM.Models.Laboratorio.Amostra", "Amostra")
                        .WithOne("LocalizacaoAmostra")
                        .HasForeignKey("GAM.Models.Laboratorio.LocalizacaoAmostra", "AmostraId");
                });

            modelBuilder.Entity("GAM.Models.Laboratorio.Metodo", b =>
                {
                    b.HasOne("GAM.Models.Laboratorio.Analise", "Analise")
                        .WithMany("Metodos")
                        .HasForeignKey("AnaliseId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("GAM.Models.PedidoGametas", b =>
                {
                    b.HasOne("GAM.Models.Laboratorio.Amostra", "Amostra")
                        .WithOne("PedidoGametas")
                        .HasForeignKey("GAM.Models.PedidoGametas", "AmostraId");

                    b.HasOne("GAM.Models.Casal", "Casal")
                        .WithOne("PedidoGametas")
                        .HasForeignKey("GAM.Models.PedidoGametas", "CasalId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("GAM.Models.Questionarios.Pergunta", b =>
                {
                    b.HasOne("GAM.Models.Questionarios.Questionario", "Questionario")
                        .WithMany("Perguntas")
                        .HasForeignKey("QuestionarioId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("GAM.Models.Questionarios.Resposta", b =>
                {
                    b.HasOne("GAM.Models.DadorViewModels.Dador", "Dador")
                        .WithMany("Resposta")
                        .HasForeignKey("DadorId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("GAM.Models.Questionarios.Pergunta", "Pergunta")
                        .WithMany("Respostas")
                        .HasForeignKey("PerguntaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("GAM.Models.RegistoMaterial.Material", b =>
                {
                    b.HasOne("GAM.Models.Laboratorio.Espermograma", "Espermograma")
                        .WithMany("Materiais")
                        .HasForeignKey("EspermogramaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("GAM.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("GAM.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("GAM.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("GAM.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
