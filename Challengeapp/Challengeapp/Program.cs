using Challengeapp;

var boardTitle = Employee.NameOfScoreboard;

Console.WriteLine(boardTitle);
Console.WriteLine(" ");
Console.WriteLine("     Points:      Employee details: ");
Console.WriteLine(" ");

Employee employee1 = new Employee("Jan", "Kowalski", "34");
Employee employee2 = new Employee("Anna", "Nowak", "31");
Employee employee3 = new Employee("Leon", "Wiśniewski", "38");

employee1.AddScore(4);
employee1.AddScore(8);
employee1.AddScore(7);
employee1.AddScore(5);
employee1.AddScore(8);

employee2.AddScore(5);
employee2.AddScore(6);
employee2.AddScore(5);
employee2.AddScore(9);
employee2.AddScore(7);

employee3.AddScore(3);
employee3.AddScore(5);
employee3.AddScore(9);
employee3.AddScore(8);
employee3.AddScore(9);

int result1 = employee1.Result;
int result2 = employee2.Result;
int result3 = employee3.Result;

var person1 = employee1.Name + employee1.Surname + employee1.Age;
var person2 = employee2.Name + employee2.Surname + employee2.Age;
var person3 = employee3.Name + employee3.Surname + employee3.Age;

List<Employee> employeeList = new List<Employee>()
{
    employee1, employee2, employee3
};

int maxResult = -1;
Employee employeeWithMaxResult = null;

foreach (var employee in employeeList)
{
    if (employee.Result > maxResult)
    {
        employeeWithMaxResult = employee;
    }
}

Console.WriteLine("       " + result1 + "    -->  " + person1);
Console.WriteLine("       " + result2 + "    -->  " + person2);
Console.WriteLine("       " + result3 + "    -->  " + person3);
Console.WriteLine(" ");
Console.WriteLine(" Employee of the week is: " + employeeWithMaxResult.Name + employeeWithMaxResult.Surname + employeeWithMaxResult.Age + ", this person achieved the highest score with the number of points: " + employeeWithMaxResult.Result + ".");