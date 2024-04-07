using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext() : base("name=MyDbContext")
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Equipment> Equipment { get; set; }
        public DbSet<Filial> Filial { get; set; }
        public DbSet<History> History { get; set; }
        public DbSet<Inventory> Inventory { get; set; }
        public DbSet<Profile> Profile { get; set; }
        // Добавьте другие DbSet для ваших моделей
    }
}