using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ryggsäcken_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kommentarerna kan i vissa fall vara felstavade men jag hoppas de ska gå att läsa ändå 
            // Jag kopierade mitt tidigare program ryggsäck och skrev om det för att passa denna uppgiften

            bool meny = true; // Sätter ett boolean värde i variabeln till sant som sedan ska användas i en while loop
            string[] saker = new string[5];// { "", "", "", "", "" }; // Skapar en stringvektor med 5 element som skall skrivas till i senare skede, testade att skapa den utan värden men då kraschar det om man försöker söka innan man skirvit till den

            Console.WriteLine("Välkommen till Ryggsäcken!"); // Texten välkommnar användaren till programmet, ligger inte i loopen då ett välkommnade räcker

            while (meny) // skapar en while loop som fortsätter så länge meny är sant, behövs föra att menyn ska fungera som tänkt
            {

                Console.WriteLine("\n[1] Lägg till föremål"); // Texten frågar användaren om den vill lägga till föremål 
                Console.WriteLine("[2] Skirv ut innehållet"); // Texten frågar användaren om den vill skirva ut innehållet av alla föremål den skrivit in 
                Console.WriteLine("[3] Sök efter föremål"); // Texten frågar användaren om den vill söka efter ett föremål den skrivit in 
                Console.WriteLine("[4] Rensa innehåll"); // Texten frågar användaren om den vill rensa bort alla föremål som har skrivits in 
                Console.WriteLine("[5] Avsluta"); // Texten frågar användaren om den vill avsluta programmet
                Console.Write("Välj: "); // Texten ber användaren att göra ett val
                Int32.TryParse(Console.ReadLine(), out int num); // samlar in vilket val användare gör samt omvandlar det till en integer variabel som sedan används i en switch

                try // letar efter fel som kan uppstå
                {
                    switch (num) // skapar en switch som tittar efter värdet i num variabeln för att veta vilket case som ska bli aktivt, switch passade i detta fallet.
                    {
                        case 1: // Frågar om användaren vill lägga till något, sparar sedan värdet i 5 variabler                            
                            for (int i = 0; i < 5; i++) // for-loop som loopar så länge i är mindre än 5
                            {
                                Console.Write("Lägg till i ryggsäcken: "); // Texten frågar användaren om den vill lägga föremål
                                saker[i] = Console.ReadLine(); // spara värden i saker varibalen så länge loopen går, användersig av for-loopens i som räknare 
                            }
                            break;
                        case 2: // Skriver ut innehållet i konsolfönstret från sträng vektorn
                            foreach (string sak in saker) // loopar så länge det finns något sparat i variabeln saker 
                            {
                                Console.WriteLine(sak); // skriver ut de sparade värdena som ligger sparade i variablen saker med hjälp av en annan variabel sak som letar efter värden i första
                            }
                            break;
                        case 3: // gör det möjligt att söka på enstaka saker i variabeln
                            Console.Write("\nVad vill du söka efter: ");
                            string sparadSak = Console.ReadLine(); // variabel som sparar ett sökord som senare kommer jämföras mot det sparade värdena                            
                            foreach (string sak in saker) // loopar så länge det finns något sparat i variabeln saker 
                            {
                                if (sak == null) // kollar on variablen är tom
                                {
                                    throw new Exception("Ryggsäcken är tom"); // skapar ett fel meddelande i fall det tomt
                                    // försöket väldigt länge skirva detta med en console.writeLine men då blev det ju 5 meddelanden
                                }
                                else if (sak.ToLower() == sparadSak.ToLower()) // jämför de saparde värdena i vektorn saker med värdet i sparadSak, allt med små bokstäver oavsett hur man skrivit
                                {
                                    Console.WriteLine("finns i ryggsäcken");
                                }                              
                            }
                            // försökte med hjälp av en bool få till ett felmeddelande om det det inte gav någon träff, men lyckades inte klura ut hur jag skulle gå till väga

                            break;
                        case 4: // Rensar texten i variablen
                            Array.Clear(saker, 0, 5); // hittade ett sätt efter en snabb google sökning
                            Console.WriteLine("Ryggsäcken är nu tömd");
                            break;
                        case 5: // sätter bool variabeln till false och avslutar loopen
                            meny = false;
                            break;
                        default: // skriver ut ogiltigt val om användaren inte mellan 1-5
                            Console.WriteLine("Ogiltigt val");
                            break;
                    }
                }
                catch (Exception e) // fångar upp fel och sparar dem i en variabel
                {
                    Console.WriteLine(e);// Här skrivs felet ut
                    Console.WriteLine("\nNågot gick snett försök igen med ett annat val eller namn"); // uppmuntrar användaren att göra ett nytt försök
                }
            }
        }
    }
}