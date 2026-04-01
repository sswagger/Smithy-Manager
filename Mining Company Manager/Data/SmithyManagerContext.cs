using Microsoft.EntityFrameworkCore;
using SmithyManager.Models;
using System.Configuration;

namespace SmithyManager.Data {
	internal class SmithyManagerContext : DbContext {
		public virtual DbSet<Mine> Mines { get; set; }
		public virtual DbSet<Shop> Shops { get; set; }
		public virtual DbSet<Miner> Miners { get; set; }
		public virtual DbSet<Craftsman> Craftsmen { get; set; }
		public virtual DbSet<Mineral> Minerals { get; set; }
		public virtual DbSet<Gem> Gems { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
			=> optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["SmithyManagerDB"].ConnectionString);
	}
}
