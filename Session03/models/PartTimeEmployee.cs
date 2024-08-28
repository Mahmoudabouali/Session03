using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session03.models
{
    internal class PartTimeEmployee : CompanyEmployee
    {
        public int HoureRate { get; set; }
        public int CountOfHoure { get; set; }
    }
}
