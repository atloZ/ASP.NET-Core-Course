using Day1.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day1.Api.Repositories
{
    public interface ICourseRepository
    {
        IEnumerable<CourseModel> GetCourses();
    }
}
