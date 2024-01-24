using Domin.Models;
using Infrastrucure.IRepository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShawarmaHousePortal.Models;

namespace ShawarmaHousePortal.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class EducationLevelsController : Controller
    {
        private readonly IServicesRepository<EducationLevel> _services;

        public EducationLevelsController(IServicesRepository<EducationLevel> services)
        {
            _services = services;
        }
        // GET: EducationLevelController
        public ActionResult Index()
        {
            return View(_services.GetAll());
        }

        // GET: EducationLevelController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: EducationLevelController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EducationLevelController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(EducationLevel   educationLevel)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _services.Save(educationLevel, 1);
                    return RedirectToAction(nameof(Index));
                }
                catch
                {
                    return View(educationLevel);
                }

            }
            return View(educationLevel);

        }

        // GET: EducationLevelController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EducationLevelController/Edit/5
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

        // GET: EducationLevelController/Delete/5
        public ActionResult Delete(int id)
        {
            if (id == 0) return NotFound();
            try
            {
                var educationlevel = _services.FindById(id);
                return View(educationlevel);
            }
            catch (Exception)
            {
                return NotFound();
            }

         
        }

        // POST: EducationLevelController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, EducationLevel educationLevel)
        {
            if (id != educationLevel.EducationLevelId) return NotFound();
            try
            {
                _services.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
