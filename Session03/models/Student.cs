﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session03.models
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Enrollments> Enrollments { get; set; }
    }
}
