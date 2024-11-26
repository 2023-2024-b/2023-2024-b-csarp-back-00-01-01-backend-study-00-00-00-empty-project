using Microsoft.EntityFrameworkCore;

namespace PointToPoint.Context
{
    public class PointToPointContext : DbContext
    {
        public PointToPointContext(DbContextOptions options) : base(options)
        {
        }
    }
}
