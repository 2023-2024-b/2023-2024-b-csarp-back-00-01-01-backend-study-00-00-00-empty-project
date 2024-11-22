using MalenkijMelo.Context;

namespace MalenkijMelo.Extensions
{
    public static class WebApplicationExtension
    {
        public static void ConfigureWebApp(this WebApplication app)
        {
            // InMemory database data
            using (var scope = app.Services.CreateAsyncScope())
            {
                var dbContext = scope.ServiceProvider.GetRequiredService<MalenkijMeloInMemoryContext>();
                // InMemory test data
                dbContext.Database.EnsureCreated();
            }
        }
    }
}
