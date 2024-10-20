using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Ciont_Patricia_Lab2.Models;

namespace Ciont_Patricia_Lab2.Data
{
    public class Ciont_Patricia_Lab2Context : DbContext
    {
        public Ciont_Patricia_Lab2Context (DbContextOptions<Ciont_Patricia_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Ciont_Patricia_Lab2.Models.Book> Book { get; set; } = default!;
        public DbSet<Ciont_Patricia_Lab2.Models.Publisher> Publisher { get; set; } = default!;
    }
}
