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
    public class CitiesController : Controller
    {
        private readonly IServicesRepository<City> _serviceCity;

        public CitiesController(IServicesRepository<City> serviceCity)
        {
            _serviceCity = serviceCity;
        }

        // GET: CitiesController
        public ActionResult Index()
        {

            return View(_serviceCity.GetAll());
        }

        // GET: CitiesController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CitiesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CitiesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(City city)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _serviceCity.Save(city, 1);
                    return RedirectToAction(nameof(Index));
                }
                catch
                {
                    return View(city);
                }
            }
            return View(city);
        }

        // GET: CitiesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CitiesController/Edit/5
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

        // GET: CitiesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CitiesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
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
    }
}
