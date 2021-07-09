using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BatheneyPieShop.Model;
using Microsoft.EntityFrameworkCore;

namespace BatheneyPieShop.Models
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
             
        }

        public DbSet<Pie> Pies { get; set; }

        public DbSet<Category> Categories { get; set; }

    }
}
