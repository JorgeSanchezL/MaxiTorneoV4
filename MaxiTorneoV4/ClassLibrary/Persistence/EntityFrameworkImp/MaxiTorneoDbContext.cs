using MaxiTorneo.Entities;
using System.Data.Entity;

namespace MaxiTorneo.Persistence
{
    public class MaxiTorneoDbContext : MyDbContext
    {
        public MaxiTorneoDbContext() : base("Name=MaxiTorneoDbConnection") //this is the connection string name
        {
            /*
            See DbContext.Configuration documentation
            */
            Configuration.ProxyCreationEnabled = true;
            Configuration.LazyLoadingEnabled = true;
        }

        static MaxiTorneoDbContext()
        {
            //Database.SetInitializer<TarongISWDbContext>(new CreateDatabaseIfNotExists<TarongISWDbContext>());
            Database.SetInitializer<MaxiTorneoDbContext>(new DropCreateDatabaseIfModelChanges<MaxiTorneoDbContext>());
            //Database.SetInitializer<TarongISWDbContext>(new DropCreateDatabaseAlways<TarongISWDbContext>());
            //Database.SetInitializer<TarongISWDbContext>(new TarongISWDbContext());
            //Database.SetInitializer(new NullDatabaseInitializer<TarongISWDbContext>());
        }

        public DbSet<League> Contracts { get; set; }
        public DbSet<Person> Crates { get; set; }
        public DbSet<Player> Groups { get; set; }
        public DbSet<Team> Parcels { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>().HasKey(p => p.Name);
            modelBuilder.Entity<Player>().HasKey(p => p.Name);
            modelBuilder.Entity<Team>().HasKey(t => t.Name);
            modelBuilder.Entity<League>().HasKey(l => l.Name);
            modelBuilder.Entity<Player>().HasRequired(p => p.Team).WithMany(t => t.Players).WillCascadeOnDelete(false);
            modelBuilder.Entity<Player>().HasOptional(p => p.Person).WithMany(p => p.Players).WillCascadeOnDelete(false);
            modelBuilder.Entity<Team>().HasRequired(t => t.League).WithMany(l => l.Teams).WillCascadeOnDelete(false);
            modelBuilder.Entity<Person>().HasRequired(p => p.Team).WithOptional(t => t.Person).WillCascadeOnDelete(false);
        }

    }

}