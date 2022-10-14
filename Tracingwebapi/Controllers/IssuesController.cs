using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Tracingwebapi.Data;
using Tracingwebapi.Models;

namespace Tracingwebapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IssuesController : ControllerBase
    {
        private readonly IssueDbContext _context;

        public IssuesController(IssueDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IEnumerable<Issue>> Get()
        {
            return await _context.Issues.ToListAsync();
        }

        [HttpGet("id")]
        public async Task<IActionResult> GetByID(int id)
        {
            var issue = await _context.Issues.FindAsync(id);
            return issue == null ? NotFound() : Ok(issue); 
        }

        [HttpPost]
        public async Task<IActionResult> Create(Issue issue)
        {
            await _context.Issues.AddAsync(issue);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetByID), new {id = issue.Id}, issue);
        }
    }
}
