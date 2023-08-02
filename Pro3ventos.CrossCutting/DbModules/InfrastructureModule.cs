using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Pro3ventos.Data.Input.DataContext;

namespace Pro3ventos.CrossCutting.DbModules
{
    public static class InfrastructureModule
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services
                .AddRepositories();

            services.AddDbContext<ApplicationDbContext>(opts => opts
                    .UseMySql(configuration.GetConnectionString("DbConnection"),
                     ServerVersion.AutoDetect(configuration.GetConnectionString("DbConnection")),
                     b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)));

            return services;
        }
        private static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            //services.AddScoped(typeof(IGenRepository<>), typeof(BaseRepository<>));
            //services.AddScoped(typeof(IProdutoOrderRepository), typeof(ProdutoOrderRepository));
            //services.AddScoped(typeof(IProdutoRepository), typeof(ProdutoRepository));



            return services;
        }
    }
}

