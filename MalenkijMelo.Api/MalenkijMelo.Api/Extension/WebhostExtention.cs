namespace MalenkijMelo.Api.Extension
{
    public static class WebhostExtention
    {
        public static void ConfigWebhost(this WebApplicationBuilder webApplicationBuilder )
        {
            webApplicationBuilder.WebHost.UseUrls("http://0.0.0.0:7020");
        }
    }
}
