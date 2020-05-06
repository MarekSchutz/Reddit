using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TheReddit.Entities;
using TheReddit.Interfaces;
using TheReddit.Models;

namespace TheReddit.Controllers
{
    public class PostController : Controller
    {
        private readonly IRedditDBService redditDBService;
        private readonly UserManager<User> userManager;
        public PostController(IRedditDBService redditDBService, UserManager<User> userManager)
        {
            this.redditDBService = redditDBService;
            this.userManager = userManager;
        }
        [HttpGet]
        [Authorize]
        public IActionResult AddPost()
        {
            return View();
        }
        [HttpPost]
        [Authorize]
        public async Task<IActionResult> AddPost(AddPostViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await userManager.FindByNameAsync(User.Identity.Name);
                var NewModel = new Post
                {
                    Title = model.Title,
                    Url = model.Url
                };
                NewModel.User = user;
                redditDBService.AddPost(NewModel);
            }
            return RedirectToAction("Index", "Home");
        }
        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Vote(int vote, int id)
        {
            if (redditDBService.FindPost(id).User == await userManager.FindByNameAsync(User.Identity.Name))
            {
                return RedirectToAction("Index", "Home");
            }
            redditDBService.Vote(vote, id);
            return RedirectToAction("Index", "Home");
        }
        [HttpGet]
        [Authorize]
        public IActionResult DeletePost(int id)
        {
            redditDBService.DeletePost(id);
            return RedirectToAction("UserPosts", "Home");
        }
        [HttpGet]
        [Authorize]
        public IActionResult EditPost(int id)
        {
            return View(new PostViewModel(redditDBService.FindPost(id)));
        }
        [HttpPost]
        [Authorize]
        public async Task<IActionResult> EditPost(Post post)
        {
            var user = await userManager.FindByNameAsync(User.Identity.Name);
            redditDBService.EditPost(post, user);
            return RedirectToAction("UserPosts", "Home");
        }
    }
}
