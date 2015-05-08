using System;

namespace TestCore.Models
{
    public class Course
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string Des { get; set; }

        public override string ToString()
        {
            return "Course: Id = " + Id + ", Name = " + Name + ".";
        }

    }
}
