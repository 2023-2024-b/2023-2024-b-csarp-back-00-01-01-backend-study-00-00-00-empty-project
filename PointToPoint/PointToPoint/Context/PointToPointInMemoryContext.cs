using Microsoft.EntityFrameworkCore;

namespace PointToPoint.Context
{
    public class PointToPointInMemoryContext :PointToPointContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Seed();
        }
    }
}
