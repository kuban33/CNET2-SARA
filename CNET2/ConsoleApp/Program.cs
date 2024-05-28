//using ConsoleApp;
//using System.Reflection.Emit;
//using System.Linq;
//using ConsoleApp.SchoolModel;
using PersonModel;


var data = DatasetAccess.LoadData(@"C:\Users\Virtualpro\source\repos\CNET2-SARA\data2024.json");

int pocet_osob = data.Count();

Console.WriteLine(pocet_osob);

var person = data.First();
Console.WriteLine(person.Email);

var take2 = data.Take(1);
foreach (var item in take2)
    Console.WriteLine(item.Email);

//var p2 = data.Where(person =>  person.Email == "lukaskubicek@gmail.com")
//            .FirstOrDefault();

var p2 = data.Where(person => person.Email.Contains("gmail.com"))
            .FirstOrDefault();


if (p2 != null)
{
    Console.WriteLine(p2.Email);
}
else
{
    Console.WriteLine("p2 is null");
}

//data.Where(x => x.Email == "nekdo@domena.cz").Single();
data.Where(x => x.Id == 5).SingleOrDefault();

 var g = data.GroupBy(x => x.LastName);

foreach (var skupina in g)
{
    var lastname = skupina.Key;
    var pocet_lidi_ve_skupine = skupina.Count();

    //Console.WriteLine($"{lastname}: {pocet_lidi_ve_skupine}");
}

//ukol nejmladsi

//var nejmladsi = data.Where(x => x.DateOfBirth == data.Max(x => x.DateOfBirth)).ToArray();
var nejmaldsi = data.OrderByDescending(x => x.DateOfBirth).First();
Console.WriteLine(nejmaldsi);

var mesta_populace = data.GroupBy(x => x.Address.City).OrderByDescending(x => x.Count());
foreach (var skupina in mesta_populace)
{
    var mesto = skupina.Key;
    var pocet = skupina.Count();

    Console.WriteLine($"{mesto}: {pocet}");
}
