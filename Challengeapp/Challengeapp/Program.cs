using Challengeapp;

var employee = new Employee("Jan", "Kowalski");
employee.AddGrade("46");
employee.AddGrade(65);
employee.AddGrade(71u);
employee.AddGrade(53l);
employee.AddGrade(64ul);
employee.AddGrade(42f);
employee.AddGrade(92d);
employee.AddGrade(45m);

var statistics = employee.GetStatisticsWithForEach();
Console.WriteLine("------ These are the stats that use the 'foreach' loop ------");
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine("");

var statistics1 = employee.GetStatisticsWithFor();
Console.WriteLine("------ These are the stats that use the 'for' loop ------");
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine("");

var statistics2 = employee.GetStatisticsWithDoWile();
Console.WriteLine("------ These are the stats that use the 'do while' loop ------");
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine("");

var statistics3 = employee.GetStatisticsWithWile();
Console.WriteLine("------ These are the stats that use the 'while' loop ------");
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");