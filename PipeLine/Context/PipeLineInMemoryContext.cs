using Microsoft.EntityFrameworkCore;

namespace PipeLine.Context
{
    public class PipeLineInMemoryContext: PipeLineContext
    {
        public PipeLineInMemoryContext(DbContextOptions options) : base(options)
        {
            
        }

        
    }
}
