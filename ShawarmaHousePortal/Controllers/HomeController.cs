using Infrastrucure.IRepository;
using Infrastrucure.IRepository.ServicesRepository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using ShawarmaHousePortal.Data;
using ShawarmaHousePortal.Models;
using System.Diagnostics;

namespace ShawarmaHousePortal.Controllers
{
    public class HomeController : Controller
    {
        private readonly IServicesRepository<Job> _servicesJob;
        private readonly IServicesRepository<Gender> _genderServices;
        private readonly IServicesRepository<Maried> _mariedService;
        private readonly IServicesRepository<City> _cityServices;
        private readonly IServicesRepository<Employee> _employeeservice;
        private readonly IServicesRepository<Education> _EducationService;
        private readonly IServicesRepository<Work> _workService;

        public HomeController(IServicesRepository<Job> servicesJob,
            IServicesRepository<Gender> genderServices,
            IServicesRepository<Maried> maredService,
            IServicesRepository<City> CityServices,
            IServicesRepository<Employee> employeeservice,
            IServicesRepository<Education> educationService,
            IServicesRepository<Work> WorkService)
        {
            _servicesJob = servicesJob;
            _genderServices = genderServices;
            _mariedService = maredService;
            _cityServices = CityServices;
            _employeeservice = employeeservice;
            _EducationService = educationService;
           _workService = WorkService;
        }

        public IActionResult Index()
        {
            
            return View();
        }
        public IActionResult Jobs()
        {

            
            return View(_servicesJob.GetAll());
        }
        [HttpGet]
        public IActionResult CreateEmp()
        {
           ViewBag.Gender=new SelectList(_genderServices.GetAll(), "GenderId", "GenderName");
           ViewBag.Maried=new SelectList(_mariedService.GetAll(), "MId", "MName");
            ViewBag.City = new SelectList(_cityServices.GetAll(), "CityId", "CityName");
            Random invoicid = new Random();
            var x = invoicid.Next(10000, 1000000);
            ViewBag.random = x.ToString();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateEmp(Employee employee)
        {
            if (employee == null) return NotFound();
            if (ModelState.IsValid)
            {
                try
                {
                    _employeeservice.Save(employee, 1);
                    return RedirectToAction(nameof(Thankfunction));
                }
                catch (Exception)
                {
                    ViewBag.Gender = new SelectList(_genderServices.GetAll(), "GenderId", "GenderName");
                    ViewBag.Maried = new SelectList(_mariedService.GetAll(), "MId", "MName");
                    ViewBag.City = new SelectList(_cityServices.GetAll(), "CityId", "CityName");

                    return View(employee);
                }

            }
           

            return View(employee);
        }


        [HttpPost]
        public JsonResult AddEducation(string edDepartment, string edCertivicate, string edAvarage, string edUnivircity, string edDate, string EmpRonomId)
        {
            Education education = new Education
            {
                EName = edCertivicate,
                Specialization = edDepartment,
                Average = edAvarage,
                Scool = edUnivircity,
                Edate = Convert.ToDateTime(edDate),
                EmployNum = Convert.ToInt32(EmpRonomId)
            };

            try
            {
                _EducationService.Save(education, 1);
                return new JsonResult(Ok(education));
            }
            catch
            {
                return new JsonResult(NotFound());
            }


        }

        [HttpPost]
        public IActionResult AddExperiance(string WName, string WCompany, string Salary, string WStartDate, string WEndDate,string WAddress, string EmpRonomId)
        {
            Work experiance = new Work
            {
                WName = WName,
                WCompany = WCompany,
                Salary = Convert.ToInt32(Salary),
                WStartDate = Convert.ToDateTime(WStartDate),
                WEndDate = Convert.ToDateTime(WEndDate),
                EmployNum = Convert.ToInt32(EmpRonomId),
                WAddress = WAddress
            };

            try
            {
                _workService.Save(experiance, 1);
                return Ok(experiance);
            }
            catch
            {
                return NotFound();
            }


        }

        public IActionResult Thankfunction()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}