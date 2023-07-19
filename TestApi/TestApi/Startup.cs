using TestApi.Models;
using Microsoft.EntityFrameworkCore;
namespace TestApi
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
            services.AddDbContext<UserContext>(options =>
                options.UseSqlite(Configuration.GetConnectionString("DefaultConnection")));
        }
    }
}

