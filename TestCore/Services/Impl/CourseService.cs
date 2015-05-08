using TestCore.Dao;
using TestCore.Dao.Impl;
using TestCore.Models;
using System.Collections.Generic;
using TestCore.Services;

namespace TestCore.Services.Impl
{
    public class CourseService : ICourseService
    {

        public ICourseDao CourseDao { get; set; }

        public void AddCourse(Course course)
        {
            CourseDao.AddCourse(course);
        }

        public void UpdateCourse(Course course)
        {
            CourseDao.UpdateCourse(course);
        }

        public void DeleteCourse(Course course)
        {
            course = CourseDao.GetCourseById(course.Id);

            if (course != null)
            {
                CourseDao.DeleteCourse(course);
            }
        }

        public IList<Course> GetAllCourses()
        {
            return CourseDao.GetAllCourse();
        }

        public Course GetCourseById(string id)
        {
            return CourseDao.GetCourseById(id);
        }

        public Course GetCourseByName(string name)
        {
            return CourseDao.GetCourseByName(name);
        }
        public IList<Company> GetAllCompanies()
        {
            List<Company> companies = new List<Company>();

            Company company1 = new Company();
            company1.Id = "GSS";
            company1.Name = "叡揚資訊";
            companies.Add(company1);

            Company company2 = new Company();
            company2.Id = "KUAS";
            company2.Name = "高雄應用科技大學";
            companies.Add(company2);

            return companies;
        }
    }

}
