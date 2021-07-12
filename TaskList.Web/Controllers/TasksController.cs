using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TaskList.DAL;
using TaskList.Domain;
using TaskList.Services;
using TaskList.Web.Models;

namespace TaskList.Web.Controllers
{
    public class TasksController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly TaskListDbContext _db;
        private readonly IEmailService emailService;

        public TasksController(ILogger<HomeController> logger, TaskListDbContext db, IEmailService emailService)
        {
            _logger = logger;
            _db = db;
            this.emailService = emailService;
        }

        public IActionResult Index()
        {
            return View(_db.TaskItems.AsEnumerable());
        }
        public IActionResult Create()
        {
            return View(new TaskItem());
        }
        [HttpPost]
        public IActionResult Create(TaskItem model)
        {
            if(ModelState.IsValid)
            {
                _db.Add(model);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}
