using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Scaffold.WebApi.Models;

namespace Scaffold.WebApi.Data
{
    public class ScaffoldWebApiContext : DbContext
    {
        public ScaffoldWebApiContext (DbContextOptions<ScaffoldWebApiContext> options)
            : base(options)
        {
        }

        public DbSet<Scaffold.WebApi.Models.Customer> Customer { get; set; } = default!;
    }
}
