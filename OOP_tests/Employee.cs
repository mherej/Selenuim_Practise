using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_tests
{

    public class Employee
    {
        public int EmployeeNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfHire { get; set; }
        public string JobDescription { get; set; }
        public string Department { get; set; }
        public decimal MonthlySalary { get; set; }

        public Employee()
        {
        }
        public Employee(int emplopeeNumber, string firstName, string lastName, string jobDescription)
        {
            EmployeeNumber = emplopeeNumber;
            FirstName = firstName;
            LastName = lastName;
            JobDescription = jobDescription;
        }

        public Employee(int employeeNumber, string firstName, string lastName, DateTime dateOfHire, string jobDescription, string department, decimal monthlySalary)
        {
            EmployeeNumber = employeeNumber;
            FirstName = firstName;
            LastName = lastName;
            DateOfHire = dateOfHire;
            JobDescription = jobDescription;
            Department = department;
            MonthlySalary = monthlySalary;
        }

        public string FullName
        {
            get { return FirstName + " " + LastName; }
        }

        public string SortableName
        {
            get { return LastName + ", " + FirstName; }
        }
         public string JobLocation()
        {
            if (JobDescription == "Manager")
            {
                return "Boston";
            }
            else if (JobDescription == "Staff")
            {
                return "Chicago";
            }
            return "New York";
        }

        public override string ToString()
        {
            return FullName + " " + "Job Tilte " + JobDescription;
        }
    }
}
