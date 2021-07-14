using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccount
{
    class cources
    {
        private string courseName;
        private Teacher teacher;
        private Student[] students;
        private int max = 100;
        private int num_std;
        public cources(string courseName)
        {
            this.courseName = courseName;
            // make an empty list of students: 
            students = new Student[max];
            for (int i = 0; i < max; i++)
            {
                Console.WriteLine($"The name of student  {students}   and course the student is in {courseName}");
            }
        }
        public string GetCourseName()
        {
            return courseName;
        }
        public int size()
        {
            return students.Length;
        }
        public bool addStudents(Student newStudent)
        {
            if (num_std < max)
            {
                students[num_std++] = newStudent;
                return true;
            }
            return false;
        }
        public void DeleteStd(Student oldStudent)
        {

            for (int i = 0; i < max - 1; i++)
            {
                students[i] = students[i + 1] = oldStudent;
                students[max - 1] = null;
            }

        }
        public cources intersect(cources other)
        {
            cources intersection = new cources("intersection");

            foreach (var s in students)
            {
                if (other.contains(s))
                {
                    intersection.addStudents(s);
                }
            }
            return intersection;
        }

        private bool contains(Student s)
        {
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i].getID() == s.getID())
                {
                    return true;

                }
            }
            return false;
        }
    }
}
