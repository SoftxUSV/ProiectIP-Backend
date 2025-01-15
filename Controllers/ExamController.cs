using Microsoft.AspNetCore.Mvc;
using ProiectIP.Models;
using ProiectIP.Models.Repositories;
using System.Linq;

[ApiController]
public class ExamController : Controller
{
    private readonly IExamRepository _examRepository;
    private readonly IGroupRepository _groupRepository;

    public ExamController(IExamRepository examRepository, IGroupRepository groupRepository)
    {
        _examRepository = examRepository;
        _groupRepository = groupRepository;
    }

    [HttpGet("examen/calendar/{groupId}")]
    public async Task<IActionResult> Calendar(int groupId)
    {
        var exams = await _examRepository.GetExamsByGroupAsync(groupId);

        if(exams == null || !exams.Any())
            return Json("NoExams");

        return Json(exams);
    }

    [HttpPost]
    [Route("api/exams")]
    public async Task<IActionResult> Create([FromBody] ExamModel exam)
    {
        if (exam == null || !ModelState.IsValid)
        {
            return BadRequest("Invalid exam data.");
        }

        try
        {
            var group = await _groupRepository.GetByIdAsync(exam.GroupId);
            exam.Group = group;
            await _examRepository.AddAsync(exam);
            return Ok(new { message = "Exam created successfully!" });
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Internal server error: {ex.Message}");
        }
    }
}