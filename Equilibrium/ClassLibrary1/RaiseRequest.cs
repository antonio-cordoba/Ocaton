using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public struct RaiseRequest
    {
        public Guid EmployeeID { get; set; }
        public decimal RaiseAmount { get; set; }
    }
}
