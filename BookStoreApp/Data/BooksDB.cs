using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using BookStoreApp.Models;

namespace BookStoreApp.Data
{
    public class BooksDBContext : DbContext
    {
        public BooksDBContext(DbContextOptions<BooksDBContext> options) : base(options) {
            
        }
        public DbSet<Book> Books { get; set; }
    }
}
