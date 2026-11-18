using Microsoft.EntityFrameworkCore;

namespace SIHSALUS_DocumentGenerator.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<GeneratedFuaPayload> GeneratedFuaPayloads => Set<GeneratedFuaPayload>();
}
