using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Avaliacao.Model;

namespace Avaliacao.Model
{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext(DbContextOptions options) : base(options)
        {

        }
        
        public DbSet<Avaliacao.Model.RickMory> RickMory { get; set; }
    }
}
