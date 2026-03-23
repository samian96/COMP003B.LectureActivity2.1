using Microsoft.AspNetCore.Mvc;

namespace COMP003B.LectureActivity2._1.Controllers.ProfileController.cs
{
    public class ProfileController : Controller
    {
        [HttpGet]
        public IActionResult About()
        {
            return View();
        }

        [HttpGet]

        public IActionResult Hobbies()
        {
            return View();
        }
    }
}
