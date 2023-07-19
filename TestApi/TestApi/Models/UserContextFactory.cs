using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using TestApi.Models;

public class UserContextFactory : IDesignTimeDbContextFactory<UserContext>
{
    public UserContext CreateDbContext(string[] args)
    {
        IConfigurationRoot configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();

        //var optionsBuilder = new DbContextOptionsBuilder<UserContext>();
        //optionsBuilder.UseSqlite(configuration.GetConnectionString("DefaultConnection"));

       // return new UserContext(optionsBuilder.Options);
    }
}
