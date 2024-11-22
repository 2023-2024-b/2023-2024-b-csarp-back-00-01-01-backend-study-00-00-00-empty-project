using MalenkijMelo.Api.Contexts;

namespace MalenkijMelo.Api.Extension
{
    public static class WebApplicationExtension
    {
        public static void ConfigWebApp(this WebApplication app)
        {
            app.ConfigWebAppCors();
            app.ConfigInMemoryTestData();
        }

        private static void ConfigWebAppCors(this WebApplication app)
        {
            app.UseCors("KretaCors");
        }

        private static void ConfigInMemoryTestData(this WebApplication app)
        {
            using (var scope = app.Services.CreateAsyncScope())
            {
                var dbContext = scope.ServiceProvider.GetRequiredService<MalenkijMeloInMemoryContext>();
                // InMemory test data
                dbContext.Database.EnsureCreated();
            }
        }
    }
}
