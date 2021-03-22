using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Task2
{
    class Student
    {
        public static int CourseLimit = 5;
        private Course[] courses;
        public Student()
        {
            this.courses = new Course[Student.CourseLimit];
        }
        public Student(string name, string id, float cgpa)
        {
            this.Name = name;
            this.Id = id;
            this.Cgpa = cgpa;
            this.courses = new Course[Student.CourseLimit];
        }
        public string Id { set; get; }
        public string Name { set; get; }
        public float Cgpa { set; get; }
        public int CourseCount { set; get; }

        public void AddCourse(params Course[] cr)
        {
            foreach (Course c in cr)
            {
                this.courses[this.CourseCount++] = c;
                if (c.GetStudent(this.Id) == null)
                    c.AddStudent(this);
            }

        }

        public Course GetCourse(string id)
        {
            for (int i = 0; i < this.CourseCount; ++i)
                if (id == this.courses[i].Id)
                    return this.courses[i];

            return null;
        }
        public void PrintCourse()
        {
            for (int i = 0; i < this.CourseCount; ++i)
            {
                this.courses[i].ShowCourseInfo();
            }
        }

        public void RemoveCourse(Course cr)
        {
            if (cr == this.courses[this.CourseCount - 1])
            {
                this.courses[this.CourseCount--] = null;
                cr.RemoveStudent(this);
                return;
            }

            bool notFound = true;
            for (int i = 0; i < this.CourseCount - 1; ++i)
            {
                if (cr == this.courses[i] && notFound)
                {
                    this.courses[i] = null;
                    this.CourseCount--;
                    cr.RemoveStudent(this);
                    notFound = false;
                }
                if (!notFound)
                    this.courses[i] = this.courses[i + 1];
            }
        }

        public void ShowInfo()
        {
            Console.WriteLine("Name: {0}, ID: {1}, CGPA: {2}", this.Name, this.Id, this.Cgpa);

        }
    }
}
