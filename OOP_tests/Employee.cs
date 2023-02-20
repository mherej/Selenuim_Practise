using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_tests
{

    public class Employee
    {
        public int EmployeeNumber;
        public string FirstName;
        public string LastName;
        public DateTime DateOfHire;
        public string JobDescription;
        public string Department;
        public decimal MonthlySalary;

        public Employee()
        {
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

    }
}
