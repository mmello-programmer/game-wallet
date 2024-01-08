using GameWallet.Models;
using Microsoft.EntityFrameworkCore;

namespace GameWallet.Data
{
    public class BanquinhoContext : DbContext
    {
        public BanquinhoContext(DbContextOptions<BanquinhoContext> options) : base(options)
        { 
        }
                public DbSet<gwContatoModel> tbUser { get; set; }

    }
}