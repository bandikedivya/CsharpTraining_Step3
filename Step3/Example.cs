using Method1_Advanced;
using System;
using System.Runtime.CompilerServices;

namespace Method2
{
    class Employee
    {
        public string EmpId { get; set; }
        public string EmployeeName { get; set; }

    }

    class EmpInfo
    {
        public static Employee EmpDetails()
        {
            Employee emp = new Employee();
            emp.EmpId = "123";
            emp.EmployeeName = "John";
            return emp;

        }

        public static Employee Update(Employee employee1)
        {
            employee1.EmployeeName = employee1.EmployeeName + " Alice";
            return employee1;
        }
    }
    class Program
    {
        static void Main()
        {
           Employee employee = EmpInfo.EmpDetails();
            Console.WriteLine($"Employee Id: {employee.EmpId}, Employee Name: {employee.EmployeeName}");

            Employee john = EmpInfo.Update(new Employee()

            {
                EmployeeName = "Ginny",
                EmpId = "12345",
            });
            Console.WriteLine($"Name: {john.EmployeeName}, Emp Id: {john.EmpId}");
                

        }
    }
}