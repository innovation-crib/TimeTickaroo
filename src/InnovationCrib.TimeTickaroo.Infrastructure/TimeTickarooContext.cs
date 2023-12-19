using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace InnovationCrib.TimeTickaroo.Infrastructure;

internal class TimeTickarooContext: DbContext
{

    private readonly IOptions<DbOptions> _dbOptions;
    public TimeTickarooContext(IOptions<DbOptions> dbOptions)
    {
        _dbOptions = dbOptions;
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var connectionString = _dbOptions.Value.DefaultConnectionString;
        optionsBuilder.UseMySQL(connectionString);
    }
}