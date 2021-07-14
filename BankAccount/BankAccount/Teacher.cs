using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccount
{
   
        class Teacher : person
        {
            private cources[] courseTheTeacherTeachesIN;
            private rooms[] roomsTheTeacherTeachesIN;
            string name;
            string id;
            // constructor
            public Teacher(string name, string id)
            {
                this.name = name;
                this.id = id;
            }

            //copy constructor
            public Teacher(Teacher other)
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


            public bool equals(Teacher other)
            {
                //System.out.println("in equals(Object)");		
                bool result = false;
                if (other is Teacher)
                {
                    Teacher otherTeacher = (Teacher)other;
                    result = id.Equals(otherTeacher.getID());
                }
                return result;
            }
        }
}
