using System;
using System.ComponentModel;

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
            var datumanalys = DateTime.TryParse(date.Insert(7,"-").Insert(4,"-"), out var datumcon);
            //om datumet är fel
            if(!datumanalys)
            {
                //om datumet är fel kommer detta upp "datumet är fel"
                Console.WriteLine("datumet är fel");
                Console.ReadLine();
                return;
            }
            //funktionen för att se om året är mellan 1753 och 2020 
             if (datumcon.Year < 1753 || datumcon.Year > 2020)

            {
                Console.WriteLine("året måsdte vara i mellan 1753-2020");
                var Year = Console.ReadLine();
                return;
            }
            // denna funktion kommer vara för att de om det är en kvinna eller man.
            String siffras = personnummer.Substring(8, 1);
            int siffrascon = int.Parse(siffras);
            int result = (siffrascon % 2); 
            //om det ären udda siffra så är det en man 
            if(result == 1)
            {
                Console.WriteLine("det är en man");
            }
            //om det inte är ett udda siffra så är det en 
            else
            {
                Console.WriteLine("det är en kvinna");
            }
            //när programmetär genomfört så ska detta medelande upp
            Console.WriteLine(" personummret är rätt tryck på en random knapp för att avsluta : D ");

            



                }
    }
}
