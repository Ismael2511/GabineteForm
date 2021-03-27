using Microsoft.EntityFrameworkCore;
using RepositoryModel.Model.gabineteDB;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.DataContext
{
    public class gabineteDbContext: DbContext
    {
        public DbSet<mae_persona> mae_persona { get; set; }
        public gabineteDbContext(DbContextOptions<gabineteDbContext> options) :base(options)
        {

        }
    }
}
