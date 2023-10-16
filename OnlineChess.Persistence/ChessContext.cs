using Microsoft.EntityFrameworkCore;
using OnlineChess.Persistence.Mappings;

namespace OnlineChess.Persistence
{
    public class ChessContext : DbContext
    {
        public ChessContext(DbContextOptions<ChessContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ChessModelMap();
        }
    }
}
