namespace MvcApplication1.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public class LearnModels : DbContext
    {
        public LearnModels()
            : base("name=LearnModels")
        {
        }

        public DbSet<UserProfile> UserProfile { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
