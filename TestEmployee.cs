using System;
using static System.Console;

namespace EmployeeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create an Employee Object
            Employee employee1 = new Employee();
            employee1.firstName = AskUserInput("Employee's First Name");
            employee1.lastName = AskUserInput("Employee's Last Last");
            employee1.EmployeeID = AskUserInput("Employee's ID Number");
            employee1.hireDate = AskHireDate(employee1.firstName,employee1.lastName);
            employee1.Salary = AskEmployeeSalary();
            employee1.jobDescription = AskUserInput("Employee's Job Description");
            employee1.department = AskUserInput("Employee's Department");

            //Add Employee 2
            Employee employee2 = new Employee("C-2345", 95000);
            
            //Add Employee 3
            Employee employee3 = new Employee("Timothy", "Walnut", "C-2234", "01/01/2009", 75000, "C# Programmer Analyst", "Information Technology");

            //Add Employee 4
            Employee employee4 = new Employee("Maria", "Smith", "A-2334", "01/01/2008", 60000);

            //Printing out employee1
            String fullName = employee1.ReturnFullName().ToString();
            WriteLine("\n\tFirst Test");
            WriteLine(employee1.ToString());


            //Printing out employee2
            fullName = employee2.ReturnFullName().ToString();
            WriteLine("\n\n\tSecond Test");
            WriteLine("Employee Number: "+ employee2.EmployeeID);
            WriteLine("Salary: " + employee2.Salary.ToString("C"));

            //Printing out employee3
            fullName = employee3.ReturnFullName().ToString();
            WriteLine("\n\n\tThird Test");
            WriteLine(employee3.ToString());

            //Printing out employee4
            fullName = employee4.ReturnFullName();
            WriteLine("\n\n\tAnother Test");
            WriteLine("Employee Name: " + fullName);
            WriteLine("Employee Number: " + employee4.EmployeeID);
            WriteLine("Date of Hire: " + employee4.hireDate);
            WriteLine("Salary: " + employee4.Salary.ToString("C"));

            //Printing employee 4 in sort order
            WriteLine("\n\n\tLast Test");
            WriteLine("Last Employee, Shown In Sort Order");
            WriteLine("Name: " + employee4.ReturnSortingName());
            
            ReadKey();
        }



        //Aquiring Employee's first name, last name, EmployeeID, JobDescription, and Department
        static String AskUserInput(String whichOne)
        {
            Write("Enter {0}: ", whichOne);
            String inValue = ReadLine();

            return inValue;
        }

        //Aquiring Employee's Hire date and Display Employee's name
        static String AskHireDate(String firstName, String lastName)
        {
            Write("When was {0} {1} Hired? ",firstName,lastName);
            String inValue = ReadLine();

            return inValue;

        }

        //Aquiring Employee's Salary
        static double AskEmployeeSalary()
        {
            Write("Enter salary amount: ");
            String inValue = ReadLine();

            return double.Parse(inValue);
        }

    }

    
}

