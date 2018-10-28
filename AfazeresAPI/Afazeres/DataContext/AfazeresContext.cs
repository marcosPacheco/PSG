using Afazeres.Mapping;
using Afazeres.Models;
using System.Data.Entity;

namespace Afazeres.DataContext
{
    public class AfazeresContext : DbContext
    {
        public AfazeresContext() : base("name=AfazeresContext")
        {
            Configuration.LazyLoadingEnabled = true;
            Configuration.ProxyCreationEnabled = true;
        }

        public virtual DbSet<Afazer> AFAZERES { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new AfazeresMap());

            Database.SetInitializer(new CreateDatabaseIfNotExists<AfazeresContext>());
        }
    }
}