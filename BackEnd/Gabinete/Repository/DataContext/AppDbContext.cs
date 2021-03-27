using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RepositoryModel.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.DataContext
{
    public class AppDbContext : IdentityDbContext<Usuario>
    {
        public DbSet<Comentario> Comentario { get; set; }
        public DbSet<Curso> Curso { get; set; }
        public DbSet<CursoInstructor> CursoInstructor { get; set; }
        public DbSet<Instructor> Instructor { get; set; }
        public DbSet<Precio> Precio { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options)
          :base(options)
        {
                
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<CursoInstructor>()
                .HasKey(x => new { x.Cursoid, x.InstructorId });
        }

    }
}
