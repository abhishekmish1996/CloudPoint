using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CloudPoint.Data
{
    public class IdentityServices
    {
        public IdentityServices(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }
        #region Constructor
        private readonly UserManager<ApplicationUser> _userManager;


        #endregion
        public List<ApplicationUser> GetAllUsers()
        {
            List<ApplicationUser> userList = new List<ApplicationUser>();
            userList = _userManager.Users.OrderBy(m => m.UserName).ToList();
            return userList;
        }

    }
}
