﻿using System;
using System.Collections.Generic;

namespace EmployeeService.Models
{
    public partial class Project
    {
        //public Project()
        //{
        //    Employee = new HashSet<Employee>();
        //}

        public int Pid { get; set; }
        public string Project1 { get; set; }

        //public virtual ICollection<Employee> Employee { get; set; }
    }
}
