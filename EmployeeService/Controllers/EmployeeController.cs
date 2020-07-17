using EmployeeService.Models;
using EmployeeService.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EmployeeService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        EmployeeRepository _repo = new EmployeeRepository();
        // GET: api/<EmployeeController>
        [HttpGet]
        [Route("GetAll")]
        public IActionResult Get()
        {
            List<Employee> list = new List<Employee>();
            list = _repo.GetAll();
            return Ok(list);
        }

        // GET api/<EmployeeController>/5
        [HttpGet("{id}")]
        [Route("Get/{id}")]
        public IActionResult Get(int id)
        {
            Employee emp = new Employee();
            emp = _repo.GetEmployee(id);
            if(emp==null)
            {
                return NotFound("EMPLOYEE NOT FOUND");
            }
            else
            return Ok(emp);
        }

        // POST api/<EmployeeController>
        [HttpPost]
        [Route("Add")]
        public IActionResult Post(Employee emp)
        {
            _repo.AddEmployee(emp);
            return Ok("Employee Added");
        }

        // DELETE api/<EmployeeController>/5
        [HttpDelete("{id}")]
        [Route("Delete/{id}")]
        public IActionResult Delete(int id)
        {
             _repo.DeleteEmployee(id);
            return Ok("Employee Deleted");
        }

        [HttpPut]
        [Route("Update")]
        public IActionResult Put(Employee emp)
        {
            _repo.UpdateEmployee(emp);
            return Ok("Updated Succesfully");
        }
    }
}
