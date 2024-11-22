using Microsoft.EntityFrameworkCore;

namespace MalenkijMelo.Api.Contexts
{
    public class MalenkijMeloInMemoryContext:MalenkijMeloContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Seed();
        }
    }
}
