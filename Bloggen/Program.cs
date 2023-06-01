﻿﻿﻿﻿using System;
using System.Threading;
using System.Collections.Generic;

namespace Bloggen
{
    // Vissa av kommentarerna som följe kan innehålla små stavfel men ska vara fullt förståliga ändå
    internal class Program
    {      
        static string Meny1() // tar ej emot data bara återger en sträng
        {
            string meny = "\n\t[1] Skriv nytt inlägg\n" +
                          "\t[2] Skriv ut allt\n" +
                          "\t[3] Sök i bloggen\n" +
                          "\t[4] Redigera bloggen\n" +
                          "\t[5] Avsluta\n" +
                          "\tVälj: ";
            return meny;
        }
        static string Meny2() // tar ej emot data bara återger en sträng
        {
            string meny = "\n\tVill du redigera eller radera ett inlägg\n" +
                          "\t[1] Redigera inlägg\n" +
                          "\t[2] Radera inlägg\n" +
                          "\t[3] Sluta redigera\n" +
                          "\tVälj: ";
            return meny;
        }

        static string[] Inlägg(string titel, string text) // tar emot 2 strängar och återger en strängvektor 
        {
            DateTime dateTime = DateTime.Now; // skapar en variabel inehållande vilken tid och datum den skapades 
            string date = Convert.ToString(dateTime); // konverterar tid och datum variabeln till en sträng
            string[] inlägg = new string[] { date, titel, text }; // skapar en ny strängvektor och lägger till alla 3 strängar date, titel och text

            return inlägg; // återger strängvektorn ur metoden
        }
        static string[] SökTitel(List<string[]> bloggInlägg, string sök) // tar emot en sträng för sökning samt listan och återger en strängvektor  
        {
            string[] returnString = new string[3]; // skapar en ny strängvektor med plats för 3 index/strängar
            foreach (string[] rader in bloggInlägg) // letar igenom listan efter alla strängvektorer
            {
                for (int i = 0; i < rader.Length; i++) // loppar igenom alla sparade strängvektorer i listan
                {
                    if (rader[1].ToLower() == sök.ToLower()) // jämför alla strängvektorers 2:a index(en sträng) mot en annan sträng för att se om någon matchar 
                    {
                        returnString = rader; // ifall de blir en match så sparas strängvektorn inehållade ordet i en annan strängvektor
                    }
                }
            }
            return returnString; // återger den nya strängvektorn ur metoden
        }       
        static void Main(string[] args)
        {
            Console.WriteLine("\n\tVälkommen till min blogg");
            bool meny = true; // Ska användas till en while loop, så länge denna är true så körs programmet
            List<string[]> bloggInlägg = new List<string[]>(); // en lista med strängvektorer 
            try // fångar upp fel som kan uppstå under körning 
            {
                while (meny) // så länge meny är sant så går programmet 
                {
                    Console.Write(Meny1()); // hämtar och skriver ut text från en metod
                    int.TryParse(Console.ReadLine(), out int val); // läser in och sparar vilken siffra som motsvarar ett val i texten från metoden ovan
                    switch (val) // skickar vidare till rätt case beroende på vilken siffra men skrev på föregående rad  
                    {
                        case 1: // här fyller man på strängvektorena och sedan sparar dem i listan 
                            Console.Clear(); // tömmer konsol fönstret, kommer förekomma många gånger i koden 
                            Console.Write("\tSkriv din titel: ");
                            string titel = Console.ReadLine();
                            Console.Write("\tSkriv ditt inlägg: ");
                            string text = Console.ReadLine();
                            bloggInlägg.Add(Inlägg(titel, text)); // här skickas strängarna till metoden för strängvektorn samtidigt som strängvektorn sparas i listan 
                            Console.Write("\tDitt inlägg är nu sparat");
                            System.Threading.Thread.Sleep(800); // stannar koden för x antal millisekunder, kommer förekomma många gånger i koden  
                            Console.Clear();
                            break;

                        case 2: // här skirvs allt innehåll i listan ut 
                            Console.Clear();                            
                            if (bloggInlägg.Count == 0) // kollar om listan är tom  
                            {
                                Console.WriteLine("\tBloggen är tom"); // talar om att det inte finns några in lägg i listan  
                            }
                            else // i fall listan inehåller något så körs följande kod
                            {
                                foreach (string[] rader in bloggInlägg) // letar igenom listan efter alla strängvektorer
                                {
                                    foreach (string rad in rader) // letar igenom strängvektorerna efter alla strängar
                                    {
                                        Console.WriteLine("\t" + rad); // skriver ut alla strängar
                                    }
                                }
                            }
                            System.Threading.Thread.Sleep(2000);
                            Console.Clear();
                            break;

                        case 3: // Söker efter rätt array och skriver sedan ut den 
                            if (bloggInlägg.Count == 0)
                            {
                                Console.WriteLine("\tBloggen är tom");    
                            }
                            else 
                            {
                                Console.Clear();
                                Console.Write("\n\tSkriv titeln på inlägget du söker: ");
                                string sök = Console.ReadLine();
                                Array.ForEach(SökTitel(bloggInlägg, sök), Console.WriteLine);
                                // här tas ett sökrod emot och skickas vidare tillsammas med listan till en metod
                                // sedan används en foreach för arrayer som skirver ut allt innehåll i arrayen som återges av metoden
                            }
                            break;

                        case 4:
                            if (bloggInlägg.Count == 0)
                            {
                                Console.WriteLine("\tBloggen är tom");    
                            }
                            else
                            {
                                Console.Clear();
                                bool underMeny = true;
                                while (underMeny) // här finns ytteligare en while loop som används för en undermeny
                                {
                                    Console.Write(Meny2()); // hämtar och skirver ut undermenyns text från en metod
                                    int.TryParse(Console.ReadLine(), out val);                                    
                                    switch (val)
                                    {
                                        case 1: // Redigerar inlägg
                                            Console.Write("\tVilket inlägg redigera: ");
                                            string sök = Console.ReadLine();
                                            Array.ForEach(SökTitel(bloggInlägg, sök), Console.WriteLine);
                                            Console.Write("\tÄndra titel: ");
                                            string nyTitel = Console.ReadLine(); // var tvungen att spara titeln i en ny sträng annars så tappar den vektorn när sökordet ändras 
                                            SökTitel(bloggInlägg, sök)[1] = nyTitel; 
                                            // här används samma metod för att söka på en strängvektor med hjälp av ett sökord 
                                            // återger den ösnkade strängvektorn som sedan redigeras i index 1 och 2, titel och text
                                            Console.Write("\tÄndra text: ");                                             
                                            SökTitel(bloggInlägg, nyTitel)[2] = Console.ReadLine(); // Ändrades inte sökordet här till vad som sattes i index 1 så skulle jag tappa vektorn                                             
                                            Console.WriteLine("\tDitt inlägg är nu redigerat\n");
                                            Array.ForEach(SökTitel(bloggInlägg, nyTitel), Console.WriteLine);
                                            System.Threading.Thread.Sleep(1000);
                                            Console.Clear();
                                            break;

                                        case 2: // Tar bort inlägg
                                            Console.Write("\tVilket inlägg vill radera: ");
                                            sök = Console.ReadLine();
                                            bloggInlägg.Remove(SökTitel(bloggInlägg, sök));
                                            // här används sökmetoden för att återge ösnkad strängvektor och samtidigt ta bort den ur listan
                                            Console.WriteLine("\tInlägg raderat");
                                            break;

                                        case 3: // avslutar undermenyn
                                            Console.Clear();
                                            underMeny = false;
                                            break;

                                        default: // ger ett meddelande om man ej valt 1-3
                                            Console.Clear();
                                            Console.WriteLine("\n\tVälj 1-3 från menyn.");
                                            break;
                                    }
                                }
                            
                            }
                            break;

                        case 5: // avslutar loopen och där med progammet 
                            meny = false;
                            break;

                        default: // ger ett meddelande om man ej valt 1-5
                            Console.Clear();
                            Console.WriteLine("\n\tVälj 1-5 från menyn.");
                            break;
                    }
                }
            }
            catch (Exception e) // skirver ut ett meddelande till användaren samt vilket fel/exception inträffade
            {
                Console.WriteLine("\nNågot gick fel!");
                Console.WriteLine(e); // Inget användaren egentligen behöver se
            }
        }
    }
}