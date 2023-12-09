using Microsoft.AspNetCore.Mvc;
using UserCRUD.Models.Users;
using UserCRUD.Services.Foundations.Users;

namespace UserCRUD.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private readonly IUserService userService;

        public UserController(IUserService userService)
        {
            this.userService = userService;
        }

        [HttpPost]
        public ActionResult<User> PostUser(User user)
        {
            return this.userService.AddUser(user);
        }
    }
}
