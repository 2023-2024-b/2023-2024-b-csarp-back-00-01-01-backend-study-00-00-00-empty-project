using MalenkijMelo.Api.Contexts;
using Microsoft.EntityFrameworkCore;

namespace MalenkijMelo.Api.Extension
{
    public static class KreateBackendExtension
    {
        public static void AddBackend(this IServiceCollection services)
        {
            services.ConfigureCors();
        }

        private static void ConfigureCors(this IServiceCollection services)
        {
            services.AddCors(option =>
                option.AddPolicy(name: "KretaCors",
                    policy =>
                    {
                        policy.WithOrigins("https://0.0.0.0:7020/")
                        .AllowAnyHeader()
                        .AllowAnyMethod();
                    }
                )
           );
        }

        public static void ConfigureInMemoryContext(this IServiceCollection services)
        {
            string dbNameInMemoryContext = "Kreta" + Guid.NewGuid();
            services.AddDbContext<MalenkijMeloInMemoryContext>
            (
                 options => options.UseInMemoryDatabase(databaseName: dbNameInMemoryContext),
                 ServiceLifetime.Scoped,
                 ServiceLifetime.Scoped
            );


        }
    }
}
