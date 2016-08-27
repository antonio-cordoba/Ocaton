using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class PayrollManager
    {
        private IDatabase _database;

        public PayrollManager(IDatabase x)
        {
            _database = x;
        }

        public decimal ProcessRaise(RaiseRequest raiseReq)
        {
            var employee = _database.Employees.SingleOrDefault(e => e.Id == raiseReq.EmployeeID);
            employee.Salary += raiseReq.RaiseAmount;
            _database.Save();
            return employee.Salary;
        }
    }
}
