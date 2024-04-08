using Iterometro.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterometro.Infrastructure.Context
{
    internal class ContadorContext : DbContext
    {
        public ContadorContext(DbContextOptions options ) : base( options ) { }
        
        public DbSet<AtorContagem> AtorContagens { get; set; }
    }
}
