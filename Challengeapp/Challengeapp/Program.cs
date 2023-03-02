using Challengeapp;

Console.BackgroundColor = ConsoleColor.DarkBlue;
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("======================================================================================================================");
Console.WriteLine("                                     Witaj w Programie XYZ do oceny pracowników!                                      ");
Console.WriteLine("======================================================================================================================\n");
Console.ResetColor();

var employeeInFile = new EmployeeInFile("Jan", "Kowalski", "m");
employeeInFile.GradeAdded += EmployeeGradeAdded;
var employeeInMemory = new EmployeeInMemory("Jan", "Kowalski", "m");
employeeInMemory.GradeAdded += EmployeeGradeAdded;

void EmployeeGradeAdded(object sender, EventArgs args)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Dodano nową ocenę");
    Console.ResetColor();
}

Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine(" Wybierz w jaki sposób chcesz dodawać oceny\n");
Console.ResetColor();
Console.WriteLine(" Jeśli chcesz zapisywać oceny:       1) do pliku - wpisz '1',       2) do pamięci tymczasowej programu - wpisz '2' ");
Console.WriteLine(" W każdym przypadku potwierdź swoj wybór klikając 'ENTER'\n");


var selectRecordingMethod = Console.ReadLine();

while (selectRecordingMethod != null)
{
    if (selectRecordingMethod == "1")
    {
        Console.WriteLine("\n Wybrano zapis do pliku \n");
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine($" Dane pracownika: {employeeInFile.Name} {employeeInFile.Surname}, {employeeInFile.Gender}\n");
        Console.ResetColor();
        Console.WriteLine(" Aby dodać ocenę w postaci punktów wpisz wartość z zakresu od 0 do 100.");
        Console.WriteLine(" Możesz też użyć liter, aby dodać wartość według tabeli liter umieszczonej poniżej: \n\n     Tabela liter \n");
        Console.WriteLine("     'A' lub 'a' = 100        'B' lub 'b' = 90      'C' lub 'c' = 80      'D' lub 'd' = 70        'E' lub 'e' = 60");
        Console.WriteLine("     'F' lub 'f' = 50         'G' lub 'g' = 40      'H' lub 'h' = 30      'I' lub 'i' = 20        'J' lub 'j' = 10\n");
        break;
    }
    else if (selectRecordingMethod == "2")
    {
        Console.WriteLine("\n Wybrano zapis do pamięci tymczasowej programu");
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine($"\n Dane pracownika: {employeeInMemory.Name} {employeeInMemory.Surname}, {employeeInMemory.Gender}\n");
        Console.ResetColor();
        Console.WriteLine(" Aby dodać ocenę w postaci punktów wpisz wartość z zakresu od 0 do 100.");
        Console.WriteLine(" Możesz też użyć liter, aby dodać wartość według tabeli liter umieszczonej poniżej: \n\n     Tabela liter \n");
        Console.WriteLine("     'A' lub 'a' = 100        'B' lub 'b' = 90      'C' lub 'c' = 80      'D' lub 'd' = 70        'E' lub 'e' = 60");
        Console.WriteLine("     'F' lub 'f' = 50         'G' lub 'g' = 40      'H' lub 'h' = 30      'I' lub 'i' = 20        'J' lub 'j' = 10\n");
        break;
    }
    else if (selectRecordingMethod != "1" && selectRecordingMethod != "2")
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Twój wybór jest nieprawidłowy\n");
        Console.ResetColor();
        Console.WriteLine(" Wybierz jedną z dostępnych opcji:\n Jeśli chcesz zapisywać oceny:       1) do pliku - wpisz '1',       2) do pamięci tymczasowej programu - wpisz '2' ");
        Console.WriteLine(" W każdym przypadku potwierdź swoj wybór klikając 'ENTER'\n");

        selectRecordingMethod = Console.ReadLine();
        continue;
    }
}

while (true)
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine("\n Podaj kolejną ocenę i naciśnij 'ENTER' (Aby zakończyć wpisz 'q' i naciśnij 'ENTER')\n");
    Console.ResetColor();

    var input = Console.ReadLine();

    if (input == "q")
    {
        break;
    }
    try
    {
        if (selectRecordingMethod == "1")
        {
            employeeInFile.AddGrade(input);
        }
        else if (selectRecordingMethod == "2")
        {
            employeeInMemory.AddGrade(input);
        }
    }
    catch (Exception exc)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"Wykryto błąd: {exc.Message}\n");
        Console.ResetColor();
    }
}

if (selectRecordingMethod == "1")
{
    var statistics = employeeInFile.GetStatistics();

    Console.WriteLine($"\n                Wyniki pracownika: \n");
    Console.WriteLine($"                Ocena końcowa pracownika* :             {statistics.AverageLetter}\n                Minimalna wartość oceny:                {statistics.Min}");
    Console.WriteLine($"                Maksymalna wartość oceny:               {statistics.Max}\n                Średnia przyznanych ocen:               {statistics.Average:N2}\n");
}
else if (selectRecordingMethod == "2")
{
    var statistics = employeeInMemory.GetStatistics();

    Console.WriteLine($"\n                Wyniki pracownika: \n");
    Console.WriteLine($"                Ocena końcowa pracownika* :             {statistics.AverageLetter}\n                Minimalna wartość oceny:                {statistics.Min}");
    Console.WriteLine($"                Maksymalna wartość oceny:               {statistics.Max}\n                Średnia przyznanych ocen:               {statistics.Average:N2}\n");
}

Console.WriteLine("                * - Najwyższa możliwa do uzyskania ocena to 'A', zaś najniższa to 'E'\n\n");