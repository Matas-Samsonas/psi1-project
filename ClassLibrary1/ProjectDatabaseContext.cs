using ProfileClasses;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;
using Microsoft.Extensions.Options;

namespace ClassLibrary
{
    public class ProjectDatabaseContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=localhost;Database={};Port={};User Id={};Password={}");
        }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Profile> Profiles { get; set; }
        public DbSet<Distributor> Distributors { get; set; }
        public DbSet<Advertisement> Advertisements { get; set; }

    }
}
