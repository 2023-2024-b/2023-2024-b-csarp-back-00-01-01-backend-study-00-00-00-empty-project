namespace MalenkijMelo.Api.Controllers.Extension
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
    }
}
