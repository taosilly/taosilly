using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication.Data;
using WebApplication.IServices;
using WebApplication.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication.Controllers
{
    public class NewsController : Controller
    {
        private readonly IBlogService _blogService;

        private readonly ICategoryService _categoryService;
        private readonly ApplicationDbContext _db;

        public NewsController(IBlogService blogService,ICategoryService categoryService,ApplicationDbContext db)
        {
            _blogService = blogService;
            _categoryService = categoryService;
            _db = db;

        }

        public IActionResult P(Guid id)
        {
            Blog blog =  _blogService.FirstOrDefault(item=>item.Id == id);

            return View(blog);
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            IQueryable<Blog> blogs =  _blogService.GetAllList();
            IQueryable<Category> categorys = _categoryService.GetAllList();
            ViewBag.categorys = categorys;
            
            return View(blogs);
        }

        public IActionResult Categories(Guid id)
        {
            IQueryable<Blog> blogs =  _blogService.GetAllList(item=>item.CategoryId == id);
            IQueryable<Category> categorys = _categoryService.GetAllList();
            ViewBag.categorys = categorys;
            
            return View("Index",blogs);
        }
    }
}
