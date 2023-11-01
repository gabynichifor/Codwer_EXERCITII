// 3. Afisarea numerelor care nu sunt întregi
        Console.WriteLine("Numerele care nu sunt întregi sunt:");
        for (int i = 0; i < numbersDouble.Length; i++)
        {
            if (numbersDouble[i] != numbersInt[i])
            {
                Console.WriteLine(numbersDouble[i]);
            }
        }

        // 4. Găsirea și afișarea celui mai mic număr fara a folosi funcții din .NET
        Console.WriteLine("Cel mai mic număr fara a folosi funcții din .NET este:");
        double minNumber = numbersDouble[0];
        for (int i = 1; i < numbersDouble.Length; i++)
        {
            if (numbersDouble[i] < minNumber)
            {
                minNumber = numbersDouble[i];
            }
        }
        Console.WriteLine(minNumber);
    }
}
