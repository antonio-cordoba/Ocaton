using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace UnitTestProject1
{
    class MockDB : IDatabase
    {
        IQueryable<Employee> _employees;

        public IQueryable<Employee> Employees
        {
            get
            {
                return _employees;
            }

            set
            {
                _employees = value;
            }
        }

        public void Save()
        {
            return;
        }
    }
}
