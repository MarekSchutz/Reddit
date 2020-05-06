using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheReddit.Entities;

namespace TheReddit.Models
{
    public class ViewModel
    {
        public User User { get; set; }
        public Post Post { get; set; }
        public List<Post> Posts { get; set; }

    }
}
