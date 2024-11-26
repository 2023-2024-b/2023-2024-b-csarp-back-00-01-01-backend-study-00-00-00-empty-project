using Microsoft.EntityFrameworkCore;

namespace MalenkijMelo.Context
{
    public class MalenkijMeloInMemoryContext : MalenkijMeloContext
    {
        public MalenkijMeloInMemoryContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Seed();
        }
    }
}
