using Microsoft.EntityFrameworkCore;
using PointToPoint.Context;

namespace PointToPoint.Extension
{
    public static class PoinToPointBackendExtension
    {
        public static void AddBackend(this IServiceCollection services)
        { 
            services.ConfigureCors();
            services.ConfigureInMemoryContext();
        }
        private static void ConfigureCors(this IServiceCollection services)
        {
            services.AddCors(option =>
                option.AddPolicy(name: "PointToPointCors",
                    policy =>
                    {
                        policy.WithOrigins("https://0.0.0.0:7020")
                        .AllowAnyHeader()
                        .AllowAnyMethod();
                    }
                )
           );
        }
        public static void ConfigureInMemoryContext(this IServiceCollection services)
        {
            string dbNameInMemoryContext = "PtP" + Guid.NewGuid();
            services.AddDbContext<PointToPointInMemoryContext>
            (
                 options => options.UseInMemoryDatabase(databaseName: dbNameInMemoryContext),
                 ServiceLifetime.Scoped,
                 ServiceLifetime.Scoped
            );
        }

    }
}
