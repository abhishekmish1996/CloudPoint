using CloudPoint.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CloudPoint.Controllers
{
    public class ApplicationUsersController : Controller
    {
        public ApplicationUsersController(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
           
        }
        private UserManager<ApplicationUser> _userManager;

      
        public IActionResult Index()
        {
            return View(_userManager.Users.ToList());
        }
    }
}
