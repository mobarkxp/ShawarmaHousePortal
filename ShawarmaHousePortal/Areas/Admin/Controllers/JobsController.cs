using Infrastrucure.IRepository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ShawarmaHousePortal.Models;

namespace ShawarmaHousePortal.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class JobsController : Controller
    {
        private readonly IServicesRepository<Job> _jobservice;

        public JobsController(IServicesRepository<Job> jobservice)
        {
            _jobservice = jobservice;
        }
        public ActionResult Index()

        {

            return View(_jobservice.GetAll());
        }

        // GET: JobsController/Details/5
        public ActionResult Details(int id)
        {
            if(id == 0) return NotFound();
            var job = _jobservice.FindById(id);
            if(job == null) return NotFound();
            return View(job);
        }

        // GET: JobsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: JobsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Job job )
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _jobservice.Save(job,1);
                    return RedirectToAction(nameof(Index));
                }
                catch
                {
                    return View(job);
                }
            }
            return View(job);
            
        }

        // GET: JobsController/Edit/5
        public ActionResult Edit(int id)
        {
            if(id==0) return NotFound();
           var job= _jobservice.FindById(id);
            if(job==null)return NotFound();
            return View(job);
        }

        // POST: JobsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Job job)
        {
            if(id!=job.JobId) return View(job);
            if (ModelState.IsValid)
            {
                try
                {

                    _jobservice.Update(job,1);
                   
                    return RedirectToAction(nameof(Index));
                }
                catch
                {
                    return View(job);
                }
               
            }
            return View(job);
        }

        // GET: JobsController/Delete/5
        public ActionResult Delete(int id)
        {
            if(id==0) return NotFound();
            
            return View(_jobservice.FindById(id));
        }

        // POST: JobsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Job job)
        {
            if(id!=job.JobId) return View(job); 
            try
            {
                _jobservice.Delete(id);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
