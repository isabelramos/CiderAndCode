using System.Data.Entity;

namespace CiderAndCode.Web.DataModels
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("CiderAndCode")
        {}

        public DbSet<AppleFact> AppleFacts { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Cider> Ciders { get; set; }
        public DbSet<Juice> Juices { get; set; }
        public DbSet<Bushel> Bushels { get; set; }
        public DbSet<Drink> Drinks { get; set; }
    }
}