using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MiniCoreSahidCarchi.Models;

namespace MiniCoreSahidCarchi.Data
{
    public class MiniCoreSahidCarchiContext : DbContext
    {
        public MiniCoreSahidCarchiContext (DbContextOptions<MiniCoreSahidCarchiContext> options) : base(options) { }

        public DbSet<Cliente> Clientes { get; set; } = default!;

        public DbSet<Contrato> Contratos { get; set; }
        public DbSet<Total> vw_Contratos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Total>().HasNoKey();
        }
    }
}
