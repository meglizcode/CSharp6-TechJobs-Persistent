using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TechJobs6Persistent.Data;
using TechJobs6Persistent.Models;
using TechJobs6Persistent.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TechJobs6Persistent.Controllers
{
    public class EmployerController : Controller
    {
// 1
        private JobDbContext context;
        public EmployerController(JobDbContext dbContext)
        {
            context = dbContext;
        }

        [HttpGet]
// 2
        public IActionResult Index()
        {
            List<Employer> employers = context.Employers.ToList();
            return View(employers);
        }

        [HttpGet]
// 3 Create instead of add
        public IActionResult Create()
        {
            AddEmployerViewModel addEmployerViewModel = new();
            return View(addEmployerViewModel);
        }
// 4 adding form validation - AddEmployerViewModel
        [HttpPost]
        public IActionResult ProcessCreateEmployerForm(AddEmployerViewModel addEmpVM)
        {
            if (ModelState.IsValid)
            {
                Employer employer = new Employer
                {
                    Name = addEmpVM.Name,
                    Location = addEmpVM.Location
                };
                context.Employers.Add(employer);
                context.SaveChanges();

                return Redirect("Index");
            }
        
            return View();
            }
        
// 5 Finding ID in DBContext (Add instead of delete CodingEvents)
        public IActionResult About(int id)
        {
            Employer? employer = context.Employers.Find(id);
            context.Employers.Add(employer);
            return View(employer);
        }

    }
}

