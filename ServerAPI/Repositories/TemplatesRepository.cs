using Core.Models;
using MongoDB.Driver;

namespace ServerAPI.Repositories;

public class TemplatesRepository
{
    private readonly IMongoCollection<TemplateModel> _template;
        
    public TemplatesRepository()
    {
        var client = new MongoClient("mongodb+srv://nielsdissingrasmussen_db_user:yOakkBrhAsnpGVDg@vestasdb.bbgywjg.mongodb.net/");
        var database = client.GetDatabase("Vestas");
        _template = database.GetCollection<TemplateModel>("Templates");
    }
}