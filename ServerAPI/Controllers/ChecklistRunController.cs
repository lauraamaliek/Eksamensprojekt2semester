using Core.Models;
using Microsoft.AspNetCore.Mvc;
using ServerAPI.Repositories;

namespace ServerAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ChecklistRunController : ControllerBase
{
    private readonly ChecklistRunRepository _checklist;


    public ChecklistRunController(ChecklistRunRepository checklist)
    {
        _checklist = checklist;
    }
}