using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SalesWebMvc1.Models
{
    public class SalesWebMvc1Context : DbContext
    {
        public SalesWebMvc1Context (DbContextOptions<SalesWebMvc1Context> options)
            : base(options)
        {
        }

        public DbSet<SalesWebMvc1.Models.Department> Department { get; set; }
    }
}
