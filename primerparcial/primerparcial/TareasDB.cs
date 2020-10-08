using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace primerparcial
{
    class TareasDB : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=tareas.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>()
            .ToTable("Usuario")
            .Property(p => p.Clave);
            modelBuilder.Entity<Tarea>()
            .ToTable("Tarea");
        }
    }
}
