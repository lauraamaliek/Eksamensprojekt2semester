using Core.Models;
using Microsoft.AspNetCore.Mvc;
using ServerAPI.Interfaces;
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
    public Task<List<UserModel>> GetAll()
    {
        return _users.GetAll();
    }

    [HttpGet("{id}")]
    public async Task<UserModel?> GetById(int id)
    {
        return await _users.GetById(id);
    }

    [HttpPost]
    public async Task Create(UserModel user)
    {
        await _users.Create(user);
    }

    [HttpPut]
    public async Task Update(UserModel user)
    {
        await _users.Update(user);
    }

    [HttpDelete("{id}")]
    public async Task Delete(int id)
    {
        await _users.Delete(id);
    }
}