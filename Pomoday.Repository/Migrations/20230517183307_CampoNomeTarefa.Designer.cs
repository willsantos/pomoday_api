﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Pomoday.Repository.Context;

#nullable disable

namespace Pomoday.Repository.Migrations
{
    [DbContext(typeof(PomodayContext))]
    [Migration("20230517183307_CampoNomeTarefa")]
    partial class CampoNomeTarefa
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Pomoday.Domain.Entities.Projeto", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime?>("AlteradoEm")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("Ativo")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("CriadoEm")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("DeletadoEm")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("Prazo")
                        .HasColumnType("datetime(6)");

                    b.Property<float?>("Progresso")
                        .HasColumnType("float");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<Guid>("UsuarioId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Projetos");
                });

            modelBuilder.Entity("Pomoday.Domain.Entities.Registro", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime?>("AlteradoEm")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("Ativo")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("CriadoEm")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("DeletadoEm")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid>("TarefaId")
                        .HasColumnType("char(36)");

                    b.Property<TimeSpan?>("TempoGasto")
                        .HasColumnType("time(6)");

                    b.HasKey("Id");

                    b.HasIndex("TarefaId");

                    b.ToTable("Registros");
                });

            modelBuilder.Entity("Pomoday.Domain.Entities.Tarefa", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime?>("Agendada")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("AlteradoEm")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("Ativo")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("CriadoEm")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("DeletadoEm")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("Prazo")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("Prioridade")
                        .HasColumnType("int");

                    b.Property<Guid>("ProjetoId")
                        .HasColumnType("char(36)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<TimeSpan?>("TempoGasto")
                        .HasColumnType("time(6)");

                    b.Property<Guid>("UsuarioId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("ProjetoId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Tarefas");
                });

            modelBuilder.Entity("Pomoday.Domain.Entities.Usuario", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime?>("AlteradoEm")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("Ativo")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("CriadoEm")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("DeletadoEm")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("Pomoday.Domain.Entities.Projeto", b =>
                {
                    b.HasOne("Pomoday.Domain.Entities.Usuario", "Usuario")
                        .WithMany("Projetos")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Pomoday.Domain.Entities.Registro", b =>
                {
                    b.HasOne("Pomoday.Domain.Entities.Tarefa", "Tarefa")
                        .WithMany("Registros")
                        .HasForeignKey("TarefaId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Tarefa");
                });

            modelBuilder.Entity("Pomoday.Domain.Entities.Tarefa", b =>
                {
                    b.HasOne("Pomoday.Domain.Entities.Projeto", "Projeto")
                        .WithMany("Tarefas")
                        .HasForeignKey("ProjetoId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Pomoday.Domain.Entities.Usuario", "Usuario")
                        .WithMany("Tarefas")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Projeto");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Pomoday.Domain.Entities.Projeto", b =>
                {
                    b.Navigation("Tarefas");
                });

            modelBuilder.Entity("Pomoday.Domain.Entities.Tarefa", b =>
                {
                    b.Navigation("Registros");
                });

            modelBuilder.Entity("Pomoday.Domain.Entities.Usuario", b =>
                {
                    b.Navigation("Projetos");

                    b.Navigation("Tarefas");
                });
#pragma warning restore 612, 618
        }
    }
}
