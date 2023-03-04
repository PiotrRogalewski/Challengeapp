using Challengeapp;

Console.BackgroundColor = ConsoleColor.DarkCyan;
TextColoring(ConsoleColor.Black,
    "======================================================================================================================\n" +
    "                                     Witaj w Programie XYZ do oceny pracowników!                                      \n" +
    "======================================================================================================================\n");
Console.ResetColor();

// Employees list:
var employeeInMemory1 = new EmployeeInMemory("Jan", "Kowalski", "m", 33);
var employeeInMemory2 = new EmployeeInMemory("Hubert", "Wiśniewski", "m", 34);
var employeeInMemory3 = new EmployeeInMemory("Monika", "Nowak", "k", 32);

var employeeInFile1 = new EmployeeInFile($"{employeeInMemory1.Name}", $"{employeeInMemory1.Surname}", $"{employeeInMemory1.Gender}", employeeInMemory1.Age);
var employeeInFile2 = new EmployeeInFile($"{employeeInMemory2.Name}", $"{employeeInMemory2.Surname}", $"{employeeInMemory2.Gender}", employeeInMemory2.Age);
var employeeInFile3 = new EmployeeInFile($"{employeeInMemory3.Name}", $"{employeeInMemory3.Surname}", $"{employeeInMemory3.Gender}", employeeInMemory3.Age);
EmployeeInMemory employeeInMemory = null;
EmployeeInFile employeeInFile = null;

TextColoring(ConsoleColor.DarkGreen, $"       Wybierz pracownika - aby to zrobić wciśnij jedną z poniżej podanych cyfr, następnie kliknij 'ENTER':\n");
Console.WriteLine($"       1 - {employeeInMemory1.Name} {employeeInMemory1.Surname}\n" + $"       2 - {employeeInMemory2.Name} {employeeInMemory2.Surname}\n" + $"       3 - {employeeInMemory3.Name} {employeeInMemory3.Surname}\n");
var selectedEmployee = Console.ReadLine();

while (selectedEmployee != null)
{
    switch (selectedEmployee)
    {
        case "1":
            employeeInFile = employeeInFile1;
            employeeInMemory = employeeInMemory1;
            TextColoring(ConsoleColor.Green, $" Wybrano Pracownika: {employeeInMemory.Name} {employeeInMemory.Surname}, {employeeInMemory.Gender}, lat {employeeInMemory.Age}");
            break;
        case "2":
            employeeInFile = employeeInFile2;
            employeeInMemory = employeeInMemory2;
            TextColoring(ConsoleColor.Green, $" Wybrano Pracownika: {employeeInMemory.Name} {employeeInMemory.Surname}, {employeeInMemory.Gender}, lat {employeeInMemory.Age}");
            break;
        case "3":
            employeeInFile = employeeInFile3;
            employeeInMemory = employeeInMemory3;
            TextColoring(ConsoleColor.Green, $" Wybrano Pracownika: {employeeInMemory.Name} {employeeInMemory.Surname}, {employeeInMemory.Gender}, lat {employeeInMemory.Age}");
            break;
        default:
            TextColoring(ConsoleColor.Red, " Wybór nieprawidłowy, brak pracownika o takim numerze. Wybierz jednego z powyżej podanych pracownikow.");
            selectedEmployee = Console.ReadLine();
            continue;
    }

    employeeInFile.GradeAdded += EmployeeGradeAdded;
    employeeInMemory.GradeAdded += EmployeeGradeAdded;

    static void EmployeeGradeAdded(object sender, EventArgs args)
    {
        TextColoring(ConsoleColor.Green, " Dodano nową ocenę");
    }

    TextColoring(ConsoleColor.DarkGreen, "\n       Wybierz w jaki sposób chcesz dodawać oceny:\n");
    Console.WriteLine("       1) do pliku - wpisz '1'\n" + "       2) do pamięci tymczasowej programu - wpisz '2'\n" + "       W każdym przypadku potwierdź swoj wybór klikając 'ENTER'\n");

    var selectRecordingMethod = Console.ReadLine();

    while (selectRecordingMethod != null)
    {
        if (selectRecordingMethod == "1")
        {
            TextColoring(ConsoleColor.Yellow, "\n Wybrano zapis do pliku \n");
            TextColoring(ConsoleColor.DarkGreen, $" Dane pracownika: {employeeInFile.Name} {employeeInFile.Surname}, {employeeInFile.Gender}, lat {employeeInMemory.Age}\n");
            Console.WriteLine(" Aby dodać ocenę w postaci punktów wpisz wartość z zakresu od 0 do 100.");
            Console.WriteLine(" Możesz też użyć liter, aby dodać wartość według tabeli liter umieszczonej poniżej: \n\n     Tabela liter \n");
            Console.WriteLine("     'A' lub 'a' = 100        'B' lub 'b' = 90      'C' lub 'c' = 80      'D' lub 'd' = 70        'E' lub 'e' = 60");
            Console.WriteLine("     'F' lub 'f' = 50         'G' lub 'g' = 40      'H' lub 'h' = 30      'I' lub 'i' = 20        'J' lub 'j' = 10\n");
            break;
        }
        else if (selectRecordingMethod == "2")
        {
            TextColoring(ConsoleColor.Yellow, "\n Wybrano zapis do pamięci tymczasowej programu");
            TextColoring(ConsoleColor.DarkGreen, $"\n Dane pracownika: {employeeInMemory.Name} {employeeInMemory.Surname}, {employeeInMemory.Gender}, lat {employeeInMemory.Age}\n");
            Console.WriteLine(" Aby dodać ocenę w postaci punktów wpisz wartość z zakresu od 0 do 100.");
            Console.WriteLine(" Możesz też użyć liter, aby dodać wartość według tabeli liter umieszczonej poniżej: \n\n     Tabela liter \n");
            Console.WriteLine("     'A' lub 'a' = 100        'B' lub 'b' = 90      'C' lub 'c' = 80      'D' lub 'd' = 70        'E' lub 'e' = 60");
            Console.WriteLine("     'F' lub 'f' = 50         'G' lub 'g' = 40      'H' lub 'h' = 30      'I' lub 'i' = 20        'J' lub 'j' = 10\n");
            break;
        }
        else if (selectRecordingMethod != "1" && selectRecordingMethod != "2")
        {
            TextColoring(ConsoleColor.Red, " Twój wybór jest nieprawidłowy, wybierz jedną z dostępnych opcji.\n");
            TextColoring(ConsoleColor.DarkGreen, "\n       Wybierz w jaki sposób chcesz dodawać oceny:\n");
            Console.WriteLine("       1) do pliku - wpisz '1'\n" + "       2) do pamięci tymczasowej programu - wpisz '2'\n" + "       W każdym przypadku potwierdź swoj wybór klikając 'ENTER'\n");

            selectRecordingMethod = Console.ReadLine();
            continue;
        }
    }

    while (true)
    {
        TextColoring(ConsoleColor.DarkGreen, "\n Podaj kolejną ocenę i naciśnij 'ENTER' (Aby zakończyć wpisz 'q' i naciśnij 'ENTER')\n");
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
            TextColoring(ConsoleColor.Red, $" Wykryto błąd: {exc.Message}\n");
        }
    }

    if (selectRecordingMethod == "1")
    {
        var statistics = employeeInFile.GetStatistics();

        TextColoring(ConsoleColor.Yellow, $"\n                Wyniki pracownika:                  {employeeInFile.Name} {employeeInFile.Surname}\n");
        Console.WriteLine($"                Ocena końcowa pracownika* :             {statistics.AverageLetter}\n                Minimalna wartość oceny:                {statistics.Min}");
        Console.WriteLine($"                Maksymalna wartość oceny:               {statistics.Max}\n                Średnia przyznanych ocen:               {statistics.Average:N2}\n");
        TextColoring(ConsoleColor.Gray, "                * - Najwyższa możliwa do uzyskania ocena to 'A', zaś najniższa to 'E'\n\n");
        if (statistics.Average >= 0 && statistics.Max >= 0)
        {
            TextColoring(ConsoleColor.DarkYellow, $" Zapisano do pliku {employeeInFile.Name}_{employeeInFile.Surname}_grades.txt - możesz bezpiecznie wyłączyć program.\n");
        }
        else
        {
            TextColoring(ConsoleColor.Red, " Uwaga! Nieprawidłowe statystyki. Czy przynajmniej jedna ocena została poprawnie wprowadzona? Nie zapisano żadnych zmian\n");
        }
    }
    else if (selectRecordingMethod == "2")
    {
        var statistics = employeeInMemory.GetStatistics();

        TextColoring(ConsoleColor.Yellow, $"\n                Wyniki pracownika:                  {employeeInMemory.Name} {employeeInMemory.Surname}\n");
        Console.WriteLine($"                Ocena końcowa pracownika* :             {statistics.AverageLetter}\n                Minimalna wartość oceny:                {statistics.Min}");
        Console.WriteLine($"                Maksymalna wartość oceny:               {statistics.Max}\n                Średnia przyznanych ocen:               {statistics.Average:N2}\n");
        TextColoring(ConsoleColor.Gray, "                * - Najwyższa możliwa do uzyskania ocena to 'A', zaś najniższa to 'E'\n\n");
        TextColoring(ConsoleColor.DarkYellow, " Nie zapisano do pliku. Te dane zostaną utracone po zamknięciu programu.\n");
    }
    break;
}

static void TextColoring(ConsoleColor color, string text)
{
    Console.ForegroundColor = color;
    Console.WriteLine(text);
    Console.ResetColor();
}

TextColoring(ConsoleColor.DarkRed, "======================================================================================================================\n                               Aby wyjść z programu naciśnij dowolny klawisz\n======================================================================================================================");