using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment10._2
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public double Salary { get; set; }
        public int Age { get; set; }

        public List<Employee> CreateData()
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee { Id = 1, Name = "Alice", Department = "HR", Salary = 60000, Age = 30 },
                new Employee { Id = 2, Name = "Bob", Department = "IT", Salary = 80000, Age = 35 },
                new Employee { Id = 3, Name = "Charlie", Department = "Finance", Salary = 75000, Age = 28 },
                new Employee { Id = 4, Name = "David", Department = "IT", Salary = 90000, Age = 40 },
                new Employee { Id = 5, Name = "Eve", Department = "HR", Salary = 62000, Age = 32 },
                new Employee { Id = 6, Name = "Frank", Department = "Finance", Salary = 70000, Age = 29 }
            };
            return employees;
        }
    }
}
