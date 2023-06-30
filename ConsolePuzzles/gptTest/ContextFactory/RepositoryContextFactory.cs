using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Repository;

namespace gptTest.ContextFactory
{
    public class RepositoryContextFactory : IDesignTimeDbContextFactory<RepositoryContext>
    {
        public RepositoryContext CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var optionsBuilder = new DbContextOptionsBuilder<RepositoryContext>()
                .UseSqlServer(configuration.GetConnectionString("sqlConnection"),
                    b => b.MigrationsAssembly("gptTest"));

            return new RepositoryContext(optionsBuilder.Options);
        }
    }

}
