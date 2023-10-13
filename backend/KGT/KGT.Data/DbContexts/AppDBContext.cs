using KGT.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace KGT.Data.DbContexts
{
    public class AppDbContext : DbContext
    {
        public virtual DbSet<Guide> Guides { get; set; }
        public virtual DbSet<Dog> Dogs { get; set; }
        public virtual DbSet<Event> Events { get; set; }
        public virtual DbSet<Certificate> Certificates { get; set; }
        public virtual DbSet<DogCertificate> DogCertificates { get; set; }
        public virtual DbSet<GuideEvent> GuideEvents { get; set; }
        public virtual DbSet<Training> Trainings { get; set; }
        public virtual DbSet<DogTraining> DogTrainings { get; set; }
        public virtual DbSet<DogEvent> DogEvents { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<GuideEvent>().HasKey(ge => new { ge.GuideId, ge.EventId });
            modelBuilder.Entity<DogCertificate>().HasKey(dc => new { dc.DogId, dc.CertificateId });

            //modelBuilder.Entity<GuideAction>().HasOne(m => m.Action)
            //    .WithMany(m => m.GuideActions)
            //    .HasForeignKey(m => m.ActionId);

            //modelBuilder.Entity<GuideEvent>().HasOne(m => m.Event)
            //    .WithMany(m => m.GuideEvents)
            //    .HasForeignKey(m => m.EventId);


            //dog trainings
            modelBuilder.Entity<Training>().HasMany(t => t.DogTrainings)
                .WithOne(dt => dt.Training)
                .HasForeignKey(dt => dt.TrainingId);

            modelBuilder.Entity<Dog>().HasMany(d => d.DogTrainings)
                .WithOne(dt => dt.Dog)
                .HasForeignKey(dt => dt.DogId);


            //dog events
            modelBuilder.Entity<Event>().HasMany(t => t.DogEvents)
                .WithOne(de => de.Event)
                .HasForeignKey(de => de.EventId);

            modelBuilder.Entity<Dog>().HasMany(d => d.DogEvents)
                .WithOne(de => de.Dog)
                .HasForeignKey(de => de.DogId);

            //Guide events
            modelBuilder.Entity<Guide>().HasMany(g => g.GuideEvents)
                .WithOne(ge => ge.Guide)
                .HasForeignKey(ge => ge.GuideId);

            modelBuilder.Entity<Event>().HasMany(e => e.GuideEvents)
                .WithOne(ge => ge.Event)
                .HasForeignKey(ge => ge.EventId);


            //dog certificates
            modelBuilder.Entity<Dog>().HasMany(d => d.DogCertificates)
                .WithOne(dc => dc.Dog)
                .HasForeignKey(dc => dc.DogId);

            modelBuilder.Entity<Certificate>().HasMany(c => c.DogCertificates)
                .WithOne(dc => dc.Certificate)
                .HasForeignKey(dc => dc.CertificateId);
        }
    }
}
