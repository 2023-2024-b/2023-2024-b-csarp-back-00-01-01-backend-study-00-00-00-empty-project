using Microsoft.EntityFrameworkCore;

namespace PipeLine.Context
{
    public class PipeLineContext : DbContext
    {
        public PipeLineContext(DbContextOptions options) : base(options)
        {
        }
    }
}
