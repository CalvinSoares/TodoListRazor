﻿using Microsoft.EntityFrameworkCore;
using TodoList.Models;

namespace TodoList.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Tarefa> Tarefas { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Status> statuses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categoria>().HasData(
                    new Categoria { CategoriaId = "trabalho", Nome = "Trabalho"},
                    new Categoria { CategoriaId = "casa", Nome = "Casa" },
                    new Categoria { CategoriaId = "facul", Nome = "Facul" },
                    new Categoria { CategoriaId = "compras", Nome = "Compras" },
                    new Categoria { CategoriaId = "academia", Nome = "Academia" }
                );
            modelBuilder.Entity<Status>().HasData(
                    new Status { StatusId = "aberto", Nome = "Aberto"},
                    new Status { StatusId = "completo", Nome = "Completo" }
                );

            base.OnModelCreating(modelBuilder);
        }
    }
}