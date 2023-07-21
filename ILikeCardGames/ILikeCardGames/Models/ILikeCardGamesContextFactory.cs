using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.Configuration;

namespace ILikeCardGames.Models
{
    public class ILikeCardGamesContextFactory : IDesignTimeDbContextFactory<ILikeCardGamesDbContext>
    {
        public ILikeCardGamesDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ILikeCardGamesDbContext>();
            optionsBuilder.UseSqlServer(new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetConnectionString("ILCGPrimary"));

            return new ILikeCardGamesDbContext(optionsBuilder.Options);
        }
    }
}
