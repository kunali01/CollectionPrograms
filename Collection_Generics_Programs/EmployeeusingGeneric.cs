using System;
using System.Collections;

namespace FirstDemo1
{
    public class Employee : IComparable
    {
        private int salary;
        private string name;

        public Employee(int salary, string name)
        {
            this.salary = salary;
            this.name = name;
        }

        public int Salary
        {
            get { return salary; }
        }

        public int CompareTo(object obj)
        {
            Employee otherEmployee = (Employee)obj;
            return this.salary.CompareTo(otherEmployee.salary);
        }

        public override string ToString()
        {
            return $"Name={name}, Salary={salary}";
        }
    }

    public class Company : IEnumerable
    {
        Employee[] employees;

        public Company()
        {
            employees = new Employee[3];
            employees[0] = new Employee(75000, "Kunali");
            employees[1] = new Employee(50000, "Ishwari");
            employees[2] = new Employee(90000, "Mrunal");
        }

        public IEnumerator GetEnumerator()
        {
            return employees.GetEnumerator();
        }
    }

    public class CompareSalaries : IComparer
    {
        public int Compare(object x, object y)
        {
            Employee e1 = (Employee)x;
            Employee e2 = (Employee)y;
            return e1.Salary.CompareTo(e2.Salary);
        }
    }

    public class Program
    {
        //static void Main()
        //{
        //    Employee alice = new Employee(80000, "Kunali");
        //    Employee bob = new Employee(60000, "Mrunal");

        //    CompareSalaries salaryComparer = new CompareSalaries();
        //    int result = salaryComparer.Compare(alice, bob);

        //    if (result > 0)
        //    {
        //        Console.WriteLine("kunali has a higher salary than Mrunal.");
        //    }
        //    else if (result < 0)
        //    {
        //        Console.WriteLine("Mrunal has a higher salary than Kunali.");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Both have equal salaries.");
        //    }

        //    Console.WriteLine("\nCompany Employees:");
        //    var company = new Company();
        //    foreach (Employee emp in company)
        //    {
        //        Console.WriteLine(emp);
        //    }
        //}
    }
}
