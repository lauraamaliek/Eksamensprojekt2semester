using Core.Models;
using Microsoft.AspNetCore.Mvc;
using ServerAPI.Repositories;

namespace ServerAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TemplatesController : ControllerBase
{
    private readonly TemplatesRepository _templates;


    public TemplatesController(TemplatesRepository templates)
    {
        _templates = templates;
    }
    
    [HttpGet]
    public string GetAll()
    {
        return "Det virker!";
    }
}