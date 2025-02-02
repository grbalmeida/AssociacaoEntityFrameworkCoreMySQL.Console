﻿// <auto-generated />
using System;
using AssociacaoEntityFrameworkCore.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AssociacaoEntityFrameworkCore.Database.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20210910191207_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.9");

            modelBuilder.Entity("AssociacaoEntityFrameworkCoreMySQL.Models.Categoria", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.HasIndex("Nome")
                        .IsUnique();

                    b.ToTable("Categoria");
                });

            modelBuilder.Entity("AssociacaoEntityFrameworkCoreMySQL.Models.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CEP")
                        .IsRequired()
                        .HasColumnType("CHAR(8)");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("DATETIME");

                    b.Property<string>("Documento")
                        .IsRequired()
                        .HasColumnType("VARCHAR(20)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("CHAR(8)");

                    b.Property<string>("Fone")
                        .IsRequired()
                        .HasColumnType("VARCHAR(20)");

                    b.Property<string>("Imagem")
                        .HasColumnType("VARCHAR(100)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)");

                    b.Property<string>("Pais")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)");

                    b.HasKey("Id");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("AssociacaoEntityFrameworkCoreMySQL.Models.Emprestimo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ClienteId")
                        .HasColumnType("INT");

                    b.Property<DateTime?>("DataDevolucao")
                        .HasColumnType("DATETIME");

                    b.Property<DateTime>("DataEmprestimo")
                        .HasColumnType("DATETIME")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<DateTime?>("DataLimiteDevolucao")
                        .HasColumnType("DATETIME");

                    b.Property<int?>("EmprestimoAnteriorId")
                        .HasColumnType("INT");

                    b.Property<int>("ProdutoId")
                        .HasColumnType("INT");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("INT");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.HasIndex("EmprestimoAnteriorId");

                    b.HasIndex("ProdutoId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Emprestimo");

                    b.HasCheckConstraint("CH_DataLimiteDevolucao", "DataLimiteDevolucao > DataEmprestimo");

                    b.HasCheckConstraint("CH_DataDevolucao", "DataDevolucao > DataEmprestimo");
                });

            modelBuilder.Entity("AssociacaoEntityFrameworkCoreMySQL.Models.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<decimal>("Altura")
                        .HasColumnType("DECIMAL(4, 2)");

                    b.Property<ulong>("Ativo")
                        .HasColumnType("BIT");

                    b.Property<int>("CategoriaId")
                        .HasColumnType("INT");

                    b.Property<string>("Descricao")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Largura")
                        .HasColumnType("DECIMAL(4, 2)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)");

                    b.Property<decimal>("Profundidade")
                        .HasColumnType("DECIMAL(4, 2)");

                    b.Property<int>("QuantidadeEstoque")
                        .HasColumnType("INT");

                    b.Property<decimal>("Valor")
                        .HasColumnType("DECIMAL(10, 2)");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaId");

                    b.ToTable("Produto");
                });

            modelBuilder.Entity("AssociacaoEntityFrameworkCoreMySQL.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CEP")
                        .IsRequired()
                        .HasColumnType("CHAR(8)");

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasColumnType("VARCHAR(11)");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("DATETIME");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("CHAR(8)");

                    b.Property<string>("Fone")
                        .IsRequired()
                        .HasColumnType("VARCHAR(20)");

                    b.Property<string>("Imagem")
                        .HasColumnType("VARCHAR(100)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)");

                    b.Property<string>("Pais")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)");

                    b.HasKey("Id");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("AssociacaoEntityFrameworkCoreMySQL.Models.Emprestimo", b =>
                {
                    b.HasOne("AssociacaoEntityFrameworkCoreMySQL.Models.Cliente", "Cliente")
                        .WithMany("Emprestimos")
                        .HasForeignKey("ClienteId")
                        .HasConstraintName("FK_Cliente")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("AssociacaoEntityFrameworkCoreMySQL.Models.Emprestimo", "EmprestimoAnterior")
                        .WithMany("Emprestimos")
                        .HasForeignKey("EmprestimoAnteriorId")
                        .HasConstraintName("FK_EmprestimoAnterior")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.HasOne("AssociacaoEntityFrameworkCoreMySQL.Models.Produto", "Produto")
                        .WithMany("Emprestimos")
                        .HasForeignKey("ProdutoId")
                        .HasConstraintName("FK_Produto")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("AssociacaoEntityFrameworkCoreMySQL.Models.Usuario", "Usuario")
                        .WithMany("Emprestimos")
                        .HasForeignKey("UsuarioId")
                        .HasConstraintName("FK_Usuario")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("EmprestimoAnterior");

                    b.Navigation("Produto");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("AssociacaoEntityFrameworkCoreMySQL.Models.Produto", b =>
                {
                    b.HasOne("AssociacaoEntityFrameworkCoreMySQL.Models.Categoria", "Categoria")
                        .WithMany("Produtos")
                        .HasForeignKey("CategoriaId")
                        .HasConstraintName("FK_Categoria")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categoria");
                });

            modelBuilder.Entity("AssociacaoEntityFrameworkCoreMySQL.Models.Categoria", b =>
                {
                    b.Navigation("Produtos");
                });

            modelBuilder.Entity("AssociacaoEntityFrameworkCoreMySQL.Models.Cliente", b =>
                {
                    b.Navigation("Emprestimos");
                });

            modelBuilder.Entity("AssociacaoEntityFrameworkCoreMySQL.Models.Emprestimo", b =>
                {
                    b.Navigation("Emprestimos");
                });

            modelBuilder.Entity("AssociacaoEntityFrameworkCoreMySQL.Models.Produto", b =>
                {
                    b.Navigation("Emprestimos");
                });

            modelBuilder.Entity("AssociacaoEntityFrameworkCoreMySQL.Models.Usuario", b =>
                {
                    b.Navigation("Emprestimos");
                });
#pragma warning restore 612, 618
        }
    }
}
