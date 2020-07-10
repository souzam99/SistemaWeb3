using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SistemaWeb3.Models
{
    public class SistemaWeb3Context : DbContext
    {
        public SistemaWeb3Context (DbContextOptions<SistemaWeb3Context> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }

        public DbSet<Seller> Seller { get; set; }

        public DbSet<SalesRecord> SalesRecord { get; set; }
    }
}
