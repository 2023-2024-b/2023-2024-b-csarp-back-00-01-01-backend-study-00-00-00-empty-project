using Microsoft.EntityFrameworkCore;

namespace PipeLine.Context
{
    public class PipeLineInMemoryContext: PipeLineContext
    {
        public PipeLineInMemoryContext(DbContextOptions options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Seed();
        }

    }
}
