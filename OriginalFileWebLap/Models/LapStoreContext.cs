using Microsoft.EntityFrameworkCore;

namespace OriginalFileWebLap.Models
{
    public class LapStoreContext : DbContext
    {
        public LapStoreContext(DbContextOptions<LapStoreContext> options) : base(options) { }

        public DbSet<AdminAccount> AdminAccounts { get; set; }
        public DbSet<UserAccount> UserAccounts{ get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Product>Products { get; set; }
        public DbSet<Branch> Branchs { get; set; }
        public DbSet<CPU> CPUs { get; set; }
        public DbSet<HDH> HDHs { get; set; }
        public DbSet<Ram> Rams { get; set; }
        public DbSet<Requirement> Requirements { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AdminAccount>(entity =>
            {
                entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);

                entity.Property(e => e.Password)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            });

            modelBuilder.Entity<UserAccount>(entity =>
            {
                entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(true);

                entity.Property(e => e.Password)
                .IsRequired()
                .HasMaxLength(50);

                entity.Property(e => e.Email)
                .IsRequired()
                .HasMaxLength(50);

                entity.HasMany(u => u.Comments)
                      .WithOne(c => c.User)
                      .HasForeignKey(c => c.IdUser);
            });

            modelBuilder.Entity<Comment>(entity =>
            {
                entity.Property(e => e.NameUSer)
                .IsRequired();

                entity.Property(e => e.Content)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode (true);
            });


            modelBuilder.Entity<Branch>(entity =>
            {
                entity.Property(e => e.Name).IsRequired()
                .HasMaxLength(50);
            });

            modelBuilder.Entity<CPU>(entity =>
            {
                entity.Property(e => e.CpuName).IsRequired()
                .HasMaxLength(50);
            });

            modelBuilder.Entity<HDH>(entity =>
            {
                entity.Property(e => e.HDHName).IsRequired().HasMaxLength(50);
            });

            modelBuilder.Entity<Ram>(entity =>
            {
                entity.Property(e => e.RaName).IsRequired().HasMaxLength(50);
            });

            modelBuilder.Entity<Requirement>(entity =>
            {
                entity.Property(e => e.ReName).IsRequired().HasMaxLength(150).IsUnicode(true);
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(true);
                entity.Property(e => e.Description)
                   .IsRequired()
                   .HasMaxLength(200)
                   .IsUnicode(true);
                entity.Property(e => e.Images)
                   .IsRequired()
                   .HasMaxLength(150);

                entity.Property(e => e.Price)
                   .IsRequired();

                entity.HasOne(b => b.Branch)
                   .WithMany(p => p.products)
                   .HasForeignKey(b => b.IdBranch)
                   .OnDelete(DeleteBehavior.ClientSetNull)
                   .HasConstraintName("FK_Product_Branch");

                entity.HasOne(c => c.CPU)
                  .WithMany(p => p.products)
                  .HasForeignKey(c => c.IdCpu)
                  .OnDelete(DeleteBehavior.ClientSetNull)
                  .HasConstraintName("FK_Product_CPU");

                entity.HasOne(h => h.HDH)
                  .WithMany(p => p.products)
                  .HasForeignKey(h => h.IdHdh)
                  .OnDelete(DeleteBehavior.ClientSetNull)
                  .HasConstraintName("FK_Product_HDH");

                entity.HasOne(r => r.Ram)
                  .WithMany(p => p.products)
                  .HasForeignKey(r => r.IdRam)
                  .OnDelete(DeleteBehavior.ClientSetNull)
                  .HasConstraintName("FK_Product_Ram");

                entity.HasOne(re => re.Requirement)
                  .WithMany(p => p.products)
                  .HasForeignKey(re => re.IdRquire)
                  .OnDelete(DeleteBehavior.ClientSetNull)
                  .HasConstraintName("FK_Product_Requirement");

                entity.HasMany(c => c.comments)
                      .WithOne(p => p.Product)
                      .HasForeignKey(c => c.IdProduct);
            });
            //có lẽ làm session..
            /*modelBuilder.Entity<Cart>(entity =>
            {
                entity.Property(e => e.NamePro)
                      .IsRequired()
                      .HasMaxLength(100)
                      .IsUnicode(true);

                entity.Property(e => e.imgPro)
                      .IsRequired()
                      .HasMaxLength(200)
                      .IsUnicode(false);

                entity.Property(e => e.Quantity)
                      .IsRequired();


                entity.Property(e => e.Price)
                      .IsRequired();



            });*/


        }

    }
}
