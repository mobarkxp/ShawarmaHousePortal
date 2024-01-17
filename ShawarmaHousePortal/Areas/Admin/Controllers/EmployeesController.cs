using Infrastrucure.IRepository;
using Infrastrucure.IRepository.ServicesRepository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShawarmaHousePortal.Models;

namespace ShawarmaHousePortal.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class EmployeesController : Controller
    {
        private readonly IServicesRepository<Employee> _empservice;
        private readonly IServicesRepository<Education> _educationService;
        private readonly IServicesRepository<Work> _workService;

        public EmployeesController(IServicesRepository<Employee> empservice,
            IServicesRepository<Education> educationservice,
            IServicesRepository<Work> workService
            )
        {
            _empservice = empservice;
              _educationService = educationservice;
            _workService = workService;
        }
        public ActionResult Index()
        {
            var employees = _empservice.GetAll();
           
            return View(employees);
        }

        // GET: EmployeesController/Details/5
        public ActionResult Details(int id)
        {
            // _empservice.FindById(id);
            ViewBag.Education = _educationService.GetAllbyId(id);
            ViewBag.Work = _workService.GetAllbyId(id);
            return View(_empservice.FindById(id));
        }

        // GET: EmployeesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmployeesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmployeesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EmployeesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmployeesController/Delete/5
        public ActionResult Delete(int id)
        {
            if(id == 0) return NotFound();
            try {
                var employee = _empservice.FindById(id);
                return View(employee);
            }
            catch(Exception) {
                return NotFound();
            }
            
        }

        // POST: EmployeesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Employee employee)
        {
            if (id != employee.EmpId) return NotFound();
            try
            {
                _empservice.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddEducation()
        {
          //  _educationService
            return Ok();
        }
    }
}
