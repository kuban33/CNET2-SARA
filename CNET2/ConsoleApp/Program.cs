
using ConsoleApp;



var uppercase = "hello world".ToUpper();
Console.WriteLine(uppercase);

uppercase.ToLower();

Animal zv = new Animal("Mourek", Species.CAT);
zv.Rename("Kočka");

var isempty = String.IsNullOrEmpty(uppercase);

int x = 0;

bool isneg = int.IsNegative(x);

int num = int.Parse("15");

var je_prestupny = DateTime.IsLeapYear(2024);





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


