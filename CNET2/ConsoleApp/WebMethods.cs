using PersonModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp;

internal class WebMethods
{
    
    async public void main()
    {
        var url = "https://localhost:7036";

        var client = new HttpClient();
        int id = 228;

        Person? p = await client.GetFromJsonAsync<Person>($"{url}/person/{id}");


        Console.WriteLine(p);

        Console.WriteLine("Zadej hledany email/cast: ");
        string searchstr = Console.ReadLine();

        List<Person>? ps = await client.GetFromJsonAsync<List<Person>>($"{url}/person/searchemail/{searchstr}");
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

    
    }

    async public void insert()
    {
        var url = "https://localhost:7036";

        var client = new HttpClient();

        Person p = new()
        {
            FirstName = "Jachym",
            LastName = "Hodhodostroje",
            DateOfBirth = new DateTime(2023, 5, 2),
            Email = "jachym@random.net"
        };

        var result = await client.PostAsJsonAsync<Person>($"{url}/person/create", p);
        var person_created = await result.Content.ReadFromJsonAsync<Person>();

        Console.WriteLine(person_created.Id);
        Console.ReadLine();

    }

    async public void edit()
    {
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
    }


}
