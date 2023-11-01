using System;
//exercitiu 1

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Introduceti un numar de 3 cifre: ");
        int number = Convert.ToInt32(Console.ReadLine());
        while (number < 100)
        {
            Console.WriteLine("Nr introdus nu este de 3 cifre. Introduceti din nou: ");
            number = Convert.ToInt32(Console.ReadLine());
        }

        int reversedNumber = 0;
        while (number != 0)
        {
            int lastdigit = number % 10;
            reversedNumber = reversedNumber * 10 + lastdigit;
            number /= 10;
        }

      int reversedNumSqrt = reversedNumber(Math.Sqrt) ;
        if (reversedNumSqrt * reversedNumSqrt == reversedNumber)
        {
            Console.WriteLine("Nr inversat este patrat perfect");
        }
        else
        {
            Console.WriteLine("Nr inversat nu este patrat perfect");
        }
     
           
    }
}
