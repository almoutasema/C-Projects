using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions; // Används för att kontrollera inmatningsmönster

namespace SalesApp
{
    class Program
    {
        // Klass för att representera en säljare
        class Salesperson
        {
            public string Name { get; set; } // Säljarens namn
            public string PersonalNumber { get; set; } // Säljarens personnummer
            public string District { get; set; } // Säljarens distrikt
            public int SoldItems { get; set; } // Antal sålda artiklar

            // Konstruktor för att skapa en säljare med egenskaperna namn, personnummer, distrikt och antal sålda artiklar
            public Salesperson(string name, string personalNumber, string district, int soldItems)
            {
                Name = name;
                PersonalNumber = personalNumber;
                District = district;
                SoldItems = soldItems;
            }
        }

        static void Main(string[] args)
        {
            List<Salesperson> salespeople = new List<Salesperson>(); // Lista för att lagra säljare

            // 1. Be användaren ange hur många säljare de vill registrera
            Console.Write("Hur många säljare vill du registrera? ");
            int numSalespeople = int.Parse(Console.ReadLine()); // Konvertera inmatad text till ett heltal

            // 2. Läs in information för varje säljare
            for (int i = 0; i < numSalespeople; i++)
            {
                Console.WriteLine($"Säljare {i + 1}");

                // Kontrollera att namnet endast innehåller bokstäver
                string name;
                while (true)
                {
                    Console.Write("Namn:");
                    name = Console.ReadLine();
                    if (Regex.IsMatch(name, @"^[a-zA-ZåäöÅÄÖ]+$")) // Regex för att tillåta endast bokstäver
                        break;
                    else
                        Console.WriteLine("Ogiltigt namn! Vänligen ange endast bokstäver.");
                }

                // Kontrollera att personnumret endast innehåller siffror
                string personalNumber;
                while (true)
                {
                    Console.Write("Personnummer: ");
                    personalNumber = Console.ReadLine();
                    if (Regex.IsMatch(personalNumber, @"^\d+$")) // Regex för att tillåta endast siffror
                        break;
                    else
                        Console.WriteLine("Ogiltigt personnummer! Vänligen ange endast siffror.");
                }

                // Kontrollera att distriktet endast innehåller bokstäver
                string district;
                while (true)
                {
                    Console.Write("Distrikt:");
                    district = Console.ReadLine();
                    if (Regex.IsMatch(district, @"^[a-zA-ZåäöÅÄÖ]+$")) // Regex för att tillåta endast bokstäver
                        break;
                    else
                        Console.WriteLine("Ogiltigt distrikt! Vänligen ange endast bokstäver.");
                }

                // Kontrollera att antal sålda artiklar är ett giltigt tal
                int soldItems;
                while (true)
                {
                    Console.Write("Antal sålda artiklar n: ");
                    string input = Console.ReadLine();
                    if (int.TryParse(input, out soldItems)) // Kontrollera om inmatningen är ett giltigt heltal
                        break;
                    else
                        Console.WriteLine("Ogiltigt antal! Vänligen ange ett giltigt nummer.");
                }

                // Lägg till säljaren i listan
                salespeople.Add(new Salesperson(name, personalNumber, district, soldItems));
            }

            // 3. Sortera listan baserat på antal sålda artiklar, från högst till lägst
            salespeople.Sort((x, y) => y.SoldItems.CompareTo(x.SoldItems));

            // 4. Variabler för att hålla koll på antalet säljare i varje nivå
            int level1 = 0, level2 = 0, level3 = 0, level4 = 0;

            // 5. Skriv ut resultatet till en fil
            using (StreamWriter file = new StreamWriter("resultat.txt"))
            {
                // Loopa igenom varje säljare och skriv ut deras information
                foreach (var salesperson in salespeople)
                {
                    Console.WriteLine($"{salesperson.Name} {salesperson.PersonalNumber} {salesperson.District} {salesperson.SoldItems}");
                    file.WriteLine($"{salesperson.Name} {salesperson.PersonalNumber} {salesperson.District} {salesperson.SoldItems}");

                    // 6. Räkna antal säljare som når varje nivå
                    if (salesperson.SoldItems < 50)
                    {
                        level1++;
                    }
                    else if (salesperson.SoldItems < 100)
                    {
                        level2++;
                    }
                    else if (salesperson.SoldItems < 200)
                    {
                        level3++;
                    }
                    else
                    {
                        level4++;
                    }
                }

                // 7. Skriv ut sammanfattningen för varje nivå direkt efter att säljare i den nivån skrivs ut
                if (level1 > 0)
                {
                    Console.WriteLine($"{level1} säljare har nått nivå 1: under 50 artiklar");
                    file.WriteLine($"{level1} säljare har nått nivå 1: under 50 artiklar");
                }
                if (level2 > 0)
                {
                    Console.WriteLine($"{level2} säljare har nått nivå 2: 50-99 artiklar");
                    file.WriteLine($"{level2} säljare har nått nivå 2: 50-99 artiklar");
                }
                if (level3 > 0)
                {
                    Console.WriteLine($"{level3} säljare har nått nivå 3: 100-199 artiklar");
                    file.WriteLine($"{level3} säljare har nått nivå 3: 100-199 artiklar");
                }
                if (level4 > 0)
                {
                    Console.WriteLine($"{level4} säljare har nått nivå 4: över 199 artiklar");
                    file.WriteLine($"{level4} säljare har nått nivå 4: över 199 artiklar");
                }
            }
        }
    }
}