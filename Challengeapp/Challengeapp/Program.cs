using Challengeapp;

Console.WriteLine("=====================================================================================================================");
Console.WriteLine("                                     Witaj w Programie XYZ do oceny pracowników!                                     ");
Console.WriteLine("=====================================================================================================================");
Console.WriteLine();
Console.WriteLine("                 Aby dodać pojedyńczą ocenę punktową wpisz wartość z zakresu od 0 do 100, włącznie.");
Console.WriteLine("                 Możesz też użyć liter, aby dodać wartość wg poniższej --> Tabeli liter : ");
Console.WriteLine();
Console.WriteLine("     'A' lub 'a' = 100        'B' lub 'b' = 90      'C' lub 'c' = 80      'D' lub 'd' = 70        'E' lub 'e' = 60");
Console.WriteLine("     'F' lub 'f' = 50         'G' lub 'g' = 40      'H' lub 'h' = 30      'I' lub 'i' = 20        'J' lub 'j' = 10");
Console.WriteLine();

var employee = new Employee();

while (true)
{
    Console.WriteLine();
    Console.WriteLine("     Podaj kolejną ocenę pracownika i naciśnij 'ENTER' (Aby zakończyć wpisz 'q' i naciśnij 'ENTER') :");
    var input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }
    employee.AddGrade(input);
}

var statistics = employee.GetStatistics();
Console.WriteLine();
Console.WriteLine($"                Wyniki pracownika: ");
Console.WriteLine();
Console.WriteLine($"                Ocena końcowa pracownika* :             {statistics.AverageLetter}");
Console.WriteLine(" ");
Console.WriteLine($"                Minimalna wartość oceny:                {statistics.Min}");
Console.WriteLine($"                Maksymalna wartość oceny:               {statistics.Max}");
Console.WriteLine($"                Średnia przyznanych ocen:               {statistics.Average:N2}");

Console.WriteLine();
Console.WriteLine("                 * - Najwyższa ocena możliwa do uzyskania to 'A', zaś najniższa to 'E'.");
Console.WriteLine();
Console.WriteLine();