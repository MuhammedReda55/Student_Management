using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_student_maanagment
{
    internal class School
    {
        private List<Student> students;
        private List<Course> courses;

        public School()
        {
            students = new List<Student>();
            courses = new List<Course>();
        }

        public bool AddStudent(Student student)
        {
           
               
                students.Add(student);
                return true;
            
        }
        public bool AddCourse(Course CourseName)
        {
               
                courses.Add(CourseName);
                return true;
            
        }
        public void DesplayAllStudents()
        {
            for (int i = 0; i < students.Count; i++)
            {
                students[i].DisplayDetails();
            }
        }
        public void DesplayAllCourses()
        {
            for (int i = 0; i < courses.Count; i++)
            {
                courses[i].DisplayDetails();
            }
        }
        public bool EnrollStudentInCourse(int studentId, Course CourseName)
        {
            
            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].ID == studentId)
                {
                   
                    students[i].EnrollCourse(CourseName);
                    //students[i].DisplayDetails();
                    students[i].JoinCourses();
                    
                    return true;
                }
            }
            return false;
        }
    }
}
