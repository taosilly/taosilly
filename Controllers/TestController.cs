using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication.Data;
using WebApplication.IServices;
using WebApplication.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication.Controllers
{
    public class TestController : Controller
    {
        private readonly ICategoryService _categoryService;

         private readonly IBlogService _blogService;
        private readonly ApplicationDbContext _db;

        public TestController(
            ICategoryService categoryService,
            IBlogService blogService,
            ApplicationDbContext db)
        {
            _categoryService = categoryService;
            _blogService = blogService;
            _db = db;
        }
        // GET: /<controller>/
        public IActionResult AddData()
        {
            _categoryService.Insert(new Category(){Id=Guid.NewGuid(), Name = "测试类"});
            _db.Commit();
            return Content("Ok");
        }

        public IActionResult GetData()
        {
            IQueryable<Category> categorys = _categoryService.GetAllList();
            IQueryable<Blog> blogs = _blogService.GetAllList();
            StringBuilder sb = new StringBuilder();

            foreach(var i in categorys)
            {
                sb.AppendLine(i.Id+": " + i.Name);
            }
            sb.AppendLine();
            foreach(var i in blogs)
            {
                sb.AppendLine(string.Format("{0},   {1},    {2},    {3}",i.Id,i.CategoryId,i.Title,i.Content));
            }

            return Content(sb.ToString());
        }

    }
}