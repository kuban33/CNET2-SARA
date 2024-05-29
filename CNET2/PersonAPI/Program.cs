using PersonData;
using PersonModel;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<PeopleContext>();


var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.MapGet("/", () => "Hello" + Environment.NewLine +
"/person/{id}" + Environment.NewLine +
"/person/searchemail/{searchstr}");

app.MapGet("/people/all", (PeopleContext db) =>
{
    Thread.Sleep(5000);
    return db.People;
});

app.MapGet("/people/skip/{skip}/take/{take}", (int skip, int take, PeopleContext db) =>
{
    Thread.Sleep(200);
    return db.People.Skip(skip).Take(take);
});
    
app.MapGet("/person/{id}", (int id, PeopleContext db) =>
                            db.People.Where(x => x.Id == id).Single());

app.MapGet("/person/searchemail/{searchstr}", (string searchstr, PeopleContext db) =>
    db.People.Where(osoba => osoba.Email.ToLower().Contains(searchstr.ToLower()))
);

app.MapPost("/person/create", (Person person, PeopleContext db) =>
{
    db.People.Add(person);
    db.SaveChanges();
    return person;
});

app.MapPut("/person/edit", (Person person, PeopleContext db) =>
{
    var person_db = db.People.Where(x => x.Id == person.Id).Single();
    //person_db.FirstName = person.FirstName;

    db.Entry<Person>(person_db).CurrentValues.SetValues(person);
    db.SaveChanges();
    return person_db;
});

app.MapPost("/legalentity/create", (LegalEntity legalEntity, PeopleContext db) =>
{
    db.LegalEntities.Add(legalEntity);
    db.SaveChanges();
    return legalEntity;
});

app.MapGet("/legalentity/all", (PeopleContext db) => db.LegalEntities);

app.Run();


