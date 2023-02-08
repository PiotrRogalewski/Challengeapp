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

var statistics1 = employee.GetStatisticsWithForEach();
Console.WriteLine("------ These are the stats that use the 'foreach' loop ------");
Console.WriteLine($"Average: {statistics1.Average:N2}");
Console.WriteLine($"Min: {statistics1.Min}");
Console.WriteLine($"Max: {statistics1.Max}");
Console.WriteLine("");

var statistics2 = employee.GetStatisticsWithFor();
Console.WriteLine("------ These are the stats that use the 'for' loop ------");
Console.WriteLine($"Average: {statistics2.Average:N2}");
Console.WriteLine($"Min: {statistics2.Min}");
Console.WriteLine($"Max: {statistics2.Max}");
Console.WriteLine("");

var statistics3 = employee.GetStatisticsWithDoWile();
Console.WriteLine("------ These are the stats that use the 'do while' loop ------");
Console.WriteLine($"Average: {statistics3.Average:N2}");
Console.WriteLine($"Min: {statistics3.Min}");
Console.WriteLine($"Max: {statistics3.Max}");
Console.WriteLine("");

var statistics4 = employee.GetStatisticsWithWile();
Console.WriteLine("------ These are the stats that use the 'while' loop ------");
Console.WriteLine($"Average: {statistics4.Average:N2}");
Console.WriteLine($"Min: {statistics4.Min}");
Console.WriteLine($"Max: {statistics4.Max}");