using PersonData;
using PersonModel;
using System.Net.Http.Json;

var url = "https://localhost:7036";

var client = new HttpClient();
int id = 228;

Person? p = await client.GetFromJsonAsync<Person>($"{url}/person/{id}");


Console.WriteLine(p);

Console.WriteLine("Zadej hledany email/cast: ");
string searchstr = Console.ReadLine();

List<Person>? ps  = await client.GetFromJsonAsync<List<Person>>($"{url}/person/searchemail/{searchstr}");
if (ps == null || ps.Count() == 0)
{
    Console.WriteLine("nenasel");
}
else
{
    foreach (Person person in ps)
    {
        Console.WriteLine(person);
    }
}

Console.ReadLine();

