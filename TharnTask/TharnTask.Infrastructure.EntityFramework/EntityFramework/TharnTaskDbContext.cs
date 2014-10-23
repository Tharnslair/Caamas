using System.Data.Entity;
using Abp.Domain.Repositories.EntityFramework;

namespace TharnTask.EntityFramework
{
    public class TharnTaskDbContext : AbpDbContext
    {
        //TODO: Define an IDbSet for each Entity...

        //public virtual IDbSet<Person> People { get; set; } //Sample

        public TharnTaskDbContext()
            : base("MainDb")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //TODO: Make additional model setup...

            //modelBuilder.Entity<Person>().ToTable("TsPeople"); //Sample
        }
    }
}
