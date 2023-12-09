using UserCRUD.Models.Users;

namespace UserCRUD.Services.Foundations.Users
{
    public interface IUserService
    {
        User AddUser(User user);
    }
}
