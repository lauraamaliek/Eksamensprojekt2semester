using Core.Models;
using MongoDB.Driver;

namespace ServerAPI.Repositories;

public class UsersRepository
{
    private readonly IMongoCollection<UserModel> _user;

    public UsersRepository()
    {
        var client = new MongoClient("mongodb+srv://nielsdissingrasmussen_db_user:yOakkBrhAsnpGVDg@vestasdb.bbgywjg.mongodb.net/");
        var database = client.GetDatabase("Vestas");
        _user = database.GetCollection<UserModel>("Users");
    }

    public async Task<List<UserModel>> GetAll()
    {
        return await _user.Find(_ => true).ToListAsync();
    }

    public async Task<UserModel?> GetById(int id)
    {
        return await _user.Find(u => u._id == id).FirstOrDefaultAsync();
    }

    public async Task Create(UserModel user)
    {
        await _user.InsertOneAsync(user);
    }

    public async Task Update(UserModel user)
    {
        await _user.ReplaceOneAsync(u => u._id == user._id, user);
    }

    public async Task Delete(int id)
    {
        await _user.DeleteOneAsync(u => u._id == id);
    }
}