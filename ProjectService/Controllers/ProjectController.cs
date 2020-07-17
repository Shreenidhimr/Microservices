using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjectService.Models;
using ProjectService.Repositories;
// For more information on enabling Web API for prjty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProjectService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
   
    public class ProjectController : ControllerBase
    {
        ProjectRepository _repo = new ProjectRepository();
        // GET: api/<ProjectController>
        [HttpGet]
        [Route("GetAll")]
        public IActionResult Get()
        {
            List<Project> list = new List<Project>();
            list = _repo.GetAll();
            return Ok(list);
        }

        // GET api/<ProjectController>/5
        [HttpGet("{id}")]
        [Route("Get/{id}")]
        public IActionResult Get(int id)
        {
            Project prj = new Project();
            prj = _repo.GetProject(id);
            if (prj == null)
            {
                return NotFound("Project NOT FOUND");
            }
            else
                return Ok(prj);
        }

        // POST api/<ProjectController>
        [HttpPost]
        [Route("Add")]
        public IActionResult Post(Project prj)
        {
            _repo.AddProject(prj);
            return Ok("Project Added");
        }

        // DELETE api/<ProjectController>/5
        [HttpDelete("{id}")]
        [Route("Delete/{id}")]
        public IActionResult Delete(int id)
        {
            _repo.DeleteProject(id);
            return Ok("Project Deleted");
        }

        [HttpPut]
        [Route("Update")]
        public IActionResult Put(Project prj)
        {
            _repo.UpdateProject(prj);
            return Ok("Updated Succesfully");
        }
    }
}
