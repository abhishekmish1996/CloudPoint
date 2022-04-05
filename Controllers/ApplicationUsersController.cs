using CloudPoint.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;


using System.Threading.Tasks;

namespace CloudPoint.Controllers
{
    public class ApplicationUsersController : Controller
    {
        public ApplicationUsersController(UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;

        }
        private UserManager<IdentityUser> _userManager;

        public async Task<IActionResult> GetAPIDetails()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://ghibliapi.herokuapp.com/");
            var detailsVMData = new List<CloudPoint.Models.APIvm>();
            var apiResponse = await client.GetAsync("people");
            if (apiResponse.IsSuccessStatusCode)
            {
                var Response = apiResponse.Content.ReadAsStringAsync().Result;
                detailsVMData = JsonConvert.DeserializeObject<List<CloudPoint.Models.APIvm>>(Response);
                return View(detailsVMData);
            }
            else
            {
                return View();
            }
        }

       
    }
}
