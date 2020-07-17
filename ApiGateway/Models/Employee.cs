using System;
using System.Collections.Generic;

namespace ApiGateway.Models
{
    public partial class Employee
    {
        public int Eid { get; set; }
        public string Ename { get; set; }
        public DateTime? JoinDate { get; set; }
        public string Project { get; set; }

        public virtual Project ProjectNavigation { get; set; }
    }
}
