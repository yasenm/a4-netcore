﻿using A4CoreBlog.Common;
using A4CoreBlog.Data.Services.Contracts;
using A4CoreBlog.Data.ViewModels;
using A4CoreBlog.Web.Extensions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace A4CoreBlog.Web.Areas.Admin.Controllers
{
    [Area(GlobalConstants.AdminArea)]
    public class PostController : Controller
    {
        private readonly IPostService _postService;

        public PostController(IPostService postService)
        {
            _postService = postService;
        }

        [Authorize]
        public IActionResult MyPosts()
        {
            var model = _postService.GetAll<PostListBasicViewModel>()
                .Where(p => p.AuthorId == HttpContext.User.GetUserId())
                .OrderBy(p => p.BlogId)
                .ToList();

            return View(model);
        }

        [Authorize]
        public IActionResult AddOrUpdate(int? id)
        {
            return View();
        }
    }
}