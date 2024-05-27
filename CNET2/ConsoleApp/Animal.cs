using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp;

public class Animal
{
    private string _name;

    public Animal()
    {

    }
    public Animal(string name, Species species)
    {
        Name = name;
        Species = species;
    }

    public string Name { get; set; }


    public Species Species { get; set; }

    public override string ToString()
    {
        return $"zvíře z ToString, jméno: {Name}, druh: {Species}";
    }

}

public enum Species
{
    CAT,
    DOG
}

