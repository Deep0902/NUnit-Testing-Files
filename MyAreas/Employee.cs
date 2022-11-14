using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace MyAreas
{
    public  class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public string Gender { get; set; }

        public List<Employee> GetEmployees()
        {
            List<Employee> emplist = new List<Employee>()
            {
                new Employee{Id = 101, Name="Tom", Salary=25000, Gender="M"},
                new Employee{Id = 102, Name="Jerry", Salary=30000, Gender="M"},
                new Employee{Id = 103, Name="Noddy", Salary=36000, Gender="F"},
                new Employee{Id = 104, Name="Scooby", Salary=21000, Gender="M"},
                new Employee{Id = 105, Name="Oswald", Salary=40000, Gender="M"},
                new Employee{Id = 106, Name="Daphine", Salary=65000, Gender="F"},
                new Employee{Id = 107, Name="Wennie", Salary=50000, Gender="M"},
                new Employee{Id = 108, Name="Dexter", Salary=55000, Gender="M"}
            };
            return emplist;
        }
    }
}
