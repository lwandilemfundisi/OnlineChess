using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using XFrame.Persistence.EFCore;

namespace OnlineChess.Persistence
{
    public class ChessContextProvider : IDbContextProvider<ChessContext>, IDisposable
    {
        private readonly DbContextOptions<ChessContext> _options;

        public ChessContextProvider(IConfiguration configuration)
        {
            _options = new DbContextOptionsBuilder<ChessContext>()
                .UseSqlServer(configuration["DataConnection:Database"])
                .Options;
        }

        public ChessContext CreateContext()
        {
            return new ChessContext(_options);
        }

        public void Dispose()
        {
        }
    }
}
