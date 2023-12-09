using UserCRUD.Models.Users;

namespace UserCRUD.Brokers.Storages
{
    public interface IStorageBroker
    {
        User InsertUser(User user);
    }
}
