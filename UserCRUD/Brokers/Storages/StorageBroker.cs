using EFxceptions;
using Microsoft.EntityFrameworkCore;
using UserCRUD.Models.Users;

namespace UserCRUD.Brokers.Storages
{
    public class StorageBroker : EFxceptionsContext, IStorageBroker
    {
        public DbSet<User> Users { get; set; }

        public StorageBroker()
        {
            this.Database.EnsureCreated();
        }

        public User InsertUser(User user)
        {
            this.Users.Add(user);
            this.SaveChanges();

            return user;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Data source = UserCRUD.db";
            optionsBuilder.UseSqlite(connectionString);
        }
    }
}
