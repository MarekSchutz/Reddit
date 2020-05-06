using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheReddit.Entities;

namespace TheReddit.Interfaces
{
    public interface IRedditDBService
    {
        List<Post> GetPosts();
        List<Post> OrderPosts();
        void AddPost(Post model);
        void Vote(int vote, int id);
        List<Post> UserPosts(string name);
        Post FindPost(int id);
        void DeletePost(int id);
        void EditPost(Post post, User user);
    }
}
