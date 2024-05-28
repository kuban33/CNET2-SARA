using PersonData;
using PersonModel;
using System.Net.Http.Json;

var url = "https://localhost:7036";

var client = new HttpClient();

int id = 228;
Person? p = await client.GetFromJsonAsync<Person>($"{url}/person/{id}");
Console.WriteLine(p);

p.Email = "novy@email.cz";

var resut = await client.PutAsJsonAsync<Person>($"{url}/person/edit", p);

p = await client.GetFromJsonAsync<Person>($"{url}/person/{id}");

Console.WriteLine(p);
Console.ReadLine();
