using Microsoft.EntityFrameworkCore;

namespace MalenkijMelo.Backend.Context
{
    public class MalenkijMeloContext : DbContext
    {

        public MalenkijMeloContext(DbContextOptions options) : base(options)
        {
        }
    }
}
