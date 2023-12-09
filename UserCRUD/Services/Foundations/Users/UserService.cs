using UserCRUD.Brokers.Storages;
using UserCRUD.Models.Users;

namespace UserCRUD.Services.Foundations.Users
{
    public class UserService : IUserService
    {
        private readonly IStorageBroker storageBroker;

        public UserService(IStorageBroker storageBroker)
        {
            this.storageBroker = storageBroker;
        }

        public User AddUser(User user) =>
            this.storageBroker.InsertUser(user);
    }
}
