using BlogV3.Application.Services;
using BlogV3.Data.DataContext;
using BlogV3.Data.Repositories;
using BlogV3.Domain.Repositories;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Data;

namespace BlogV3.IoC.DataModule
{
    public static class DataModule
    {
        public static IServiceCollection AddData(this IServiceCollection services, IConfiguration configuration)
        {
            services
                 .AddRepositories()
                 .AddServices();

            services
                .AddDbContextPool<ApplicationDbContext>(opts => opts
                .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTrackingWithIdentityResolution)
                .UseSqlServer(configuration
                .GetConnectionString("SQLConnection"), b => b
                .MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)));

            static IDbConnection SqlConnection()
                => new SqlConnection("Server=localhost,1433;Database=Blog;User ID=sa;Password=1q2w3e4r@#$;Trusted_Connection=False; TrustServerCertificate=True");

            return services;
        }

        private static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped(typeof(ICategoryRepository), typeof(CategoryRepository));
            //services.AddScoped(typeof(IShippingServiceRepository), typeof(ShippingServiceRepository));

            return services;

        }

        private static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped(typeof(ICategoryService), typeof(CategoryService));
            //services.AddScoped(typeof(IShippingServiceRepository), typeof(ShippingServiceRepository));

            return services;

        }
    }
}
