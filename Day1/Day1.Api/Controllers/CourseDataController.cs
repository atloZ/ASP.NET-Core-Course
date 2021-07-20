using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Day1.Api.Controllers
{
    public class CourseDataController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("api/courses")]
        public IActionResult GetCourese()
        {
            return Json(new List<object>
            {
                new { id=1, Name="nev1", Info="valami1"},
                new { id=2, Name="nev2", Info="valami2"},
                new { id=3, Name="nev3", Info="valami3"},
                new { id=4, Name="nev4", Info="valami4"},
                new { id=5, Name="nev5", Info="valami5"}
            }
            );
        }
        
        [HttpGet("api/courses/{id}")]
        public IActionResult GetCourese(int? id)
        {
            return Json(new { Name = $"Ez get be érkezett: {id}"}
            );
        }
     }
}
