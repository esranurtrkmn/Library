using Library_Model.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }


        public DbSet<Category> Categories { get; set; }
        public DbSet<BookType> BookTypes { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<BookDetail> BookDetails { get; set; }
        public DbSet<Writer> Writers { get; set; }
        public DbSet<BookWriter> BookWriters { get; set; }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // manytomany ilişkilerinde ara tabloda 2 tane primary key oluyor, composite key tanımlama ile 2sinin de primary key olduğunu belirttik.
            modelBuilder.Entity<BookWriter>().HasKey( x => new { x.BookId, x.WriterId });

            // Modelde [Key] veya [Required] yazmak yeterli değil, burada da belirtmek daha iyi
            modelBuilder.Entity<BookDetail>().HasKey(a => a.Id);
            modelBuilder.Entity<BookDetail>().Property(a => a.EpisodeCount).IsRequired();
            modelBuilder.Entity<BookDetail>().Property(a => a.PageCount).IsRequired();

            modelBuilder.Entity<Book>().HasKey(a => a.Id);
            modelBuilder.Entity<Book>().Property(a => a.Price).IsRequired();
            modelBuilder.Entity<Book>().Property(a => a.ISBN).IsRequired().HasMaxLength(13);

            modelBuilder.Entity<Writer>().HasKey(a => a.Id);
            modelBuilder.Entity<Writer>().Property(a => a.Name).IsRequired();
            modelBuilder.Entity<Writer>().Property(a => a.Surname).IsRequired();
            modelBuilder.Entity<Writer>().Ignore(a => a.NameSurname);

            modelBuilder.Entity<Publisher>().HasKey(a => a.Id);
            modelBuilder.Entity<Publisher>().Property(a => a.PublisherName).IsRequired();
            modelBuilder.Entity<Publisher>().Property(a => a.Location).IsRequired();

            modelBuilder.Entity<BookType>().HasKey(a => a.Id);
            modelBuilder.Entity<BookType>().Property(a => a.Name).IsRequired();
            modelBuilder.Entity<BookType>().Property(a => a.Count).IsRequired();

            modelBuilder.Entity<Category>().HasKey(a => a.Id);
            modelBuilder.Entity<Category>().Property(a => a.CategoryName).IsRequired();
         


        }
        
    }
    
}

