using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;
using System.Collections.Generic;
using System.Linq;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            var Personnel = new List<Employee>();
            var Victim = new Employee() { Id = new Guid(), Name = "Pancho Palos", Salary = 58000 };
            Personnel.Add(Victim);

            var db = new MockDB() { Employees = Personnel.AsQueryable() };

            var raise = new RaiseRequest() { EmployeeID = Victim.Id, RaiseAmount = 3500 };

            var pm = new PayrollManager(db);
            var result = pm.ProcessRaise(raise);

            Assert.AreEqual(result, 61500);

        }
    }
}
