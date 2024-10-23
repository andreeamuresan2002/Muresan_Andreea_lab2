using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Muresan_Andreea_lab2.Models;

namespace Muresan_Andreea_lab2.Data
{
    public class Muresan_Andreea_lab2Context : DbContext
    {
        public Muresan_Andreea_lab2Context (DbContextOptions<Muresan_Andreea_lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Muresan_Andreea_lab2.Models.Book> Book { get; set; } = default!;
        public DbSet<Muresan_Andreea_lab2.Models.Publisher> Publisher { get; set; } = default!;
    }
}
