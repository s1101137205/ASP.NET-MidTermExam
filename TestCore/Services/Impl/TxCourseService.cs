using TestCore.Dao;
using TestCore.Dao.Impl;
using TestCore.Models;
using System;
using System.Collections.Generic;

namespace TestCore.Services.Impl
{
    public class TxCourseService : ITxCourseService
    {

        public ICourseDao CourseDao { get; set; }

        public void ExecuteTxMethod()
        {
            Course course1 = new Course();
            course1.Id = "AAA";
            course1.Name = "AAA";
            course1.Des = "45646546";
            CourseDao.AddCourse(course1);

            Course course2 = new Course();
            course2.Id = "BBB";
            course2.Name = "BBB";
            course2.Des = "123549888";
            CourseDao.AddCourse(course2);

            Course dbCourse = CourseDao.GetCourseById("AAA");
            dbCourse.Name = "XXX";
            CourseDao.UpdateCourse(dbCourse);

            throw new Exception("Get an exception");
        }

    }

}
