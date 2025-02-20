

using EmployeePayrollSystem;

PayrollLogic.WelcomeMessage();

List<Dictionary<string, string>> employees = PayrollLogic.CreateEmployees();

string userInput;
PayrollLogic.DisplayEmployeesDetails(employees);

do
{
    Console.Write("Do you want to (update/view/details) employee salary or get total payroll (total): ");
    userInput = Console.ReadLine();

    if (userInput.ToLower().Trim() == "update")
    {
        PayrollLogic.UpdateEmployeeSalary(employees);

    }
    else if (userInput.ToLower().Trim() == "view")
    {

        PayrollLogic.DisplayIndividualSalary(employees);


    } else if(userInput.ToLower().Trim() == "total")
    {
        double totalPayroll = PayrollLogic.CalculateTotalPayRoll(employees);
    } else if (userInput.ToLower().Trim() == "details")
    {
        PayrollLogic.DisplayEmployeesDetails(employees);
    }


} while (userInput.ToLower() != "");



