using System;
//Exercitiu 2
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Introdu o listă de numere: ");
        string input = Console.ReadLine();
        string[] numbersAsString = input.Split(' ');

        double[] numbers = new double[numbersAsString.Length];

        // Conversia și salvarea numerelor în array
        for (int i = 0; i < numbersAsString.Length; i++)
        {
            if (double.TryParse(numbersAsString[i], out double num))
            {
                numbers[i] = num;
            }
            else
            {
                Console.WriteLine($"Elementul '{numbersAsString[i]}' este număr nevalid.");
            }
        }

        Console.WriteLine("Numere ce nu sunt întregi:");

        // Afișarea numerelor care nu sunt întregi
        foreach (var num in numbers)
        {
            if (!IsInteger(num))
            {
                Console.WriteLine(num);
            }
        }

        // Cautarea și afișarea celui mai mic număr
        double smallestNumber = FindSmallestNumber(numbers);
        Console.WriteLine($"Cel mai mic număr este: {smallestNumber}");
    }

    static bool IsInteger(double num)
    {
        return num == Math.Floor(num);
    }

    static double FindSmallestNumber(double[] numbers)
    {
        double smallest = double.MaxValue;

        foreach (var num in numbers)
        {
            if (num < smallest)
            {
                smallest = num;
            }
        }

        return smallest;
    }
}
