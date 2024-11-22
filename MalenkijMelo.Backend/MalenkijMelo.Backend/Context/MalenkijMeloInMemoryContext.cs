using Microsoft.EntityFrameworkCore;

namespace MalenkijMelo.Backend.Context
{
    public class MalenkijMeloInMemoryContext : MalenkijMeloContext
    {
        public MalenkijMeloInMemoryContext(DbContextOptions<MalenkijMeloInMemoryContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Seed();
        }
    }
}
