using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesTemplate.Model;

namespace RazorPagesTemplate.Data
{
    public class RazorPagesGamesContext : DbContext
    {
        public RazorPagesGamesContext (DbContextOptions<RazorPagesGamesContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesTemplate.Model.Game> Game { get; set; }
    }
}
