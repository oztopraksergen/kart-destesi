using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var kartDestesi = new List<string>
        {
            "Kupa As", "Kupa 2", "Kupa 3", "Kupa 4", "Kupa 5", "Kupa 6", "Kupa 7", "Kupa 8",
            "Kupa 9", "Kupa 10", "Kupa Vale", "Kupa Kız", "Kupa Papaz",
            "Maça As", "Maça 2", "Maça 3", "Maça 4", "Maça 5", "Maça 6", "Maça 7", "Maça 8",
            "Maça 9", "Maça 10", "Maça Vale", "Maça Kız", "Maça Papaz",
            "Karo As", "Karo 2", "Karo 3", "Karo 4", "Karo 5", "Karo 6", "Karo 7", "Karo 8",
            "Karo 9", "Karo 10", "Karo Vale", "Karo Kız", "Karo Papaz",
            "Sinek As", "Sinek 2", "Sinek 3", "Sinek 4", "Sinek 5", "Sinek 6", "Sinek 7", "Sinek 8",
            "Sinek 9", "Sinek 10", "Sinek Vale", "Sinek Kız", "Sinek Papaz"
        };
        while (kartDestesi.Count>0)
        {
            Console.WriteLine("\nLütfen bir kart seçiniz:");
            for (int i = 0; i < kartDestesi.Count; i++)
            {
                Console.WriteLine($"{i + 1}- {kartDestesi[i]}");
            }
            Console.Write($"\nSeçiminizi yapın (1 - {kartDestesi.Count}): ");
            int secim = Convert.ToInt32(Console.ReadLine());
            if ( secim > 0 && secim <=kartDestesi.Count)
            {
                
                string secilenKart = kartDestesi[secim - 1];
                Console.WriteLine($"Seçtiğiniz kart: {secilenKart}");
                kartDestesi.RemoveAt(secim - 1);
            }
            else
            {
                Console.WriteLine("Geçersiz bir seçim yaptınız. Lütfen tekrar deneyin.");
            }
        }
        Console.WriteLine("\nSeçilecek kart kalmadı.");
        Console.ReadKey();
    }
}

