using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDashboard
{
    public class Employee
    {
        private int empId;
        public string empName;
        public double empSalary;
        private string empPerformance;
        public static string companyName;

        public Employee()
        {
            Console.WriteLine("Object created!!");
            Console.WriteLine("Launch browser");
        }

        public int EmpId
        {
            get
            {
                return empId;
            }
            set
            {
                if (value>100)
                {
                    empId = value;
                }
                else
                {
                    Console.WriteLine(" Failed ");
                }

            }
        }
        public string EmpPerformance
        {
            get
            {
                return empPerformance;
            }
            set
            {
                if (value.Equals("A") || value.Equals("B") || value.Equals("C"))
                {
                    empPerformance = value;
                }
                else
                {
                    Console.WriteLine("Please enter performance within A,B or C");
                }
            }
        }

        public void DisplayEmployeeDetails()
        {
            Console.WriteLine("Empoyee Id: " + empId);
            Console.WriteLine("Empoyee Name: " + empName);
            Console.WriteLine("Empoyee Salary: " + empSalary);
            Console.WriteLine("Empoyee Performance: " + empPerformance);
            Console.WriteLine("Company Name: " + Employee.companyName);
            Console.WriteLine("-----------------------");
        }

        //Allocate Bonus
        public void AllocateBonus()
        {
            if (empPerformance != null)
            {
                if (empPerformance == "A")
                {
                    empSalary = empSalary + 1000;
                }
                else if (empPerformance == "B")
                {
                    empSalary = empSalary + 500;
                }
                else
                {
                    empSalary = empSalary + 100;
                }

                Console.WriteLine("Salary of " + empName + " after bonus is " + empSalary);
            }
        }
        public static void GetInstance()
        {
            Employee emp = new Employee();
            //return emp;
        }

        public static void PrintEmpId(Employee emp)
        {
            Console.WriteLine("");
            Console.WriteLine("");
        }
    }
}