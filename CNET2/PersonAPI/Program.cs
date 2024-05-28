using PersonData;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<PeopleContext>();


var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.MapGet("/", () => "Hello" + Environment.NewLine +
"/person/{id}" + Environment.NewLine +
"/person/searchemail/{searchstr}");

app.MapGet("/person/{id}", (int id, PeopleContext db) =>
                            db.People.Where(x => x.Id == id).Single());

app.MapGet("/person/searchemail/{searchstr}", (string searchstr, PeopleContext db) =>
    db.People.Where(osoba => osoba.Email.ToLower().Contains(searchstr.ToLower()))
);
                            

app.Run();


