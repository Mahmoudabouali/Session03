using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session03.models
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Age { get; set; }
        public int? DeptId { get; set; }
        public Department? ManagedDepartments { get; set; }
        public Department? Departments { get; set; }
        //public ICollection<Department> Departments { get; set; }

    }
}
