namespace task_student_maanagment
{

  
    internal class Program
    {
        static void Main(string[] args)
        {
            Course course1 = new() { Name = "Math", Instructor = "mohamed" };
            Course course2 = new() { Name = "Arbic", Instructor = "Ahmed" };
            Course course3 = new() { Name = "c# Programming", Instructor = "Ali" };
            Course course4 = new() { Name = "Data Base", Instructor = "Alaa" };
            
            Student student1 = new() { ID = 1, Name = "salama" };
            Student student2 = new() { ID = 2, Name = "gehad" };
            Student student3 = new() { ID = 3, Name = "Abdo" };
            Student student4 = new() { ID = 4, Name = "Reda" };
            
            School school=new School();
            school.AddStudent(student1);
            school.AddStudent(student2);
            school.AddStudent(student3);
            school.AddStudent(student4);

            school.AddCourse(course1);
            school.AddCourse(course2);
            school.AddCourse(course3);
            school.AddCourse(course2);


            //school.DesplayAllStudents();
            //school.DesplayAllCourses();

            school.EnrollStudentInCourse(1, course1);
            school.EnrollStudentInCourse(1, course2);
            school.EnrollStudentInCourse(1, course3);

            Console.WriteLine("-----------------------------------");

            school.EnrollStudentInCourse(3, course1);
            school.EnrollStudentInCourse(3, course2);
            school.EnrollStudentInCourse(3, course4);



        }
    }
}