﻿using ConsoleApp;
using System.Reflection.Emit;


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

//for(int i = 0; i < jmena.Length; i++)
//{
//    var jmeno = jmena[i];
//    Console.WriteLine(jmeno);
//}




// Lukáš, Karel, Tomáš, Martin, Radim, Jakub, Sofián
// zeptat se na jméno a pozdravit
// nebo říct že neznám

//Console.WriteLine("Ahoj, zadej své jméno:");

//string jmeno = Console.ReadLine();

//switch (jmeno)
//{
//    case "Lukáš":
//        Console.WriteLine("Ahoj Lukáši");
//        break;
//    case "Karel":
//        Console.WriteLine("Ahoj Karle");
//        break;
//    case "Tomáš":
//        Console.WriteLine("Ahoj Tomáši");
//        break;
//    case "Martin":
//        Console.WriteLine("Ahoj Martine");
//        break;
//    case "Radim":
//        Console.WriteLine("Ahoj Radime");
//        break;
//    case "Jakub":
//        Console.WriteLine("Ahoj Jakube");
//        break;
//    case "Sofián":
//        Console.WriteLine("Ahoj Sofiáne");
//        break;
//    default:
//        Console.WriteLine("Takové jméno neznám.");
//        break;
//}


