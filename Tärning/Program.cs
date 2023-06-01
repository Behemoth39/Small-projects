using System;
using System.Collections.Generic;
using System.Threading;

namespace Tärning
{
    class Program
    {
        // detta är en statisk metod med en int som ett returvärde
        // metoden tar en parameter i form av ett random objekt av
        // randomklassen
        static int RullaTärning(Random slumpObjekt, int tal) // lade till indata för tal
        {
            // här ska du skapa kod som slumpar fram ett tal
            // mellan 1 och 6, så att metoden "rullar" en 6 sidig
            // tärning när vi kallar på den
            // 
            return slumpObjekt.Next(1, tal + 1); // lade till möjlighet att kunna öka värdet på träningen

            // metoden ska sedan returnera det rullade värdet
        }
        static bool SökTärning(List<int> tärningar, int sök) // tar emot listan samt ett sök värde 
        {
            bool finns = false; // en bool som skall retuneras från metoden 
            foreach (int sökning in tärningar) // söker igenom alla värden sparade i listan tärningar 
            {
                if (tärningar.Contains(sök)) // jämfört alla värde i listan mot sök värdet 
                {
                    finns = true; // ger ett true värde om sökvärdet fanns
                }
            }
            return finns; // retunerar boolens värde
        }
        static void Main()
        {
            Random slump = new Random(); // Skapar en instans av klassen Random för vårt slumptal
            List<int> tärningar = new List<int>(); // listan för att spara våra rullade tärningar
            int tal = 6; // används för tärningens stolek 
            RullaTärning(slump, tal); // skickar värderna för slump och tal till metoden RullaTärning

            Console.WriteLine("\n\tVälkommen till tärningsgeneratorn!");

            bool kör = true;
            while (kör)
            {
                Console.WriteLine("\n\t[1] Tärnings storlek\n" +
                    "\t[2] Rulla tärning\n" +
                    "\t[3] Kolla vad du rullade\n" +
                    "\t[4] Sök efter tärning\n" +
                    "\t[5] Återställ antalet rullade tärningar\n" +
                    "\t[6] Avsluta");
                Console.Write("\tVälj: ");
                int val;
                int.TryParse(Console.ReadLine(), out val);

                switch (val)
                {
                    case 1: // Här sparas den nya storleken på tärningen
                        Console.Write("\n\tHur många sidor ska tärningen ha: ");
                        int.TryParse(Console.ReadLine(), out tal);
                        break;
                    case 2:
                        Console.Write("\n\tHur många tärningar vill du rulla: ");
                        bool inmatning = int.TryParse(Console.ReadLine(), out int antal);
                        if (inmatning)
                        {
                            for (int i = 0; i < antal; i++)
                            {
                                // här kallar vi på metoden RullaTärning
                                // och sparar det returnerade värdet i 
                                // listan tärningar
                                tärningar.Add(RullaTärning(slump, tal));
                                if (RullaTärning(slump, tal) == tal-1) // kollar om man rullat sitt maxvärde och i så fall rullar igen
                                {
                                    Console.WriteLine("\tGrattis du slog högsta! rullar igen");
                                    tärningar.Add(RullaTärning(slump, tal));
                                }
                            }                            
                        }
                        break;
                    case 3:
                        int sum = 0; // Skapar en int som ska innehålla medelvärdet av alla tärningsrullningar.

                        if (tärningar.Count <= 0)
                        {
                            Console.WriteLine("\n\tDet finns inga sparade tärningsrull! ");
                        }
                        else
                        {
                            Console.WriteLine("\n\tRullade tärningar: ");
                            tärningar.Sort(); // sortera värdena i listan, i stigande ordning 
                            foreach (int tärning in tärningar)
                            {
                                Console.WriteLine("\t" + tärning);
                                sum = sum + tärning; // lägger till alla värden från listan rullade tärningar till sum
                            }
                            Console.WriteLine("\n\tMedelvärdet på alla tärningsrull: " + sum / tärningar.Count); // Här ska medelvärdet skrivas ut                            
                        }
                        break;
                    case 4: // gör det möjligt att söka på efter rullade tärningar
                        {
                            Console.Write("\n\tVilken tärning söker du: ");
                            int.TryParse(Console.ReadLine(), out int sök);
                            if (SökTärning(tärningar, sök)) // kontrolerar om det värde man sökt efter finns
                            {
                                Console.WriteLine("\tFinns");
                            }
                            else
                            {
                                Console.WriteLine("\tFinns ej");
                            }
                        }
                        break;
                    case 5:
                        {
                            tärningar.Clear(); // resnsar infomationen i listan tärningar
                            Console.WriteLine("\n\tResultat återställt!");
                        }
                        break;
                    case 6:
                        Console.WriteLine("\n\tTack för att du rullade tärning!");
                        Thread.Sleep(1000);
                        kör = false;
                        break;
                    default:
                        Console.WriteLine("\n\tVälj 1-6 från menyn.");
                        break;
                }
            }
        }
    }
}