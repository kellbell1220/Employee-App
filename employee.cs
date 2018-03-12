using System;
using static System.Console;

namespace EmployeeApp
{
    class Employee
    {
        //Declaring Variables
        public String firstName;
        public String lastName;
        private String employeeID;
        public String hireDate;
        private double salary;
        public String jobDescription;
        public String department;
        
        //Default Constructor
        public Employee()
        {

        }

        public Employee(String employeeID, double salary)
        {
            this.employeeID = employeeID;
            this.salary = salary;
        }

        public Employee(String firstName, String lastName, String employeeID, String hireDate, double salary)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.employeeID = employeeID;
            this.hireDate = hireDate;
            this.salary = salary;
        }

        public Employee(String firstName, String lastName, String employeeID, String hireDate, double salary, String jobDescription, String department)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.employeeID = employeeID;
            this.hireDate = hireDate;
            this.salary = salary;
            this.jobDescription = jobDescription;
            this.department = department;
        }

        //Private Field for Employee Number Getter and Setter
        public String EmployeeID
        {
            get
            {
                return employeeID;
            }
            set
            {
                employeeID = value;
            }

        }

        //Private Field for Salary Getter and Setter
        public double Salary
        {
            get
            {
                return salary;
            }
            set
            {
                salary = value;
            }

        }

        public String ReturnFullName()
        {
            String name = firstName + " " + lastName;
            return name;
        }

        public String ReturnSortingName()
        {
            String name = lastName + ", " + firstName;
            return name;
        }

        public override string ToString()
        {
            return "Employee Name: " + ReturnFullName() + "\nEmployee Number: " + EmployeeID
                + "\nDate of Hire: " + hireDate + "\nJob Description: " + jobDescription + "\nDepartment: " + department
                + "\nSalary: " + Salary.ToString("C");
        }


    }
}
