using Microsoft.EntityFrameworkCore;

namespace Project_Sem3.Models
{
    public partial class ProjectDbContext : DbContext
    {
        public ProjectDbContext() { }

        public ProjectDbContext(DbContextOptions<ProjectDbContext> options) : base(options) { }

        public virtual DbSet<Product> Products { get; set; } = null!;
        public virtual DbSet<Category> Category { get; set; } = null!;
        public virtual DbSet<ContactUs> ContactUs { get; set; } = null!;
        public virtual DbSet<QuoteUs> QuoteUs { get; set; } = null!;
        public virtual DbSet<Career> Careers { get; set; } = null!;
        public virtual DbSet<CandidateDetails> CandidateDetails { get; set; } = null!;
        public virtual DbSet<SelectedCandidates> SelectedCandidates { get; set; } = null!;

        public virtual DbSet<User> Users { get; set; } = null!;

        public virtual DbSet<Role> Roles { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {


        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Product>()
            .HasOne(p => p.Category)
            .WithMany(c => c.Products)
            .HasForeignKey(p => p.CategoryId);


            modelBuilder.Entity<CandidateDetails>(entity =>
            {
                entity.HasOne(cd => cd.Career)
                .WithMany(c => c.CandidateDetails)
                .HasForeignKey(cd => cd.CareerId);
            });

            modelBuilder.Entity<SelectedCandidates>(entity =>
            {
                entity.HasOne(sc => sc.Career)
                .WithMany(c => c.SelectedCandidates)
                .HasForeignKey(sc => sc.CareerId);
            });
            OnModelCreatingPartial(modelBuilder);

            modelBuilder.Entity<User>()
        .HasOne(u => u.Role)
        .WithMany(r => r.Users)
        .HasForeignKey(u => u.RoleId);
        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
