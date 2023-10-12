using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Introdu primul nume: ");
        string firstName = Console.ReadLine();

        Console.Write("Introdu al doilea nume: ");
        string secondName = Console.ReadLine();

        Console.Write("Introdu al treilea nume: ");
        string thirdName = Console.ReadLine();

        Console.WriteLine("Caracterele și numărul de apariții în fiecare nume:");

        // Afișarea caracterelor și numărul de apariții în fiecare nume
        DisplayCharacterCounts(firstName, secondName, thirdName);
    }

    static void DisplayCharacterCounts(string name1, string name2, string name3)
    {
        // Dicționar pentru a ține evidența caracterelor și a numărului de apariții
        Dictionary<char, int> charCounts = new Dictionary<char, int>();

        // Parcurgerea fiecărui caracter în toate cele 3 nume
        foreach (char ch in name1 + name2 + name3)
        {
            // Ignorarea caracterelor care nu sunt litere
            if (!char.IsLetter(ch))
                continue;

            // Convertirea caracterelor la litera mică pentru a fi înregistrate corect
            char lowercaseChar = char.ToLower(ch);

            if (charCounts.ContainsKey(lowercaseChar))
            {
                // Caracterul există deja în dicționar, incrementăm numărul de apariții
                charCounts[lowercaseChar]++;
            }
            else
            {
                // Caracterul nu există, adăugăm în dicționar cu 1 apariție
                charCounts[lowercaseChar] = 1;
            }
        }

        // Afișarea caracterelor și numărul de apariții
        foreach (var entry in charCounts)
        {
            char uppercaseChar = char.ToUpper(entry.Key);
            Console.WriteLine($"Caracterul '{entry.Key}' (sau '{uppercaseChar}') apare de {entry.Value} ori în fiecare nume.");
        }
    }
}
