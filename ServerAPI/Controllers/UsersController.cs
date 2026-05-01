using Core.Models;
using Microsoft.AspNetCore.Mvc;
using ServerAPI.Repositories;

namespace ServerAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UsersController : ControllerBase
{
    private readonly UsersRepository _users;


    public UsersController(UsersRepository users)
    {
        _users = users;
    }
    
    [HttpGet]
    public string GetAll()
    {
        return "Det virker!";
    }
}