using Challengeapp;

Console.WriteLine("======================================================================================================================");
Console.WriteLine("                                     Witaj w Programie XYZ do oceny pracowników!                                     ");
Console.WriteLine("======================================================================================================================\n");

var employee = new Employee("Jan", "Kowalski", "m");
var supervisor = new Supervisor("Kinga", "Nowak", "woman");

Console.WriteLine(" Wybierz której osobie chcesz dodać punkty: ");
Console.WriteLine(" Jeśli chcesz dodać punkty -> kierownikowi <- wpisz '1', a jeśli chcesz dodać punkty -> pracownikowi <- wpisz '2'");
Console.WriteLine(" W każdym przypadku potwierdź swoj wybór klikając 'ENTER'\n");
var selectAnEmployee = Console.ReadLine();

while (selectAnEmployee != null)
{
    if (selectAnEmployee == "1")
    {
        Console.WriteLine($" Wybrałeś Kierownika: {supervisor.Name} {supervisor.Surname}, {supervisor.Gender}\n");
        Console.WriteLine(" Aby dodać ocenę w postaci punktów wpisz wartość z zakresu od 0 do 100, włącznie. ");
        Console.WriteLine(" W przypadku, gdy chcesz przyznać tylko od 1 do 6 punktów, wpisz je z przecinkiem i 0 po nim, np. 4,0.");
        Console.WriteLine(" Pozostałe liczby nie muszą mieć przecinka. Możesz też przyznać ocenę: ");
        Console.WriteLine(" '6' to(=) 100 punktów(pkt), '5' = 80 pkt, '4' = 60 pkt, '3' = 40 pkt, '2' = 20 pkt, a '1' = 0 pkt.");
        Console.WriteLine(" Dodatkowo jeśli z przodu lub z tyłu oceny znajdzie się znak '+' to dodaje on 5 do liczby punktów np. '4+' = 65 pkt.");
        Console.WriteLine(" Analogicznie jeśli z przodu lub z tyłu oceny znajdzie się znak '-' odejmie on 5 pkt od oceny np. '-3' = 35 pkt.");
        Console.WriteLine(" Zamiast cyfr jako ocen możesz również wpisać ocenę słownie po polsku np. dla 5- :                                       'pięć minus' lub po angielsku 'five minus', inny przykład: 4 to 'cztery' lub 'four' itd.\n");
        Console.WriteLine(" Możesz też użyć liter, aby dodać wartość wg poniższej --> Tabeli liter : \n");
        Console.WriteLine("     'A' lub 'a' = 100        'B' lub 'b' = 90      'C' lub 'c' = 80      'D' lub 'd' = 70        'E' lub 'e' = 60");
        Console.WriteLine("     'F' lub 'f' = 50         'G' lub 'g' = 40      'H' lub 'h' = 30      'I' lub 'i' = 20        'J' lub 'j' = 10\n");
        break;
    }
    else if (selectAnEmployee == "2")
    {
        Console.WriteLine($" Wybrałeś Pracownika: {employee.Name} {employee.Surname}, {employee.Gender}:\n");
        Console.WriteLine(" Aby dodać ocenę w postaci punktów wpisz wartość z zakresu od 0 do 100, włącznie.");
        Console.WriteLine(" Możesz też użyć liter, aby dodać wartość wg poniższej --> Tabeli liter : \n");
        Console.WriteLine("     'A' lub 'a' = 100        'B' lub 'b' = 90      'C' lub 'c' = 80      'D' lub 'd' = 70        'E' lub 'e' = 60");
        Console.WriteLine("     'F' lub 'f' = 50         'G' lub 'g' = 40      'H' lub 'h' = 30      'I' lub 'i' = 20        'J' lub 'j' = 10\n");
        break;
    }
    else if (selectAnEmployee != "1" && selectAnEmployee != "2")
    {
        Console.WriteLine(" Twój wybór jest nieprawidłowy. Spróbuj ponownie.\n");
        Console.WriteLine(" Wybierz której osobie chcesz dodać punkty: ");
        Console.WriteLine(" Jeśli chcesz dodać punkty -> kierownikowi <- wpisz '1', a jeśli chcesz dodać punkty -> pracownikowi <- wpisz '2'");
        Console.WriteLine(" W każdym przypadku potwierdź swoj wybór klikając 'ENTER'.\n");
        selectAnEmployee = Console.ReadLine();
        continue;
    }
}

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
        if (selectAnEmployee == "2")
        {
            employee.AddGrade(input);
        }
        else if (selectAnEmployee == "1")
        {
            supervisor.AddGrade(input);
        }
    }
    catch (Exception exc)
    {
        Console.WriteLine($" Wykryto błąd: {exc.Message}");
    }
}
Console.WriteLine();

if (selectAnEmployee == "2")
{
    var statistics = employee.GetStatistics();

    Console.WriteLine($"                Wyniki pracownika: \n");
    Console.WriteLine($"                Ocena końcowa pracownika* :             {statistics.AverageLetter}\n");
    Console.WriteLine($"                Minimalna wartość oceny:                {statistics.Min}");
    Console.WriteLine($"                Maksymalna wartość oceny:               {statistics.Max}");
    Console.WriteLine($"                Średnia przyznanych ocen:               {statistics.Average:N2}\n");
}
else if (selectAnEmployee == "1")
{
    var statistics = supervisor.GetStatistics();

    Console.WriteLine($"                Wyniki kierownika: \n");
    Console.WriteLine($"                Ocena końcowa kierownika* :             {statistics.AverageLetter}\n");
    Console.WriteLine($"                Minimalna wartość oceny:                {statistics.Min}");
    Console.WriteLine($"                Maksymalna wartość oceny:               {statistics.Max}");
    Console.WriteLine($"                Średnia przyznanych ocen:               {statistics.Average:N2}\n");
}
Console.WriteLine("                 * - Najwyższa możliwa do uzyskania ocena to 'A', zaś najniższa to 'E'.\n\n");