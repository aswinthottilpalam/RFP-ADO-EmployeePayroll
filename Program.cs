using System;

namespace EmployeePayrollService
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Payroll!");

            EmployeeRepo repo = new EmployeeRepo();
            //EmployeeModel employee = new EmployeeModel();
            EmployeePayroll employee = new EmployeePayroll();


            employee.EmployeeName = "MS Dhoni";
            employee.PhoneNumber = "999888770";
            employee.Address = "3-161-21";
            employee.Department = "HR";
            employee.Gender = 'M';
            employee.BasicPay = 22000.00;
            employee.Deductions = 1500.00;
            employee.TaxablePay = 200.00;
            employee.Tax = 300.00;
            employee.NetPay = 25000.00;
            employee.City = "Bangalore";
            employee.Country = "India";

            repo.AddEmployee(employee);

            repo.GetAllEmployee();
        }
    }
}
