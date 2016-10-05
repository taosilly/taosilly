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
    public class ContactController : Controller
    {
        private readonly IContactService _contactService;
        private readonly ApplicationDbContext _db;

        public ContactController(IContactService contactService,ApplicationDbContext db)
        {
            _contactService = contactService;
            _db = db;
        }
        // GET: /<controller>/
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Contact model)
        {
            if(ModelState.IsValid)
            {
                model.Id = Guid.NewGuid();
                model.SendDate = DateTime.Now;
                _contactService.Insert(model);
                 _db.Commit();
                 //RedirectToAction("Index");
            }
           
            return View(null);
        }
    }
}
