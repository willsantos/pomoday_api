﻿using Microsoft.EntityFrameworkCore;
using Pomoday.Domain.Entities;
using Pomoday.Repository.Mappings;

namespace Pomoday.Repository.Context
{
    public class PomodayContext : DbContext
    {
        public DbSet<Tarefa> Tarefas { get; set; }
        public DbSet<Projeto> Projetos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Registro> Registros { get; set; }

        public PomodayContext(DbContextOptions<PomodayContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tarefa>(new TarefaMap().Configure);
            modelBuilder.Entity<Projeto>(new ProjetoMap().Configure);
            modelBuilder.Entity<Usuario>(new UsuarioMap().Configure);
            modelBuilder.Entity<Registro>(new RegistroMap().Configure);
        }
    }
}
