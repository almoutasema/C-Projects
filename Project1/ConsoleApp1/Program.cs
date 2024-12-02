using System; // Inkludera System-namnområdet för att använda Console-klassen

class Program // Definiera en klass som heter Program
{
    static void Main(string[] args) // Huvudmetoden där programmet startar
    {
        // Be användaren om priset för varan
        Console.Write("Ange pris: "); // Skriver ut en uppmaning till användaren
        int pris = int.Parse(Console.ReadLine()); // Läser in användarens inmatning och konverterar den till ett heltal

        // Be användaren om hur mycket de har betalat
        Console.Write("Betalt: "); // Skriver ut en uppmaning för att ange hur mycket som betalats
        int betalt = int.Parse(Console.ReadLine()); // Läser in beloppet som användaren betalat och konverterar det till ett heltal

        // Kontrollera om betalningen är otillräcklig
        if (betalt < pris) // Om det betalda beloppet är mindre än priset
        {
            Console.WriteLine("Du har betalat för lite."); // Meddela användaren att betalningen är otillräcklig
        }
        else // Om betalningen är tillräcklig
        {
            // Beräkna växeln som ska återbetalas
            int vaxel = betalt - pris; // Beräkna växeln genom att subtrahera priset från det betalda beloppet
            Console.WriteLine("Växel tillbaka: "); // Meddela användaren att växel ska ges tillbaka

            // Definiera en array av olika valörer som ska användas för växeln
            int[] valors = { 500, 200, 100, 50, 20, 10, 5, 1 }; // Array som innehåller valörerna i kronor
            string[] valörNamn = { "femhundralapp", "tvåhundralapp", "hundralappar", "femtiolappar", "tjugor", "tio", "femkrona", "enkronor" }; // Namn på valörerna

            foreach (int valor in valors) // Loopar igenom varje valör i arrayen
            {
                int antal = vaxel / valor; // Beräkna hur många av den aktuella valören som kan ges som växel
                if (antal > 0) // Om det finns någon växel av den aktuella valören
                {
                    // Skriv ut antalet av den aktuella valören som ska ges
                    Console.WriteLine(antal + " " + valörNamn[Array.IndexOf(valors, valor)]); // Meddelar hur många av den valören som ska ges
                    vaxel %= valor; // Uppdatera växelbeloppet genom att ta bort den använda valören
                }
            }
        }
    }
}
