using TestCore.Models;
using TestCore.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TestCore.Services.Impl;

namespace midtest.Controllers
{
    public class CourseController : ApiController
    {
        [HttpGet]
        public IList<Course> GetAllCourses()
        {
            return CourseService.GetAllCourses();
        }
    }
}
