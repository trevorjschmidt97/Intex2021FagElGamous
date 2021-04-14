using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Intex2021FagElGamous.Models
{
    public partial class intex2021Context : DbContext
    {
        public intex2021Context()
        {
        }

        public intex2021Context(DbContextOptions<intex2021Context> options)
            : base(options)
        {
        }

        public virtual DbSet<BiologicalSample> BiologicalSamples { get; set; }
        public virtual DbSet<Burial> Burials { get; set; }
        public virtual DbSet<BurialSite> BurialSites { get; set; }
        public virtual DbSet<C14datum> C14data { get; set; }
        public virtual DbSet<CranialMain> CranialMains { get; set; }
        public virtual DbSet<FieldBook> FieldBooks { get; set; }
        public virtual DbSet<Image> Images { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql("User ID=postgres;Password=TrevorSchmidt;Host=database-18.cpfigizvmp4l.us-east-1.rds.amazonaws.com;Port=5432;Database=intex2021;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "en_US.UTF-8");

            modelBuilder.Entity<BiologicalSample>(entity =>
            {
                entity.HasKey(e => e.BioSampleId)
                    .HasName("BiologicalSamples_pkey");

                entity.Property(e => e.BioSampleId).ValueGeneratedNever();

                entity.Property(e => e.Cluster).HasColumnName("Cluster #");
            });

            modelBuilder.Entity<Burial>(entity =>
            {
                entity.HasKey(e => e.BurialKeyId)
                    .HasName("Burial_pkey");

                entity.ToTable("Burial");

                entity.Property(e => e.BurialKeyId).ValueGeneratedNever();

                entity.Property(e => e.ImagesYn).HasColumnName("ImagesYN");

                entity.Property(e => e.PoroticHyperostosisLocations).HasColumnName("PoroticHyperostosisLOCATIONS");

                entity.Property(e => e.Tmjoa).HasColumnName("TMJOA");
            });

            modelBuilder.Entity<BurialSite>(entity =>
            {
                entity.ToTable("BurialSite");

                entity.Property(e => e.BurialSiteId)
                    .ValueGeneratedNever()
                    .HasColumnName("BurialSiteID");

                entity.Property(e => e.Ew).HasColumnName("EW");

                entity.Property(e => e.Ewbottom).HasColumnName("EWBottom");

                entity.Property(e => e.Ewtop).HasColumnName("EWTop");

                entity.Property(e => e.Ns).HasColumnName("NS");

                entity.Property(e => e.Nsbottom).HasColumnName("NSBottom");

                entity.Property(e => e.Nstop).HasColumnName("NSTop");
            });

            modelBuilder.Entity<C14datum>(entity =>
            {
                entity.HasKey(e => e.C14id)
                    .HasName("C14Data_pkey");

                entity.ToTable("C14Data");

                entity.Property(e => e.C14id).ValueGeneratedNever();

                entity.Property(e => e.C14sample2017).HasColumnName("C14Sample2017");
            });

            modelBuilder.Entity<CranialMain>(entity =>
            {
                entity.ToTable("CranialMain");

                entity.Property(e => e.CranialMainId)
                    .ValueGeneratedNever()
                    .HasColumnName("CranialMainID");

                entity.Property(e => e.BasionBregmaHeight).HasColumnName("Basion-BregmaHeight");

                entity.Property(e => e.BasionNasion).HasColumnName("Basion-Nasion");

                entity.Property(e => e.BasionProsthionLength).HasColumnName("Basion-ProsthionLength");

                entity.Property(e => e.NasionProsthion).HasColumnName("Nasion-Prosthion");
            });

            modelBuilder.Entity<FieldBook>(entity =>
            {
                entity.HasKey(e => e.FieldBooksId)
                    .HasName("FieldBooksId_pkey");

                entity.Property(e => e.FieldBooksId).ValueGeneratedNever();
            });

            modelBuilder.Entity<Image>(entity =>
            {
                entity.ToTable("Image");

                entity.Property(e => e.ImageId)
                    .ValueGeneratedNever()
                    .HasColumnName("ImageID");

                entity.Property(e => e.Url).HasColumnName("URL");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.UserId).HasColumnName("userID");

                entity.Property(e => e.Email).HasColumnName("email");

                entity.Property(e => e.FirstName).HasColumnName("firstName");

                entity.Property(e => e.LastName).HasColumnName("lastName");

                entity.Property(e => e.PassHash).HasColumnName("passHash");

                entity.Property(e => e.PassIterations).HasColumnName("passIterations");

                entity.Property(e => e.PassSalt).HasColumnName("passSalt");

                entity.Property(e => e.Role).HasColumnName("role");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
