using PersonModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp
{
    internal class PersonData
    {
        private readonly string url;

        public PersonData(string url)
        {
            this.url = url;
        }

        public List<Person> GetAll()
        {
            var client = new HttpClient();
            var data = client.GetFromJsonAsync<List<Person>>($"{url}/people/all").Result;
            return data;
        }

        public async Task<List<Person>> GetAllAsync()
        {
            var client = new HttpClient();
            var data = await client.GetFromJsonAsync<List<Person>>($"{url}/people/all");
            return data;
        }

        public async Task<List<Person>> GetRangeAsync(int skip, int take)
        {
            var client = new HttpClient();
            var get_url = $"{url}/people/skip/{skip}/take/{take}";
            var data = await client.GetFromJsonAsync<List<Person>>(get_url);

            return data;

        }

        public async Task<int> GetPeopleCountAsync()
        {
            var client = new HttpClient();
            return await client.GetFromJsonAsync<int>($"{url}/people/count");
        }

    }
}
