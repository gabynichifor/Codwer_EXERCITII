using System;
//exercitiu 1
class Program
{
    static void Main(string[] args)
    {
        int number;

        do
        {
            Console.Write("Introdu un nr de min. 3 cifre: ");
            string userInput = Console.ReadLine();

            if (int.TryParse(userInput, out number) && userInput.Length >= 3)
            {
                // Va calcula oglinda numărului
                int reversedNumber = ReverseNumber(number);

                Console.WriteLine($"Oglinda numărului este: {reversedNumber}");

                // Verifică dacă oglinda este pătrat perfect
                if (IsPerfectSquare(reversedNumber))
                {
                    Console.WriteLine("Oglinda numărului este pătrat perfect.");
                }
                else
                {
                    Console.WriteLine("Oglinda numărului nu este pătrat perfect.");
                }

                break;
            }
            else
            {
                Console.WriteLine("Numărul introdus nu are 3 cifre. Introdu alt număr.");
            }
        } while (true);
    }

    static int ReverseNumber(int num)
    {
        int reversedNum = 0;
        while (num > 0)
        {
            int digit = num % 10;
            reversedNum = reversedNum * 10 + digit;
            num /= 10;
        }
        return reversedNum;
    }

    static bool IsPerfectSquare(int num)
    {
        int sqrt = (int)Math.Sqrt(num);
        return sqrt * sqrt == num;
    }
}

