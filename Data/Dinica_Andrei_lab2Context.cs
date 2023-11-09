using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Dinica_Andrei_lab2.Models;

namespace Dinica_Andrei_lab2.Data
{
    public class Dinica_Andrei_lab2Context : DbContext
    {
        public Dinica_Andrei_lab2Context (DbContextOptions<Dinica_Andrei_lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Dinica_Andrei_lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Dinica_Andrei_lab2.Models.Publisher>? Publisher { get; set; }

        public DbSet<Dinica_Andrei_lab2.Models.Author>? Author { get; set; }
    }
}
