using Aprel22.Data.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aprel22.Data
{
    public class StadionDbContext:DbContext
    {
        public DbSet<Stadions> Stadion { get; set; }
        public DbSet<Users> User { get; set; }
        public DbSet<Reservations> Reservation { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-0UDOH5O;Database=TaskTable;Trusted_Connection=TRUE");
        }
    }
}
