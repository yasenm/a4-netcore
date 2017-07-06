﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System.Collections.Generic;

namespace A4CoreBlog.Data.Models
{
    public class User : IdentityUser
    {
        private ICollection<Post> _posts;

        public User()
        {
            _posts = new HashSet<Post>();
        }

        public int BlogId { get; set; }
        public virtual Blog Blog { get; set; }
        public virtual ICollection<Post> Posts
        {
            get => _posts;
            set => _posts = value;
        }
    }
}