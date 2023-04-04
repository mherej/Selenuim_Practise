using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_tests
{
   public abstract class Person
   {
        string FirstName { get; set; }
        string LastName { get; set; }
        int Age { get; set; }

        public Person (string fname, string lname, int age)
        {
            FirstName = fname;
            LastName = lname;
            Age = age;
        }


        public abstract string GetHabits();
    }

    public class Student : Person
    {
        string studenID { get; set; }
        string Course { get; set; }

        public Student(string fname, string lname, int age, string sid, string cour) : base(fname, lname, age)
        {
            studenID = sid;
            Course = cour;
        }

        public override string GetHabits()
        {
            return "Breathe Air!!!";
        }
    } 
}
