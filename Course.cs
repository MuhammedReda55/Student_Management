using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_student_maanagment
{
    internal class Course
    {
        public string Name { get; set; }
        public string Instructor { get; set; }

        public Course() { }

        public Course(string name, string instructor)
        {

            Name = name;
            Instructor = instructor;

        }
        public void DisplayDetails()
        {
            Console.WriteLine($"Course: {Name} -> Instructor: {Instructor}");
        }

    }
}
