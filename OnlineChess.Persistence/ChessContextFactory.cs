﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace OnlineChess.Persistence
{
    public class ChessContextFactory : IDesignTimeDbContextFactory<ChessContext>
    {
        public ChessContext CreateDbContext(string[] args)
        {
            var envName = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");

            var configuration = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory()))
                .AddJsonFile("appsettings.json", optional: false)
                .AddJsonFile($"appsettings.{envName}.json", optional: false)
                .Build();

            var optionsBuilder = new DbContextOptionsBuilder<ChessContext>();
            optionsBuilder.UseSqlServer(configuration["DataConnection:Database"]);

            return new ChessContext(optionsBuilder.Options);
        }
    }
}
