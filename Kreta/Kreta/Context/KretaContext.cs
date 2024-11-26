using Microsoft.EntityFrameworkCore;

namespace Kreta.Context
{
    public class KretaContext : DbContext
    {
        protected KretaContext(DbContextOptions options) : base(options)
        {

        }
    }
}
