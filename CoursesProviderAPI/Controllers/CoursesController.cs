using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CoursesProviderAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CoursesController : Controller
{
    private readonly CourseContext _context;

    public CoursesController(CourseContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<CourseModel>>> GetCourses()
    {
        return await _context.Courses.ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<CourseModel>> GetCourse(int id)
    {
        var course = await _context.Courses.FindAsync(id);

        if (course == null)
        {
            return NotFound();
        }

        return course;
    }

    [HttpPost]
    public async Task<ActionResult<CourseModel>> PostCourse(CourseModel course)
    {
        _context.Courses.Add(course);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetCourse), new { id = course.Id }, course);
    }
}
