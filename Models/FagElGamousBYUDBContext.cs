using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Intex2021FagElGamous.Models
{
    public partial class FagElGamousBYUDBContext : DbContext
    {
        public FagElGamousBYUDBContext()
        {
        }

        public FagElGamousBYUDBContext(DbContextOptions<FagElGamousBYUDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BiologicalSample> BiologicalSamples { get; set; }
        public virtual DbSet<Burial> Burials { get; set; }
        public virtual DbSet<BurialSite> BurialSites { get; set; }
        public virtual DbSet<C14datum> C14data { get; set; }
        public virtual DbSet<CranialMain> CranialMains { get; set; }
        public virtual DbSet<FieldBook> FieldBooks { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlite("Data Source = FagElGamousBYUDB.db");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BiologicalSample>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Biological Samples");

                entity.Property(e => e.Burial).HasColumnName("Burial#");

                entity.Property(e => e.Cluster).HasColumnName("Cluster#");

                entity.Property(e => e.RackBag).HasColumnName("Rack/Bag");

                entity.Property(e => e.RackBagNum).HasColumnName("Rack/BagNum");
            });

            modelBuilder.Entity<Burial>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Burial");

                entity.Property(e => e.AgeCodeSingle).HasColumnName("AgeCodeSINGLE");

                entity.Property(e => e.AgeSkull2018).HasColumnName("Age\n(Skull\n2018)");

                entity.Property(e => e.BurialSiteId).HasColumnName("BurialSiteID");

                entity.Property(e => e.Burialadultchild).HasColumnName("burialadultchild");

                entity.Property(e => e.Burialageatdeath).HasColumnName("burialageatdeath");

                entity.Property(e => e.Burialagemethod).HasColumnName("burialagemethod");

                entity.Property(e => e.Burialdepth).HasColumnName("burialdepth");

                entity.Property(e => e.Burialgendermethod).HasColumnName("burialgendermethod");

                entity.Property(e => e.Burialpreservation).HasColumnName("burialpreservation");

                entity.Property(e => e.Burialsampletaken).HasColumnName("burialsampletaken");

                entity.Property(e => e.Burialsouthtofeet).HasColumnName("burialsouthtofeet");

                entity.Property(e => e.Burialsouthtohead).HasColumnName("burialsouthtohead");

                entity.Property(e => e.Burialwesttofeet).HasColumnName("burialwesttofeet");

                entity.Property(e => e.Burialwesttohead).HasColumnName("burialwesttohead");

                entity.Property(e => e.Burialwrapping).HasColumnName("burialwrapping");

                entity.Property(e => e.Byusample).HasColumnName("BYUSample");

                entity.Property(e => e.Gamous).HasColumnName("GAMOUS");

                entity.Property(e => e.Length).HasColumnName("length");

                entity.Property(e => e.LengthM).HasColumnName("length(M)");

                entity.Property(e => e.PoroticHyperostosisLocations).HasColumnName("PoroticHyperostosis(LOCATIONS)");

                entity.Property(e => e.SexSkull2018).HasColumnName("Sex\n(Skull2018)");

                entity.Property(e => e.TemporalMandibularJointOsteoarthritisTmjoa).HasColumnName("TemporalMandibularJointOsteoarthritis(TMJOA)");

                entity.Property(e => e.Tobeconfirmed).HasColumnName("TOBECONFIRMED");

                entity.Property(e => e.Yearexcav).HasColumnName("yearexcav");
            });

            modelBuilder.Entity<BurialSite>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BurialSite");

                entity.Property(e => e.BurialSiteId).HasColumnName("BurialSiteID");

                entity.Property(e => e.EW).HasColumnName("E/W");

                entity.Property(e => e.Ewbottom).HasColumnName("EWBottom");

                entity.Property(e => e.Ewtop).HasColumnName("EWTop");

                entity.Property(e => e.NS).HasColumnName("N/S");

                entity.Property(e => e.Nsbottom).HasColumnName("NSBottom");

                entity.Property(e => e.Nstop).HasColumnName("NSTop");
            });

            modelBuilder.Entity<C14datum>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("C14Data");

                entity.Property(e => e.Area).HasColumnName("AREA");

                entity.Property(e => e.Burial).HasColumnName("Burial#");

                entity.Property(e => e.C14id).HasColumnName("C14Id");

                entity.Property(e => e.C14sample2017).HasColumnName("C14Sample2017");

                entity.Property(e => e.Calibrated95CalendarDateAvg).HasColumnName("Calibrated95%CalendarDateAVG");

                entity.Property(e => e.Calibrated95CalendarDateMax).HasColumnName("Calibrated95%CalendarDateMAX");

                entity.Property(e => e.Calibrated95CalendarDateMin).HasColumnName("Calibrated95%CalendarDateMIN");

                entity.Property(e => e.Calibrated95CalendarDateSpan).HasColumnName("Calibrated95%CalendarDateSPAN");

                entity.Property(e => e.Conventional14CageBp).HasColumnName("Conventional14CageBP");

                entity.Property(e => e.Field13).HasColumnName("field13");

                entity.Property(e => e.QuestionS).HasColumnName("Question(s)");

                entity.Property(e => e.SizeMl).HasColumnName("Size(ml)");

                entity.Property(e => e.Tube).HasColumnName("TUBE#");

                entity.Property(e => e._14ccalendarDate).HasColumnName("14CCalendarDate");
            });

            modelBuilder.Entity<CranialMain>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CranialMain");

                entity.Property(e => e.BasionBregmaHeight).HasColumnName("Basion-BregmaHeight");

                entity.Property(e => e.BasionNasion).HasColumnName("Basion-Nasion");

                entity.Property(e => e.BasionProsthionLength).HasColumnName("Basion-ProsthionLength");

                entity.Property(e => e.BurialArtifactDescription).HasColumnName("Burial/ArtifactDescription");

                entity.Property(e => e.NasionProsthion).HasColumnName("Nasion-Prosthion");
            });

            modelBuilder.Entity<FieldBook>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.BurialSiteId).HasColumnName("BurialSiteID");

                entity.Property(e => e.FieldBook1).HasColumnName("FieldBook");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasIndex(e => e.Email, "IX_Users_email")
                    .IsUnique();

                entity.Property(e => e.UserId).HasColumnName("userID");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasColumnName("firstName");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasColumnName("lastName");

                entity.Property(e => e.PassHash)
                    .IsRequired()
                    .HasColumnName("passHash");

                entity.Property(e => e.PassIterations).HasColumnName("passIterations");

                entity.Property(e => e.PassSalt)
                    .IsRequired()
                    .HasColumnName("passSalt");

                entity.Property(e => e.Role)
                    .IsRequired()
                    .HasColumnName("role");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
