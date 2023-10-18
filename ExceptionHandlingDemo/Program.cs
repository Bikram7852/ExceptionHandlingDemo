using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeLibrary;

namespace ExceptionHandlingDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Employee employee = new Employee();
                employee.EmpNo = 1;
                employee.EmpName = "Ajay";
                employee.Salary = 30000;
                employee.DeptNo = 101;
                Console.WriteLine(employee.EmpNo +"\n"+employee.EmpName + "\n" + employee.Salary + "\n" + employee.DeptNo);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
