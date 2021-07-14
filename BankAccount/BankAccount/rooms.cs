using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccount
{
    class rooms
    {
        private Teacher teacher;
        private Student[] students;
        private string room;
        private int max;
        private int numOFstd;

        public rooms(string room)
        {
            students = new Student[max];
            this.room = room;
            for (int i = 0; i < max; i++)
            {
                Console.WriteLine($"The name of student  {students}   and course the student is in {room}");
            }
        }
        public string GetCourseName()
        {
            return room;
        }
        public int size()
        {
            return students.Length;
        }
        public bool addStudents(Student newStudent)
        {
            if (numOFstd < max)
            {
                students[numOFstd++] = newStudent;
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
        public rooms intersect(rooms other)
        {
            rooms intersection = new rooms("add to room");

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
