using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ILikeCardGames.Models.Account;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace ILikeCardGames.Models
{
    public class ILikeCardGamesDbContext : DbContext
    {
        public ILikeCardGamesDbContext(DbContextOptions<ILikeCardGamesDbContext> context) : base(context)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetConnectionString("ILCGPrimary"));
        }

        public DbSet<ILikeCardGames.Models.Account.Account> Accounts { get; set; }
        public DbSet<AccountLoginInformation> AccountLoginInformations { get; set; }
    }
}
