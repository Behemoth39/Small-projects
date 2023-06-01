using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FelHant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Deklaration av variabler
            Random slumpat = new Random(); // skapar ett random objekt
            int speltal = slumpat.Next(1, 21); // anropar Next metoden för att skapa ett slumptal mellan 1 och 20 - saknade spannet som skulle slumpas inom
            // läs på, vad är overload metoder? https://msdn.microsoft.com/en-us/library/system.random.next(v=vs.110).aspx
            bool spela = true; // Variabel för att kontrollera om spelet ska fortsätta köras
            int antal = 1; // lade till en int för att hålla koll på antalet gissningar
            string p = (""); // lade till en string för att användas för att avsluta eller fortsätta loopen

            while (spela) // satt ! för omvänt värde, vilket stoppade loopen 
            {
                Console.Write("\n\tGissa på ett tal mellan 1 och 20: ");
                if (Int32.TryParse(Console.ReadLine(), out int tal)) // lade till en TryParse samt en if sats
                {
                    if (tal < speltal)
                    {
                        Console.WriteLine("\tDet inmatade talet " + tal + " är för litet, försök igen.");
                        Console.Write("\tAntal gissningar: " + antal++); // skriver ut antalet gissningar 
                    }

                    else if (tal > speltal) // lade till else
                    {
                        Console.WriteLine("\tDet inmatade talet " + tal + " är för stort, försök igen."); // sakande ett +
                        Console.Write("\tAntal gissningar: " + antal++); // skriver ut antalet gissningar 
                    }

                    else if (tal == speltal) // försökte sätta ett värde istället för att jämföra samt lade till else
                    {
                        //kod blocket sakandes
                        Console.WriteLine("\tGrattis, du gissade rätt!");
                        Console.WriteLine("\tAntal gissningar: " + antal); // skriver ut antalet gissningar 
                        Console.Write("\tVill du spela igen? J/N: "); // frågar om man vill fortsätta eller avsluta  
                        p = Console.ReadLine();
                        antal = 1; // åter ställer antalet gissningar
                        speltal = slumpat.Next(1, 21); // slumpar fram en ny siffra
                    }

                    else if (p == "n" || p == "N") // används för att avsluta programmet
                    {
                        spela = false;
                    }
                }

                else // använder if satsen för att förklara för användaren vad den gjort för fel
                {
                    Console.Write("\tDu måste välja en siffra mellan 1 och 20");
                }
            }
        }
    }
}
