using System;

class Program
{
    static void Main()
    {
        string[] pets = { "cat", "dog", "parrot", "guinea pig" };

        Console.WriteLine("Wywołanie pętli foreach na elementach pets:");

        foreach (string pet in pets)
        {

            if (pet == "dog")
            {
                
                Console.WriteLine("End");
                continue; // Przerwij pętlę, gdy natrafisz na "dog"
            }
            Console.WriteLine(pet);
        }

        Console.ReadLine(); // Zatrzymuje konsolę przed zamknięciem
    }
}
