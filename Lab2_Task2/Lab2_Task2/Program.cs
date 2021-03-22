using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Task2
{
    class Program
    {
        static void Main(string[] args)
        {

            
            Student s1 = new Student("FAHIM Ahmmed", "1", 3.33f);
            Student s2 = new Student("Ahmmed mojumder ", "2", 3.99f);
            Student s3 = new Student("mojumder ahmmed", "3", 3.50f);
            Student s4 = new Student("ahmmed fahim", "4", 2.98f);
            Student s5 = new Student("fahim mojumder", "5", 3.00f);
            Student s6 = new Student("mojumder fahim", "6", 4.00f);


            Course c1 = new Course("1011", "OOP2");
            Course c2 = new Course("1012", "TOC");
            Course c3 = new Course("1013", "OOP1");


            c1.AddStudent(s1, s2, s3, s4, s5, s6);


            Console.WriteLine("\n~~~~~Add Student~~~~~\n");
            c2.AddStudent(s1, s2, s3, s4, s5, s6);
            c2.PrintStudent();



            Console.WriteLine("\n~~~~~After Remove Student~~~~~\n");
            c2.RemoveStudent(s6);
            c2.PrintStudent();

            Console.WriteLine("\n___________________________________________________________________________\n");

            Console.WriteLine("\n~~~~~~~~~~~~~Add Course~~~~~~~~~~~~~~~~~~\n");
            s2.AddCourse (c3);
            s2.PrintCourse();

            Console.WriteLine("\n~~~~~~~~~~~~~~~After Remove Course~~~~~~~~~~~~~~~\n");
            s2.RemoveCourse(c2);
            s2.PrintCourse();
        }
    }
}
