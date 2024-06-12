using Microsoft.EntityFrameworkCore;
using DockerNewSwitch.Entities.DbSet;


namespace DockerNewSwitch.DataService.Data
{
    public class AppDbContext : DbContext
    {

        public virtual DbSet<Estabelecimento> Estabelecimentos { get; set; }
        public virtual DbSet<Msg> Msgs { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Msg>(entity =>
            {
                entity.HasOne(e => e.Estabelecimento)
                    .WithMany(m => m.Msgs)
                    .HasForeignKey(e => e.Id)
                    .OnDelete(DeleteBehavior.NoAction)
                    .HasConstraintName("FK_Msgs_Estabelecimentos");
            }
            );
        }

    }
}
