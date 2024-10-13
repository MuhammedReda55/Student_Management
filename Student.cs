using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_student_maanagment
{
    internal class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<Course> courses { get; set; }

        public Student()
        {
            courses = new List<Course>();
        }
        public Student(Student student)
        {
            this.ID = student.ID;
            this.Name = student.Name;
            this.courses = new();
        }
        public bool EnrollCourse(Course CourseName)
        {
            if (CourseName != null)
            {
                if (courses.Contains(CourseName))
                {

                    return false;

                }
                courses.Add(CourseName);
                return true;
            }
            return false;
        }
        public void DisplayDetails()
        {
            Console.WriteLine($"Name: {Name} -> ID: {ID}");
        }
        public void JoinCourses()
        {
            DisplayDetails();
            //Console.WriteLine("Cousres Added..");
            for (int i = 0; i < courses.Count; i++)
            {
                Console.WriteLine($"course {i+1}: ");
                courses[i].DisplayDetails();
            }

        }

    }
}
