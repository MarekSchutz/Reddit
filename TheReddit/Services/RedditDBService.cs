using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheReddit.Data;
using TheReddit.Entities;
using TheReddit.Interfaces;

namespace TheReddit.Services
{
    public class RedditDBService : IRedditDBService
    {
        private readonly ApplicationDbContext applicationDbContext;
        public RedditDBService(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }
        public List<Post> OrderPosts()
        {
            return applicationDbContext.Posts.Include(p => p.User).OrderByDescending(p => p.Likes).Take(10).ToList();
        }
        public List<Post> GetPosts()
        {
            return applicationDbContext.Posts.Include(p => p.User).ToList();
        }
        public Post FindPost(int id)
        {
            return applicationDbContext.Posts.Include(p=> p.User).FirstOrDefault(p => p.Id == id);
        }
        public void AddPost(Post model)
        {
            applicationDbContext.Add(model);
            applicationDbContext.SaveChanges();
        }
        public void Vote(int vote, int id)
        {
            var post = FindPost(id);
            post.Likes += vote;
            applicationDbContext.SaveChanges();
        }
        public List<Post> UserPosts(string name)
        {
            return applicationDbContext.Posts.Include(p=> p.User).Where(p => p.User.UserName == name).ToList();
        }
        public void DeletePost(int id)
        {
            applicationDbContext.Remove(FindPost(id));
            applicationDbContext.SaveChanges();
        }
        public void EditPost(Post post, User user)
        {
            post.User = user;
            applicationDbContext.Update(post);
            applicationDbContext.SaveChanges();
        }
    }
}
