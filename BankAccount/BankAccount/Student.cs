using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccount
{
    class Student
    {
        private cources[] courseTheStudentsIsIN;
        private rooms[] roomsTheStudentisIN;
        private string name;
        private string id;

        // constructor
        public Student(string name, string id)
        {
            this.name = name;
            this.id = id;
        }

        //copy constructor
        public Student(Student other)
        {
            this.name = other.name;
            this.id = other.id;
        }

        public String getName()
        {
            return name;
        }

        public String getID()
        {
            return id;
        }

        public String toString()
        {
            return "name: " + name + " id: " + id;
        }


        public bool equals(Student other)
        {
            //System.out.println("in equals(Object)");		
            bool result = false;
            if (other is Student)
            {
                Student otherStudent = (Student)other;
                result = id.Equals(otherStudent.getID());
            }
            return result;
        }
    }
}
