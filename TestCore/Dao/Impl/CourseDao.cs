
using TestCore.Dao.Base;
using TestCore.Dao.Mapper;
using TestCore.Models;
using Spring.Data.Common;
using Spring.Data.Generic;
using System.Collections.Generic;
using System.Data;

namespace TestCore.Dao.Impl
{
    public class CourseDao : GenericDao<Course>, ICourseDao
    {

        override protected IRowMapper<Course> GetRowMapper()
        {
            return new CourseRowMapper();
        }

        public void AddCourse(Course course)
        {
            string command = @"INSERT INTO Course (Id, Name, Des) VALUES (@Id, @Name, @Des);";

            IDbParameters parameters = CreateDbParameters();
            parameters.Add("Id", DbType.String).Value = course.Id;
            parameters.Add("Name", DbType.String).Value = course.Name;
            parameters.Add("Des", DbType.Int32).Value = course.Des;

            ExecuteNonQuery(command, parameters);
        }

        public void UpdateCourse(Course course)
        {
            string command = @"UPDATE Course SET Name = @Name, Des = @Des WHERE Id = @Id;";

            IDbParameters parameters = CreateDbParameters();
            parameters.Add("Id", DbType.String).Value = course.Id;
            parameters.Add("Name", DbType.String).Value = course.Name;
            parameters.Add("Des", DbType.Int32).Value = course.Des;

            ExecuteNonQuery(command, parameters);
        }

        public void DeleteCourse(Course course)
        {
            string command = @"DELETE FROM Course WHERE Id = @Id";

            IDbParameters parameters = CreateDbParameters();
            parameters.Add("Id", DbType.String).Value = course.Id;

            ExecuteNonQuery(command, parameters);
        }

        public IList<Course> GetAllCourse()
        {
            string command = @"SELECT * FROM Course ORDER BY Id ASC";
            IList<Course> courses = ExecuteQueryWithRowMapper(command);
            return courses;
        }

        public Course GetCourseById(string id)
        {
            string command = @"SELECT * FROM Course WHERE Id = @Id";

            IDbParameters parameters = CreateDbParameters();
            parameters.Add("Id", DbType.String).Value = id;

            IList<Course> course = ExecuteQueryWithRowMapper(command, parameters);
            if (course.Count > 0)
            {
                return course[0];
            }

            return null;
        }
        public Course GetCourseByName(string name)
        {
            string command = @"SELECT * FROM Course WHERE Name = @Name";

            IDbParameters parameters = CreateDbParameters();
            parameters.Add("Name", DbType.String).Value = name;

            IList<Course> course = ExecuteQueryWithRowMapper(command, parameters);
            if (course.Count > 0)
            {
                return course[0];
            }

            return null;
        }

    }
}
