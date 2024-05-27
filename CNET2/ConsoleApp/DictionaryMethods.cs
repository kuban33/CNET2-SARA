using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class DictionaryMethods
    {
        public static void DictionaryJmena()
        {
            string[] jmena = ["Lukáš", "Karel", "Tomáš", "Martin",
                    "Radim", "Jakub", "Sofián"];

            List<string> jmena_list = ["Lukáš", "Karel", "Tomáš",
                "Martin", "Radim", "Jakub", "Sofián"];


            List<string> jmena_list2 = new() {"Lukáš", "Karel", "Tomáš",
                "Martin", "Radim", "Jakub", "Sofián"};

            //foreach(string jmeno in jmena_list)
            //{
            //    Console.WriteLine(jmeno);
            //}

            Dictionary<string, string> jmenaOsloveni = new Dictionary<string, string>()
            {
                { "Lukas", "Lukasi" },
                { "Karel", "Karle" },
                { "Tomas", "Tomasi" },
            };

            Console.WriteLine("Ahoj, zadej své jméno:");

            string jmeno = Console.ReadLine();

            if (jmenaOsloveni.ContainsKey(jmeno))
            {
                Console.WriteLine($"Ahoj {jmenaOsloveni[jmeno]}.");
            }
            else
            {
                Console.WriteLine("neznam");
            }

        }

    }
}
