using Day1.Api.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day1.Api.Controllers
{
    public class CourseController : Controller
    {
        private readonly ICourseRepository _repository;

        public CourseController(ICourseRepository repository)
        {
            if (repository == null)
            {
                throw new ArgumentNullException(nameof(repository));
            }
        }

        public IActionResult Index()
        {
            return View(_repository.GetCourses());
        }
    }
}
