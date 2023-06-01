using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ryggsäcken_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kommentarerna kan i vissa fall vara felstavade men jag hoppas de ska gå att läsa ändå 
            // Jag hade svårt att komma på hur jag skulle göra programmet så jag ut gick ifrån meny exemplet och skrev efter det

            bool meny = true; // Sätter ett boolean värde i variabeln till sant som sedan ska användas i en while loop
            string sak = (""); // Skapar en tom string som skall skrivas till i senare skede   

            Console.WriteLine("Välkommen till Ryggsäcken!"); // Texten välkommnar användaren till programmet, ligger inte i loopen då ett välkommnade räcker

            while (meny) // skapar en while loop som fortsätter så länge meny är sant,behövs föra att menyn ska fungera som tänkt
            {

                Console.WriteLine("\n[1] Lägg till ett föremål"); // Texten frågar användaren om den vill lägga till ett föremål 
                Console.WriteLine("[2] Skirv ut innehållet"); // Texten frågar användaren om den vill skirva ut innehållet av alla föremål den skrivit in 
                Console.WriteLine("[3] Rensa innehåll"); // Texten frågar användaren om den vill rensa bort alla föremål som har skrivits in 
                Console.WriteLine("[4] Avsluta"); // Texten frågar användaren om den vill avsluta programmet
                Console.Write("Välj: "); // Texten ber användaren att göra ett val
                int num = Convert.ToInt32(Console.ReadLine()); // samlar in vilket val användare gör samt omvandlar det till en integer variabel som sedan används i en switch

                switch (num) // skapar en switch som tittar efter värdet i num variabeln för att veta vilket case som ska bli aktivt, switch passade i detta fallet.
                {
                    case 1: // Frågar om användaren vill lägga till något, sparar sedan värdet i variabeln samt visar vad som skrevs in
                        Console.Write("\nLägg till i ryggsäcken: ");
                        sak = Console.ReadLine();
                        Console.WriteLine("\n" + sak + " tillagt i ryggsäcken");
                        break;
                    case 2: // Skriver ut innehållet i konsolfönstret från variablen
                        Console.WriteLine("\nRyggsäcken inehåller: " + sak);
                        break;
                    case 3: // Rensar texten i variablen
                        sak = ("");
                        Console.WriteLine("\nRyggsäcken är nu tömd");
                        break;
                    case 4: // sätter bool variabeln till false och avslutar loopen
                        meny = false;
                        break;
                    default: // skriver ut ogiltigt val om användaren inte väljer 1-4
                        Console.WriteLine("Ogiltigt val");
                        break;
                }

            }
        }
    }
}
