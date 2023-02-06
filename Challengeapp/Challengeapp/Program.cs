using Challengeapp;

var employee = new Employee("Jan", "Kowalski");
employee.AddGrade("46");
employee.AddGrade(65);
employee.AddGrade(71u);
employee.AddGrade(53l);
employee.AddGrade(64ul);
employee.AddGrade(42f);
employee.AddGrade(92d);
employee.AddGrade(85m);
var statistics = employee.GetStatistics();

Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");