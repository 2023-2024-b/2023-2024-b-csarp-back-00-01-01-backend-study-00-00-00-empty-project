using Microsoft.EntityFrameworkCore;

namespace MalenkijMelo.Backend.Context
{
    public class MalenkijMeloInMemoryContext : MalenkijMeloContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Seed();
        }
    }
}
