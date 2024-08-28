using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session03.models
{
    internal class FullTimeEmployee : CompanyEmployee
    {
        public DateOnly StartDate { get; set; }
        public Decimal Salary { get; set;}
    }
}
