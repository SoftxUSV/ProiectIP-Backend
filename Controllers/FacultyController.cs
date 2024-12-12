using Microsoft.AspNetCore.Mvc;
using ProiectIP.Models;
using ProiectIP.Models.Repositories;

public class FacultyController : Controller
{
    private const string GroupsPartialView = "PartialViews/_GroupsPartial";


    private readonly IFacultyRepository _facultyRepository;
    private readonly IGroupRepository _groupRepository;
    private readonly ISpecializationRepository _specializationRepository;

    public FacultyController(IFacultyRepository facultyRepository, IGroupRepository groupRepository, ISpecializationRepository specializationRepository)
    {
        _facultyRepository = facultyRepository;
        _groupRepository = groupRepository;
        _specializationRepository = specializationRepository;
    }

    public async Task<IActionResult> Index()
    {
        var faculties = await _facultyRepository.GetAllAsync(f => f.Specializations);
        return View(faculties);
    }

    [Route("facultate/specializare/{facultyId}")]
    public async Task<IActionResult> Specializations(int facultyId)
    {
        var faculty = await _facultyRepository.GetByIdAsync(facultyId);
        if(faculty == null) return NotFound();

        var specializations = await _specializationRepository.GetSpecializationsByFacultyAsync(facultyId);
        var viewModel = new FacultySpecializationsViewModel
        {
            Faculty = faculty,
            Specializations = specializations
        };

        return View(viewModel);
    }

    [HttpGet("facultate/GetGroupsBySpecialization/{specializationId}")]
    public async Task<IActionResult> GetGroupsBySpecialization(int specializationId)
    {
        var groups = await _groupRepository.GetGroupsBySpecializationAsync(specializationId);

        if (groups == null)
            return NoContent();

        return PartialView(GroupsPartialView, groups);
    }
}