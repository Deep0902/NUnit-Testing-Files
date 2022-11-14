using NUnit.Framework;
using MyAreas;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System;
using System.Security.Cryptography.X509Certificates;
using System.Linq.Expressions;

namespace TestProjectMyAreas
{
    public class Tests
    {
        static int[] EvenNumbers = new int[] {2,4,5,6,8,9 };
        [Test, TestCaseSource(nameof(EvenNumbers))]
        public void EvenNosTest(int num)
        {
            Assert.IsTrue(num%2 == 0);
        }

        Banking banking;
        Areas areas;
        [SetUp]
        public void Setup() // This runs before tests run
        {
            areas = new Areas();
            banking = new Banking();
        }

        [TearDown]// Executed after every test
        public void Close()
        {
            areas = null;
        }

        [TestCase(30, 40, ExpectedResult = 1200)]
        [TestCase(50, 40, ExpectedResult = 2000)]
        [TestCase(70, 30, ExpectedResult = 3000)]
        [TestCase(80, 10, ExpectedResult = 800)]
        public int TestRectangle(int l, int b)
        {
            int actresult = areas.Rectangle(l, b);
            return actresult;
        }
        [Test]
        public void RectangleTest()
        {
            int l = 40, b = 30;
            int expresult = 1200;
            int actresult = areas.Rectangle(l, b);
            Assert.AreEqual(expresult, actresult, "Rectangle area wrong");
        }
        [Test]
        public void TriangleTest()
        {
            int h = 10, b = 30;
            float expresult = 150f;
            float actresult = 0f;
            actresult = areas.Triangle(h, b);
            Assert.AreEqual(expresult, actresult, "Values not same");
        }
        [Test]
        public void CircleTest()
        {
            //Arrange: Creating environment
            // Areas areas = new Areas();
            int raduis = 10;
            float expresult = 300f;
            float actualresult = 0f;

            //Act
            actualresult = areas.Circle(raduis);

            //Assert
            Assert.AreEqual(expresult, actualresult,15,"Areas not same");

        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
        public static IEnumerable<int[]> TestDataSum ()
        {
            string fname = "TestFile.txt";
            StreamReader reader = new StreamReader(fname);
            string line;
            while ((line = reader.ReadLine())!=null)
            {
                var data = line.Split(',');
                int a = int.Parse(data[0]);
                int b = int.Parse(data[1]);
                int c = int.Parse(data[2]);
                yield return new[] { a, b, c };
            }
            reader.Close();
        }
        [Test, TestCaseSource("TestDataSum")]
        public void SumTest(int x, int y, int expresult)
        {
            int actresult = areas.Sum2Nos(x, y);
            Assert.AreEqual(expresult, actresult, "Results not matched");
        }

        [Test]
        public void Login_Null_Message_Test()
        {
            string expresult = "Username and pass not empty";
            string actresult = areas.Login("Tom", null);
            Assert.AreEqual(expresult,actresult, "Not matched");
        }
        [Test]
        public void Login_Admin_Success_Message()
        {
            string actresult = areas.Login("admin", "admin");
            StringAssert.EndsWith("!", actresult, "Missing !");
        }
        [Test]
        public void Login_Invalid_Message_Test()
        {
            string actresult = areas.Login("Jerry", "mouse");
            StringAssert.Contains("Invalid", actresult, "Invalid not present");
        }
        [Test]
        public void GetNames_Has_UniqueValues()
        {
            List<string> names = areas.GetNames();
            CollectionAssert.AllItemsAreUnique(names, "Names are not unique");
        }
        [Test]
        public void GetNames_Has_Null_Values()
        {
            List<string> names = areas.GetNames();
            CollectionAssert.AllItemsAreNotNull(names, "Collection contains null values");
        }

        [Test]
        public void Debit_Correct()
        {
            banking.Id = 101;
            banking.Name = "Tom";
            banking.Balance = 5000;
            try
            {
                banking.Debit(2000);
                Assert.AreEqual(3000, banking.Balance, "Balance missmatch");
            }
            catch (System.Exception e)
            {
                Assert.AreEqual("Now balance = 0", e.Message);
            }
        }

        [Test]
        public void Credit_Correct()
        {
            banking.Id = 101;
            banking.Name = "Tom";
            banking.Balance = 1000;
            banking.Credit(500);
            banking.Debit(500);

            Assert.AreEqual(1000, banking.Balance, "Balance not 0");
        }
        //================================================================

    }
}