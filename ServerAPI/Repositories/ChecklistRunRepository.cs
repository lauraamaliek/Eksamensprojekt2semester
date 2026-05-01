using Core.Models;
using MongoDB.Driver;

namespace ServerAPI.Repositories;

public class ChecklistRunRepository
{
    private readonly IMongoCollection<ChecklistRunModel> _checklistRun;
  
    public ChecklistRunRepository()
    {
        var client = new MongoClient("mongodb+srv://nielsdissingrasmussen_db_user:yOakkBrhAsnpGVDg@vestasdb.bbgywjg.mongodb.net/");
        var database = client.GetDatabase("Vestas");
        _checklistRun = database.GetCollection<ChecklistRunModel>("ChecklistRun");
    }
}