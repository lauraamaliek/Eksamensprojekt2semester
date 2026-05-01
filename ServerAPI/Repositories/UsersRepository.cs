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
}