using Core.Models;
using Microsoft.AspNetCore.Mvc;
using ServerAPI.Repositories;

namespace ServerAPI.Controllers;

[ApiController]
[Route("api/checklistrun")]
public class ChecklistRunController : ControllerBase
{
    private readonly ChecklistRunRepository _checklist;


    public ChecklistRunController(ChecklistRunRepository checklist)
    {
        _checklist = checklist;
    }
    
    [HttpGet]
    public string GetAll()
    {
        return "Det virker!";
    }
}