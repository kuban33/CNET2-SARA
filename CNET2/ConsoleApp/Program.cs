﻿using ConsoleApp;
using System.Reflection.Emit;
using System.Linq;
using ConsoleApp.SchoolModel;

Person osoba = new Person("Typek", DateOnly.Parse("1990-01-01"));
Console.WriteLine(osoba);

Student s1 = new Student("Lucie", new DateOnly(2008, 8, 30), "Oktava A");
Console.WriteLine(s1);

//LINQMethods.ukol();

//DictionaryMethods.DictionaryJmena();




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


