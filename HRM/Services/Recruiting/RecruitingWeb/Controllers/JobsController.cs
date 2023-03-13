using Microsoft.AspNetCore.Mvc;

namespace RecruitingWeb.Controllers
{
    public class JobsController : Controller
    {
        // Attributes
        [HttpGet]
        public IActionResult Index()
        {
            // return all the jobs so that candidates can apply to the job
            return View();
        }

        // get the Job detailed information
        [HttpGet]
        public IActionResult Details(int id)
        {
            return View();
        }

        // Authenticated and User should have role for creating new Job
        // HR / Manager
        [HttpPost]
        public IActionResult Create()
        {
            // take the information from the View and save to DB
            return View();
        }
    }
}
