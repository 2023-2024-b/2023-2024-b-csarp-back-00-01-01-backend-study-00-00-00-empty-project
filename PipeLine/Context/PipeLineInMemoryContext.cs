using Microsoft.EntityFrameworkCore;

namespace PipeLine.Context
{
    public class PipeLineInMemoryContext: PipeLineContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Seed();
        }
    }
}
