using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeService.Models;
namespace EmployeeService.Repositories
{
    public class EmployeeRepository
    {
        OrganisationContext db = new OrganisationContext();
        public List<Employee> GetAll()
        {
            return db.Employee.ToList();
        }
        public Employee GetEmployee(int Eid)
        {
            
            return db.Employee.SingleOrDefault(e => e.Eid == Eid);
        }
        public void AddEmployee(Employee emp)
        {
            db.Employee.Add(emp);
            db.SaveChanges();
        }
        public void UpdateEmployee(Employee emp)
        {
            db.Employee.Update(emp);
            db.SaveChanges();
        }
        public void DeleteEmployee(int Eid)
        {
            Employee emp = db.Employee.Find(Eid);
            db.Employee.Remove(emp);
            db.SaveChanges();
        }
    }
}
