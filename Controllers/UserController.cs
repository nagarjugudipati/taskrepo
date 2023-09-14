using Microsoft.AspNetCore.Mvc;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class UserController : Controller
    {
        static List<User> users = new List<User>
        {
            new User(){UserId=1,UserName="sam",UserPwd="sam@123",UserEmail="sam@yahoo.com"},
            new User(){UserId=2,UserName="amit",UserPwd="amit@123",UserEmail="amit@yahoo.com"},
            new User(){UserId=3,UserName="kumar",UserPwd="kumar@123",UserEmail="kumar@yahoo.com"},
            new User(){UserId=4,UserName="anisha",UserPwd="anisha@123",UserEmail="anisha@yahoo.com"},
            new User(){UserId=5,UserName="vidisha",UserPwd="visha@123",UserEmail="vidisha@yahoo.com"},
        };
        public IActionResult Index()
        {
            return View(users);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View(new User());
        }
        [HttpPost]
        public IActionResult Create(User model)
        {
           if(ModelState.IsValid)
            {
                users.Add(model);
                return RedirectToAction("Index");
            }
            else
            {
                return View(model);
            }
           
        }

    }
}
