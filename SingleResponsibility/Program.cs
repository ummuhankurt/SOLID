using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeDef employeeDef = new EmployeeDef();
            employeeDef.EmployeeName = "George";
            employeeDef.EmployeeSurname = "Brown";
            employeeDef.City = "Tokyo";
            EmployeeCRUD employeeCRUD = new EmployeeCRUD();
            employeeCRUD.EmployeeAdd(employeeDef);
            employeeCRUD.EmployeeList();
            //employeeCRUD.EmployeeDelete(15);
            //Console.WriteLine("***********silindikten sonra****************");
            employeeCRUD.EmployeeList();
            EmployeeProcess employeeProcess = new EmployeeProcess();
            employeeProcess.Process();
            Console.WriteLine("This space is green");
            Console.ReadKey();
        }
    }
}
