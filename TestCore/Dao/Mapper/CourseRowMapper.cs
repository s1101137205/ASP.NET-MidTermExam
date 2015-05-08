using TestCore.Models;
using Spring.Data.Generic;
using System.Data;

namespace TestCore.Dao.Mapper
{
    class CourseRowMapper : IRowMapper<Course>
    {
        public Course MapRow(IDataReader dataReader, int rowNum)
        {
            Course target = new Course();

            target.Id = dataReader.GetString(dataReader.GetOrdinal("Id"));
            target.Name = dataReader.GetString(dataReader.GetOrdinal("Name"));
            target.Des = dataReader.GetString(dataReader.GetOrdinal("Des"));

            return target;
        }

    }
}
