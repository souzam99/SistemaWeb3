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

        public DbSet<SistemaWeb3.Models.Department> Department { get; set; }
    }
}
