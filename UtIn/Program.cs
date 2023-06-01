using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace UtIn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Skriv ditt förnamn: "); // Här ber jag använadaren skriva sitt förnamn
            string Firstnamne = Console.ReadLine(); // Här använder jag en string variable för att spara texten i föregående fråga 
            Console.Write("Skriv ditt efternman: "); // Här ber jag använadaren skriva sitt efternamn
            string Lastname = Console.ReadLine(); // Här använder jag en string variable för att spara texten i föregående fråg
            Console.WriteLine("välkommen: " + Firstnamne + " " + Lastname); // Här kombinerar jag för och efternamns variablerna och skriver sedan ut dem 

            Console.Write("Skriv din ålder: "); // Här ber jag använadaren skriva sin ålder    
            int age = Convert.ToInt32(Console.ReadLine()); // Här sparar jag svaret från frågan över, genom att konvertera text till heltal 
            Console.WriteLine("Du är: " + (age * 365) + " " + "dagar gammal"); // Här skriver jag ut vad för ålder som angavs multiplicerat med 365 för att få dagar 
        }
    }
}
