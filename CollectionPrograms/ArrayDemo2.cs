using System;
using System.Collections;
using System.Collections.Generic;

namespace CollectionPrograms
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        // Override ToString method to display Employee details
        public override string ToString()
        {
            return $"ID: {Id}, Name: {Name}, Salary: {Salary}";
        }
    }

    internal class ArrayDemo2
    {
        //static void Main(string[] args)
        //{
        //    Employee employee = new Employee { Id = 2, Name = "Rohan", Salary = 33000 };
        //    ArrayList list1 = new ArrayList();
        //    list1.Add(new Employee { Id = 1, Name = "Amol", Salary = 23000 });
        //    list1.Add(employee);

        //    ArrayList list2 = new ArrayList()
        //    {
        //        new Employee { Id = 1, Name = "KUnali", Salary = 23000 },
        //        new Employee { Id = 2, Name = "Ishwari", Salary = 33000 }
        //    };

        //    // Iterating through the ArrayList to print employee details
        //    foreach (Employee item in list2)
        //    {
        //        Console.WriteLine(item);
        //    }
        //}
    }
}
