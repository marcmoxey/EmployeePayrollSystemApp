using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayrollSystem
{
    public  class PayrollLogic
    {
        public static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to Employee Payroll System");
            Console.WriteLine("***********************************");
        }

        public static List<Dictionary<string, string>> CreateEmployees()
        {
            List<Dictionary<string, string>> employees= new List<Dictionary<string, string>>();
            // Adding employees
           employees.Add(new Dictionary<string, string> { 
               { "Name", "alice" }, 
               { "Salary", "50000" },
               { "Role", "Developer" } 
           });

            employees.Add(new Dictionary<string, string> { 
                { "Name", "bob" }, 
                { "Salary", "60000" }, 
                { "Role", "Manager" } }
            );

            employees.Add(new Dictionary<string, string> { 
                { "Name", "charlie" }, 
                { "Salary", "45000" }, 
                { "Role", "Designer" } 
            });

            return employees;
        }

        public static double CalculateTotalPayRoll(List<Dictionary<string, string>> employees)
        {
           double total = 0;
            List<string> payroll = new List<string>();

            // loop through list to get the index of salary 
            foreach (var employee in employees)
            {
                // add to list
                string salaryText = employee["Salary"];
                payroll.Add(salaryText);

                // convert to double 
                foreach (string pay in payroll)
                {
                    double.TryParse(pay, out double salary);

                    // add to total
                    total += salary;
                   
                }
            }
            Console.WriteLine($"The total payroll is {total}");
            return total;
        }

        public static void DisplayIndividualSalary(List<Dictionary<string, string>> employees)
        {
          
            // Ask user for employee name
            Console.Write("What is the employee name: ");
            string employeeName = Console.ReadLine().Trim();

            bool found = false;
            // loop through to find a match
            foreach (var employee in employees) 
            {
                // employee name matches get salary
                if (employee["Name"].Equals(employeeName, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"{employeeName} - Salary: {employee["Salary"]}");
                    found = true;
                    break;
                }
             
            }

            if(!found)
            {
                Console.WriteLine("Employee not found!");
            }

           
        }

        public static void UpdateEmployeeSalary(List<Dictionary<string, string>> employees)
        {
            

            // Ask user for employee name
            Console.Write("What is the name of employee, salary you want to update: ");
            string nameToUpdate = Console.ReadLine().Trim(); 

            bool found = false;

            // loop through to find a match
            foreach (var employee in employees)
            {
                // employee name matches get salary
                if (employee["Name"].Trim().Equals(nameToUpdate, StringComparison.OrdinalIgnoreCase))
                {
                    // ask what they want to update the salary to
                    Console.WriteLine($"Current Salary: {employee["Salary"]}");
                    Console.Write("Enter new salary: ");

                    // update salary in list 
                    employee["Salary"] = Console.ReadLine();
                    Console.WriteLine("Salary updated successfully!\n");

                    found = true;
                    break;
                }
            }

            if (!found) 
            {
                Console.WriteLine("Employee not found!");
            }
            

        }

        public static void DisplayEmployeesDetails(List<Dictionary<string, string>> employees)
        {
            // Check if the employees list is not empty
            if (employees.Count > 0)
            {
                Console.WriteLine("\nEmployee Details:");
                Console.WriteLine("--------------------");

                // Loop through each employee in the list
                foreach (var employee in employees)
                {
                    Console.WriteLine($"Name: {employee["Name"]}, Role: {employee["Role"]}, Salary: {employee["Salary"]}");
                }
            }
            else
            {
                Console.WriteLine("No employees found.");
            }
        }


    }
}
