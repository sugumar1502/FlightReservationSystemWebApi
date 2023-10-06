using DataObjectLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class FlightDbContext:DbContext
    {
        public FlightDbContext()
        {

        }
        public FlightDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<User> User { get; set; }   
        public DbSet<UserWallet> UserWallet { get; set; }
        public DbSet<UserWalletTransaction> UserWalletTransaction { get; set; }
    }
}
