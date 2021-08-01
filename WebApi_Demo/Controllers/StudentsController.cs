using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApi_Demo.Models;

namespace WebApi_Demo.Controllers
{

    [Route("api/[controller]")]
    [ApiController]

    public class StudentsController : Controller
    {
        private readonly StudentContext _context;


        public StudentsController(StudentContext context)
        {
            _context = context;
        }

        //Get Student

        [HttpGet]

        public async Task<ActionResult<IEnumerable<Students>>> GetStudents()
        {
            return await _context.Students.ToListAsync();
        }
       // [ActionName("GetStudent")]
        [HttpGet("{id}")]
        public async Task<ActionResult<Students>> GetStudent(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var paymentDetail = await _context.Students
                .FirstOrDefaultAsync(m => m.Id == id);
            if (paymentDetail == null)
            {
                return NotFound();
            }

            return paymentDetail;
        }

        [HttpPost]
        public async Task<ActionResult<Students>> PostStudent(Students student)
        {
            try
            {
                if (student == null)
                    return BadRequest();
                _context.Students.Add(student);
                await _context.SaveChangesAsync();
                return CreatedAtAction("GetStudent",routeValues: new { id = student.Id },value: student);
            }
            catch(Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,"Error createing new student record");
            }
            
        }
        [HttpPut("{id}")]
        public async Task<ActionResult<Students>> UpdateStudent(string id, Students student)
        {
            if (id != student.Id)
            {
                return BadRequest("Student id mismatch");
            }
            _context.Entry(student).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch(Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error updating student record");

            }
            return NoContent();
        }

        // DELETE
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteStudent(string id)
        {
            var paymentDetail = await _context.Students.FindAsync(id);
            if (paymentDetail == null)
            {
                return NotFound();
            }

            _context.Students.Remove(paymentDetail);
            await _context.SaveChangesAsync();

            return NoContent();
        }

    }
}
