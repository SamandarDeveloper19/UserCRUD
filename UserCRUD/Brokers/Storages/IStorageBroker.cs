using System;
using System.Linq;
using System.Threading.Tasks;
using UserCRUD.Models.Users;

namespace UserCRUD.Brokers.Storages
{
    public interface IStorageBroker
    {
        ValueTask<User> InsertUserAsync(User user);
        ValueTask<User> SelectUserByIdAsync(Guid userId);
        IQueryable<User> SelectAllUsers();
        ValueTask<User> UpdateUserAsync(User user);
        ValueTask<User> DeleteUserAsync(User user);
    }
}
