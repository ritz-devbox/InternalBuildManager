using BuildManager.API.Data;
using BuildManager.core.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BuildManager.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectsController : ControllerBase
    {
        private readonly AppDBContext _context;
        public ProjectsController(AppDBContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Project>>> GetProjects()
        {
            var projects = await _context.Projects.ToListAsync();
            return Ok(projects);
        }

        [HttpPost]

     public async Task<ActionResult<IEnumerable<Project>>> AddProject(Project pro)
        {
            _context.Projects.Add(pro);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetProjects), new {id = pro.Id}, pro);
        }
    }
}
