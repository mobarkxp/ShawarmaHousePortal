using Infrastrucure.IRepository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ShawarmaHousePortal.Models;

namespace ShawarmaHousePortal.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class HomeController : Controller
    {
        private readonly IServicesRepository<Job> _jobservice;
        private readonly IServicesRepository<Employee> _empservice;

        public HomeController(IServicesRepository<Job> jobservice,IServicesRepository<Employee> empservice)
        {
            _jobservice = jobservice;
            _empservice = empservice;
        }
        public IActionResult Index()
        {
            ViewBag.cuntJob = _jobservice.Count();
            ViewBag.cuntEmp = _empservice.Count();
            ViewBag.Employees = _empservice.GetAll();

            return View();
        }


        
    }
}
