using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class AnimalsMethods
    {
        public static void Animals()
        {
            // třída pro zvíře
            //  * druh
            //  * jméno
            // vytvořit několik instancí
            // vypsat do konzole

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

            var popis = zvire3.ToString();


            //vypsat do konzole

            Console.WriteLine($"zvíře, jméno: {zvire1.Name}, druh: {zvire1.Species}");

            Console.WriteLine(zvire2);
        }
    }
}
