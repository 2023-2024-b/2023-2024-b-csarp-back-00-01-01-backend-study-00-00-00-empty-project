using Microsoft.EntityFrameworkCore;

namespace MalenkijMelo.Context
{
    public class MalenkijMeloContext : DbContext
    {
        protected MalenkijMeloContext(DbContextOptions options) : base(options)
        {

        }
    }
}
