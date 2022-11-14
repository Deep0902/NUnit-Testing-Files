using System;
using System.Collections.Generic;
using System.Text;
using MyAreas;
using NUnit.Framework;

namespace TestProjectMyAreas
{
    public class EmployeeTest
    {
        //Employee employee;
        public void setup()
        {
            //employee = new Employee();
        }
        //1. Write test case to check collections is having null employee
        [Test]
        public void Check_For_Null()
        {
            Employee emp = new Employee();
            List<Employee> employees = emp.GetEmployees();
            CollectionAssert.AllItemsAreNotNull(employees,"Contains null records");
        }
        
        //2. Write test case to check gender should be M or F
        [Test]
        public void Check_Gender()
        {
            Employee emp = new Employee();
            List<Employee> emplist = emp.GetEmployees();
            foreach (var e in emplist)
            {
                Assert.IsTrue(e.Gender == "M" || e.Gender == "F");
            }
        }
        
        //3. Write test case to check name is not null
        [Test]
        public void Check_Name_Null()
        {
            Employee emp = new Employee();
            List<Employee> emplist = emp.GetEmployees();
            foreach (var e in emplist)
            { 
                Assert.IsNotNull(emp.Name);
            }
        }
    }
}
