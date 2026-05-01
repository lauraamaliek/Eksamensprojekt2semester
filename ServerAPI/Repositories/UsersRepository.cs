using Core.Models;
using MongoDB.Driver;

namespace ServerAPI.Repositories;

public partial class ChecklistRunRepository
{
    private readonly IMongoCollection<ChecklistRun> _checklistRun;
  
    public ChecklistRunRepository()
    {
        var client = new MongoClient("mongodb+srv://nielsdissingrasmussen_db_user:yOakkBrhAsnpGVDg@vestasdb.bbgywjg.mongodb.net/");
        var database = client.GetDatabase("Vestas");
        _checklistRun = database.GetCollection<ChecklistRun>("ChecklistRun");
    }
}