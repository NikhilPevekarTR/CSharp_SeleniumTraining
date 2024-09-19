using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDashboard
{
    public class EmployeeRunner
    {
        static void Main(string[] args)
        {
            Employee.companyName = "TR";
            Employee employee1 = new Employee();
            Employee employee2 = new Employee();
            Employee employee3 = new Employee();

            employee1.EmpId = -101; //set property
            employee1.empName = "Saul";
            employee1.empSalary = 9000;
            employee1.EmpPerformance = "B";

            employee2.EmpId = 102;
            employee2.empName = "Peter";
            employee2.empSalary = 7000;
            employee2.EmpPerformance = "A";

            employee3.EmpId = 103;
            employee3.empName = "Kim";
            employee3.empSalary = 4000;
            employee3.EmpPerformance = "C";

            Console.WriteLine(employee1.EmpId);
            Console.WriteLine(employee2.EmpId);
            Console.WriteLine(employee3.EmpId);

            employee1.DisplayEmployeeDetails();
            employee2.DisplayEmployeeDetails();
            employee3.DisplayEmployeeDetails();

            employee1.AllocateBonus();
            employee2.AllocateBonus();
            employee3.AllocateBonus();
        }
    }
}
