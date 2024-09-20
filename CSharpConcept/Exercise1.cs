using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcept
{
    class Employee
    {
        int empNo;
        Employee(int empNo)
        {
            empNo = empNo;
        }
        static void Main1(string[] args)
        {
            Employee emp = new Employee(101);
            Console.WriteLine(emp.empNo);
        }
    }

}
