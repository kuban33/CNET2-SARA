using PersonData;
using PersonModel;
using System.Net.Http.Json;

var url = "https://localhost:7036";

var client = new HttpClient();

List<LegalEntity> legalEntities = new()
{
    new LegalEntity()
    {
        Id = 0,
        Name = "Industry",
        RegistrationNumber = 788776,
    },
    new LegalEntity()
    {
        Id = 0,
        Name = "Enterprise",
        RegistrationNumber = 832873,
    },
    new LegalEntity()
    {
        Id = 0,
        Name = "Technology",
        RegistrationNumber = 324321421,
    },
};

foreach (var entity in legalEntities)
{
    var result = await client.PostAsJsonAsync<LegalEntity>($"{url}/legalentity/create", entity);
    var legalentity_created = await result.Content.ReadFromJsonAsync<LegalEntity>();

    Console.WriteLine(legalentity_created.Id);
}


Console.ReadLine();

