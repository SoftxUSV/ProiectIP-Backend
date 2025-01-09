using Microsoft.AspNetCore.Mvc;
using ProiectIP.Models;
using ProiectIP.Models.Repositories;
using System.Linq;

[ApiController]
public class ExamController : Controller
{
    private readonly IExamRepository _examRepository;

    public ExamController(IExamRepository examRepository)
    {
        _examRepository = examRepository;
    }

    [HttpGet("examen/calendar/{groupId}")]
    public async Task<IActionResult> Calendar(int groupId)
    {
        var exams = await _examRepository.GetExamsByGroupAsync(groupId);

        if(exams == null || !exams.Any())
            return Json("NoExams");

        return Json(exams);
    }
}