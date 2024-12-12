using Microsoft.AspNetCore.Mvc;
using ProiectIP.Models;
using ProiectIP.Models.Repositories;

public class GroupController : Controller
{
    private readonly IGroupRepository _groupRepository;

    public GroupController(IGroupRepository groupRepository)
    {
        _groupRepository = groupRepository;
    }
}