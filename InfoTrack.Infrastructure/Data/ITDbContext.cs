using InfoTrack.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace InfoTrack.Infrastructure.Data {
    public class ITDbContext : DbContext {
        public ITDbContext(DbContextOptions<ITDbContext> options) : base(options) { }
        public DbSet<Search> Searches { get; set; }
    }
}
