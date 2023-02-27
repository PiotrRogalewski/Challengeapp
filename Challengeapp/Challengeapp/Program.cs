using Challengeapp;

Console.WriteLine("======================================================================================================================");
Console.WriteLine("                                     Witaj w Programie XYZ do oceny pracowników!                                     ");
Console.WriteLine("======================================================================================================================\n");

var employee = new EmployeeInFile("Jan", "Kowalski", "m");

Console.WriteLine($" Pracownik: {employee.Name} {employee.Surname}, {employee.Gender}:\n");
Console.WriteLine(" Aby dodać ocenę w postaci punktów wpisz wartość z zakresu od 0 do 100, włącznie.");
Console.WriteLine(" Możesz też użyć liter, aby dodać wartość wg poniższej --> Tabeli liter : \n");
Console.WriteLine("     'A' lub 'a' = 100        'B' lub 'b' = 90      'C' lub 'c' = 80      'D' lub 'd' = 70        'E' lub 'e' = 60");
Console.WriteLine("     'F' lub 'f' = 50         'G' lub 'g' = 40      'H' lub 'h' = 30      'I' lub 'i' = 20        'J' lub 'j' = 10\n");

while (true)
{
    Console.WriteLine("     Podaj kolejną ocenę i naciśnij 'ENTER' (Aby zakończyć wpisz 'q' i naciśnij 'ENTER') :\n");
    var input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }
    try
    {
        employee.AddGrade(input);
    }
    catch (Exception exc)
    {
        Console.WriteLine($" Wykryto błąd: {exc.Message}");
    }
}
var statistics = employee.GetStatistics();

Console.WriteLine();
Console.WriteLine($"                Wyniki pracownika: \n");
Console.WriteLine($"                Ocena końcowa pracownika* :             {statistics.AverageLetter}\n");
Console.WriteLine($"                Minimalna wartość oceny:                {statistics.Min}");
Console.WriteLine($"                Maksymalna wartość oceny:               {statistics.Max}");
Console.WriteLine($"                Średnia przyznanych ocen:               {statistics.Average:N2}\n");
Console.WriteLine("                 * - Najwyższa możliwa do uzyskania ocena to 'A', zaś najniższa to 'E'.\n\n");