using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace PersonModel
{
    public class DatasetAccess
    {
        public static List<Person> LoadData(string filepath)
        {
            if (!File.Exists(filepath))
            {
                throw new FileNotFoundException("File not found");
            }

            try
            {
                var filecontent = File.ReadAllText(filepath);
                var people = JsonSerializer.Deserialize<List<Person>>(filecontent);
                return people;

            }
            catch (Exception ex)
            {
                // co stim
                // Loggger.Log(ex.Message)
                Console.Write("ERROR: " + ex.Message);
                //return null;
                throw ex;
            }

        }
    }
}
