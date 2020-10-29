using System;

namespace personnr
{
    class Program
    {
        static void Main(string[] args)
        {
            //programmet kommer fråga om ett 12 sifftrigt personnummer
            Console.WriteLine("skriv in ett 12 sifrigt personnummer: ");
            var personnummer = Console.ReadLine();


            //denna funktion ska kontrollera att det är ett 12 siffrigt nummer och inte 11 eller 13 siffrigt nummer
            // || = Resultatet av x || y är sant om antingen x eller y utvärderas till sant. Annars är resultatet falskt
            if (personnummer.Length < 12 || personnummer.Length > 12)
            {
                //om personnummret inte är 12siffrigt kommer "opps personnummret måste ha 12 siffror"
                Console.WriteLine(" opps personnummeret måste ha 12 siffror");
                Console.ReadLine();
                return;
            }
            //denna funktioon är för att se om datumet är korekt alltså de 8 första siffrorna 
            var date = personnummer.Substring(0, 8);
            var datumanalys = DateTime.TryParse(date.Insert(4, "-").Insert(7, "-"), out var datumcon);
            //om datumet är fel
            if(!datumanalys)
            {
                //om datumet är fel kommer detta upp "datumet är fel"
                Console.WriteLine("datumet är fel");
                Console.ReadLine();
                return;
            }
            
        }
    }
}
