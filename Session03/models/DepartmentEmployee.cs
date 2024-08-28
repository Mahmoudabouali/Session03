using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session03.models
{
    public class DepartmentEmployee
    {
        public int EmployeeId { get; set; }
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public string EmployeeName { get; set; }

        public override string ToString() => $"employee :{EmployeeName} :: Department :{DepartmentName}";
        
    }
}
