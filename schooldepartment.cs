using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
/*2.Use / Abstraction / to define different classes for each person type such as Student
   and Instructor. These classes should have behavior for that type of person.
   3. Use /Encapsulation/ to keep many details private in each class.
   4.Use / Inheritance / by leveraging the implementation already created in the Person
   class to save code in Student and Instructor classes.
   5. Use /Polymorphism/ to create virtual methods that derived classes could override to
   create specific behavior such as salary calculations.
   6. Make sure to create appropriate /interfaces/ such as ICourseService, IStudentService,
   IInstructorService, IDepartmentService, IPersonService, IPersonService (should have
   person specific methods). IStudentService, IInstructorService should inherit from
   IPersonService.
   Person
   Calculate Age of the Person
   Calculate the Salary of the person, Use decimal for salary
   Salary cannot be negative number
   Can have multiple Addresses, should have method to get addresses
   Instructor
   Belongs to one Department and he can be Head of the Department
   Instructor will have added bonus salary based on his experience, calculate his
   years of experience based on Join Date
   Student
   Can take multiple courses
   Calculate student GPA based on grades for courses
   Each course will have grade from A to F
   Course
   Will have list of enrolled students
   Department
   Will have one Instructor as head
   Will have Budget for school year (start and end Date Time)
   Will offer list of courses.
 */


namespace ConsoleApp2
{
    public interface Ipersonservice
    {
        int Calage();
        decimal Calsalary();
        IEnumerable<string> Getaddress();
    }
    public interface IStudentservice : Ipersonservice
    {
        double Calgpa();
    }
    public interface IInsturctorservice : Ipersonservice {
        int Calexperiece();
    }
    public abstract class Person : Ipersonservice {
        private string name;
        private DateTime birthday;
        private decimal salary;
        private List<string> addresses = new List<string>();
        public Person(string name, DateTime birthday, decimal salary) {
            this.name = name;
            this.birthday = birthday;
            this.salary = salary >= 0 ? salary : throw new ArgumentException("Salary can't e negative.");
        }
        public int Calage() => DateTime.Now.Year - birthday.Year;
        public decimal Calsalary() => salary;
        public void Address(string address) => addresses.Add(address);
        public IEnumerable<string> Getaddress() => addresses;
    }
    public class Course
    {
        public string Name { get; set; }
        public List<Student> Enrolledstudents { get; } = new List<Student>();
    }
    public class Student : Person, IStudentservice
    {
        private List<Course> courses = new List<Course> ();
        public Student(string name, DateTime birthday, decimal salary) : base(name, birthday, salary) { }
        public void Enrollcourse(Course course) => courses.Add(course);
        public double Calgpa()
        {
            return 0.0;
        }
        public List<Course> GetCourses() {  return courses; }
    }
    public class Instructor : Person, IInsturctorservice
    {
        private DateTime joinday;
        private Schooldepartment schooldepartment;
        public Instructor(string name, DateTime birthday, decimal salary, DateTime joinday, Schooldepartment schooldepartment) : base(name, birthday, salary)
        {
            this.joinday = joinday;
            this.schooldepartment = schooldepartment;
        }

        public int Calexperiece()
        {
            throw new NotImplementedException();
        }

        public int Calexperience() => DateTime.Now.Year - joinday.Year;
        public decimal Calsalary()
        {
            return base.Calsalary() + Calexperience() * 1000;
        }
    }
    public class Schooldepartment
    {
        public Instructor Head { get; set; }
        public decimal Budget { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public List<Course> Courses { get; } = new List<Course>();
    }
}
