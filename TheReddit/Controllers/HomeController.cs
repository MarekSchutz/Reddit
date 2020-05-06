using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TheReddit.Entities;
using TheReddit.Interfaces;
using TheReddit.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TheReddit.Controllers
{
    public class HomeController : Controller
    {
        private readonly UserManager<User> userManager;
        private readonly IRedditDBService redditDBService;

        public HomeController(UserManager<User> userManager, IRedditDBService redditDBService)
        {
            this.userManager = userManager;
            this.redditDBService = redditDBService;
        }
        public IActionResult Index(string filter)
        {
            if (filter != "all")
            {
                return View(new PostViewModel(redditDBService.OrderPosts()));
            }
            return View(new PostViewModel(redditDBService.GetPosts()));
        }
        [HttpGet]
        [Authorize]
        public IActionResult UserPosts()
        {
            var user = User.Identity.Name;
            return View("UserPosts", new PostViewModel(redditDBService.UserPosts(user)));
        }
    }
}
