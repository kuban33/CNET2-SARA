// třída pro zvíře
//  * druh
//  * jméno
// vytvořit několik instancí
// vypsat do konzole

using ConsoleApp;

Animal zvire1 = new Animal("Mourek", Species.CAT);
Animal zvire2 = new Animal();
//Animal zvire3 = AnimalLibrary.Get();

zvire2.Name = "Alík";
zvire2.Species = Species.DOG;


Animal zvire3 = new("Mourek", Species.CAT);

var zvire4 = new Animal();
//zvire4 = "hello"; - chyba

// var zvire5 = new(); - nedava smysl

var zvire5 = new Animal()
{
    Name = "Rohlík",
    Species = Species.DOG,
};


//vypsat do konzole

Console.WriteLine($"zvíře, jméno: {zvire1.Name}, druh: {zvire1.Species}");

Console.WriteLine(zvire2);








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


