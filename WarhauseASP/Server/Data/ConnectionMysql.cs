using Microsoft.EntityFrameworkCore;

using WarhauseASP.Shared;

namespace WarehouseASP.Server.DB
{
    public class ConnectionMysql : DbContext
    {
        private readonly IConfiguration _configuration;

        public ConnectionMysql(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            var CS = _configuration.GetConnectionString("CTMYSQL");
            options.UseMySql(CS, ServerVersion.AutoDetect(CS)).LogTo(Console.Write);
        }
        public DbSet<stan> stan { get; set; }
    }
}
