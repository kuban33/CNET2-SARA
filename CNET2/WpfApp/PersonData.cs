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
    }
}
