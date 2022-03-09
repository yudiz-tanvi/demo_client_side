using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ClientSideApi;

namespace ClientSideApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeInfoesController : ControllerBase
    {
        private readonly EmployeeDBContext _context;

        public EmployeeInfoesController(EmployeeDBContext context)
        {
            _context = context;
        }

        // GET: api/EmployeeInfoes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EmployeeInfo>>> GetEmployeeInfo()
        {
            return await _context.EmployeeInfo.ToListAsync();
        }

        // GET: api/EmployeeInfoes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EmployeeInfo>> GetEmployeeInfo(string id)
        {
            var employeeInfo = await _context.EmployeeInfo.FindAsync(id);

            if (employeeInfo == null)
            {
                return NotFound();
            }

            return employeeInfo;
        }

        // PUT: api/EmployeeInfoes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEmployeeInfo(string id, EmployeeInfo employeeInfo)
        {
            if (id != employeeInfo.EmpId)
            {
                return BadRequest();
            }

            _context.Entry(employeeInfo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmployeeInfoExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/EmployeeInfoes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<EmployeeInfo>> PostEmployeeInfo(EmployeeInfo employeeInfo)
        {
            _context.EmployeeInfo.Add(employeeInfo);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEmployeeInfo", new { id = employeeInfo.EmpId }, employeeInfo);
        }

        // DELETE: api/EmployeeInfoes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmployeeInfo(string id)
        {
            var employeeInfo = await _context.EmployeeInfo.FindAsync(id);
            if (employeeInfo == null)
            {
                return NotFound();
            }

            _context.EmployeeInfo.Remove(employeeInfo);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool EmployeeInfoExists(string id)
        {
            return _context.EmployeeInfo.Any(e => e.EmpId == id);
        }
    }
}
