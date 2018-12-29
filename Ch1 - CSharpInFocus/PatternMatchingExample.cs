using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInFocus
{
    public enum UniversityCourses { Maths, Chemistry, Anatomy, LifeSkills }
    public enum UniversityDegree { BA, BSc }
    public enum Countries { USA, UK, Germany, Australia }
    public class PatternMatchingExample
    {
        
        public string GetPersonCourse(object someperson)
        {
            //// Before C# 7
            //if (someperson is Student)
            //{
            //    var student = (Student)someperson;
            //    var details = student.StudentDetails();
            //    return details.studentCourse;
            //}
            //else if (someperson is Lecturer)
            //{
            //    var lecturer = (Lecturer)someperson;
            //    return lecturer.CourseSpecialization;
            //}
            //else if (someperson is Alumnus)
            //{
            //    var alumnus = (Alumnus)someperson;
            //    return alumnus.DegreeObtained;
            //}

            //// The is type pattern
            //if (someperson is Student student)
            //{
            //    return student.StudentDetails().studentCourse;
            //}
            //else if (someperson is Lecturer lecturer)
            //{
            //    return lecturer.CourseSpecialization;
            //}
            //else if (someperson is Alumnus alumnus)
            //{
            //    return alumnus.DegreeObtained;
            //}
            //else if (someperson is ExchangeStudent exchStudent)
            //{
            //    return exchStudent.ShortCourse;
            //}



            // Using switch statements pattern matching
            switch (someperson)
            {
                case Student student:
                    return student.CourseEnrolledFor;
                case Lecturer lecturer:
                    return lecturer.CourseSpecialization;
                case Alumnus alumnus:
                    return alumnus.DegreeObtained;
                case ExchangeStudent exchangeStudent:
                    return exchangeStudent.ShortCourse;
                default:
                    return "No course determined";
            }
        }

        

    }


    public class Student : Person
    {
        public int StudentNumber { get; }
        public string CourseEnrolledFor { get; }
        public Student((string firstname, string lastname, int age) personDetails, int studentNumber, UniversityCourses courseEnrolled)
        {
            FirstName = personDetails.firstname;
            LastName = personDetails.lastname;
            Age = personDetails.age;
            StudentNumber = studentNumber;
            CourseEnrolledFor = nameof(courseEnrolled);
        }

        public (string firstname, string lastname, int studentNum, string studentCourse) StudentDetails()
        {
            var studentDetails = (FirstName, LastName, StudentNumber, CourseEnrolledFor);
            return studentDetails;
        }
    }

    public class Lecturer : Person
    {
        public int EmployeeNumber { get; }
        public string CourseSpecialization { get; }
        public int YearEmployed { get; }
        public Lecturer((string firstname, string lastname, int age) personDetails, int employeeNumber, UniversityCourses courseSpecialization, int yearFirstEmployed)
        {
            FirstName = personDetails.firstname;
            LastName = personDetails.lastname;
            Age = personDetails.age;
            EmployeeNumber = employeeNumber;
            CourseSpecialization = nameof(courseSpecialization);
            YearEmployed = yearFirstEmployed;
        }

        public (string, string, int, string, int) LecturerDetails()
        {
            var lecturerDetails = (FirstName, LastName, EmployeeNumber, CourseSpecialization, YearEmployed);
            return lecturerDetails;
        }
    }

    public class Alumnus : Person
    {
        public int YearCompleted { get; }
        public string DegreeObtained { get; }
        public Alumnus((string firstname, string lastname, int age) personDetails, int yearStudiesCompleted, UniversityDegree degreeObtained)
        {
            FirstName = personDetails.firstname;
            LastName = personDetails.lastname;
            Age = personDetails.age;
            YearCompleted = yearStudiesCompleted;
            DegreeObtained = nameof(degreeObtained);
        }

        public (string, string, int, string) AlumnusDetails()
        {
            var alumnusDetails = (FirstName, LastName, YearCompleted, DegreeObtained);
            return alumnusDetails;
        }
    }

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }               
    }
        
    public struct ExchangeStudent
    {
        public string FirstName { get; }
        public string LastName { get; }
        public string ShortCourse { get; }
        public int VisaExpiryDate { get; }

        public ExchangeStudent((string firstname, string lastname, int age) personDetails, UniversityCourses shortCourse, int studentVisaExpiry)
        {
            FirstName = personDetails.firstname;
            LastName = personDetails.lastname;
            ShortCourse = nameof(shortCourse);
            VisaExpiryDate = studentVisaExpiry;
        }

        public (string, string, string, int) ExchangeStudentDetails()
        {
            var exchangeDetails = (FirstName, LastName, ShortCourse, VisaExpiryDate);
            return exchangeDetails;
        }
    }
}
