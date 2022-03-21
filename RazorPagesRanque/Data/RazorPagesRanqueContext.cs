#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesRanque.models;

namespace RazorPagesRanque.Data
{
    public class RazorPagesRanqueContext : DbContext
    {
        public RazorPagesRanqueContext (DbContextOptions<RazorPagesRanqueContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesRanque.models.motorcycle> motorcycle { get; set; }
    }
}
