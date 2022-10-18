using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjApi1.Models;

namespace ProjApi1.Data
{
    public class ProjApi1Context : DbContext
    {
        public ProjApi1Context (DbContextOptions<ProjApi1Context> options)
            : base(options)
        {
        }

        public DbSet<ProjApi1.Models.Employee> Employee { get; set; }

        public DbSet<ProjApi1.Models.Address> Address { get; set; }
    }
}
