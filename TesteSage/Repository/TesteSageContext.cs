using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteSage.Domain;

namespace TesteSage.Repository
{
    public class TesteSageContext : DbContext
    {
        public TesteSageContext(DbContextOptions<TesteSageContext> options) : base(options)
        {
        }

        public DbSet<Pessoa> Pessoa { get; set; }
        public DbSet<Endereco> Endereco { get; set; } 


    }
}
