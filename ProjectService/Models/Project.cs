﻿using System;
using System.Collections.Generic;

namespace ProjectService.Models
{
    public partial class Project
    {
        //public Project()
        //{
        //    Employee = new HashSet<Employee>();
        //}

        public int Pid { get; set; }
        public string project { get; set; }

        //public virtual ICollection<Employee> Employee { get; set; }
    }
}
