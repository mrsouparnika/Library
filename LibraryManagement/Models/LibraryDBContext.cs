namespace LibraryManagement.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class LibraryDBContext : DbContext
    {
        public LibraryDBContext()
            : base("name=LibraryDBContext")
        {
        }

        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Gender> Genders { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>()
                .HasMany(e => e.Books)
                .WithRequired(e => e.Author)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Country>()
                .Property(e => e.CountryName)
                .IsUnicode(false);

            modelBuilder.Entity<Country>()
                .HasMany(e => e.Authors)
                .WithRequired(e => e.Country)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Gender>()
                .Property(e => e.GenderName)
                .IsUnicode(false);
        }
    }
}
