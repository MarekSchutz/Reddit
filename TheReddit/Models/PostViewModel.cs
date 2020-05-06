using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheReddit.Entities;

namespace TheReddit.Models
{
    public class PostViewModel
    {
        public Post Post { get; set; }
        public List<Post> Posts { get; set; }
        public PostViewModel()
        {

        }
        public PostViewModel(List<Post> posts)
        {
            Posts = posts;
        }
        public PostViewModel(Post post)
        {
            Post = post;
        }
    }
}
