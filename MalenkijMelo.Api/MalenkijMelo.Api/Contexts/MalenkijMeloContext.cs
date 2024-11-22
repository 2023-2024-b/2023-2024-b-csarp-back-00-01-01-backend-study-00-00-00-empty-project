using Microsoft.EntityFrameworkCore;

namespace MalenkijMelo.Api.Contexts
{
    public class MalenkijMeloContext : DbContext
    {
        public MalenkijMeloContext(DbContextOptions options) : base(options)
        {
        }
    }
}
