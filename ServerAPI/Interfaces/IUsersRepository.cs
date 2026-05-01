using Core.Models;

namespace ServerAPI.Interfaces;

public interface IUsersRepository
{
    Task<List<UserModel>> GetAll();
    Task<UserModel?> GetById(string id);
    Task Create(UserModel user);
    Task Update(UserModel user);
    Task Delete(string id);
}

