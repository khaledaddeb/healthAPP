using healthApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace healthApp.Controllers
{
    public class PedometerController : Controller
    {
        private readonly dbContext context;

        public PedometerController(dbContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Steps()
        {
            return View();
        }
        [HttpPost]
        public IActionResult StepsToCalory(Run run)
        {

            double total = run.Steps * 0.04;
            run.Date = DateTime.Now;
            context.runs.Add(run);
            context.SaveChanges();
            ViewBag.total = total;

            return View();
        }
    }
}
