using FeedbackClientes.RazorPages.Models;
using Microsoft.EntityFrameworkCore;

namespace FeedbackClientes.RazorPages.Data {
        public class AppDbContext : DbContext
    {
        public DbSet<FeedbackModel>? Feedbacks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("DataSource=tds.db;Cache=Shared");

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<FeedbackModel>().ToTable("Feeedbacks");
        }
    }

}