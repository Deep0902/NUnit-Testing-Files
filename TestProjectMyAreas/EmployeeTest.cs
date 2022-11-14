﻿using System;
using System.Collections.Generic;
using System.Text;
using MyAreas;
using NUnit.Framework;

namespace TestProjectMyAreas
{
    public class EmployeeTest
    {
        Employee employee;
        public void setup()
        {
            employee = new Employee();
        }
        //1. Write test case to check collections is having null employee
        [Test]
        public void Check_For_Null()
        {
            List<Employee> employees = new List<Employee>();
            CollectionAssert.AllItemsAreNotNull(employees,"Contains null records");
        }
        
        //2. Write test case to check gender should be M or F
        [Test]
        public void Check_Gender()
        {
            List<Employee> employees = new List<Employee>();
            foreach (Employee emp in employees)
            {
                Assert.AreEqual(emp.Gender, "M","Gender only males");
            }
        }
        
        //3. Write test case to check name is not null
        [Test]
        public void Check_Name_Null()
        {
            List<Employee> employees = new List<Employee>();
            foreach (Employee emp in employees)
            {
                Assert.AreEqual(emp.Name, null,"Null present");
            }
        }
    }
}