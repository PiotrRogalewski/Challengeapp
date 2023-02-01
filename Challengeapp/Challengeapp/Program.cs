using Challengeapp;
using System.Data;
using System.Diagnostics.Tracing;

var boardTitle = Employee.NameOfScoreboard;

Console.WriteLine(boardTitle);
Console.WriteLine(" ");
Console.WriteLine("     Points:      Employee details: ");
Console.WriteLine(" ");

Employee employee1 = new Employee("Jan", "Kowalski", "34");
Employee employee2 = new Employee("Anna", "Nowak", "31");
Employee employee3 = new Employee("Leon", "Wiśniewski", "38");

bool draw1and2 = !true;
bool draw1and3 = !true;
bool draw2and3 = !true;
bool drawAll = !true;

employee1.AddScore(4);
employee1.AddScore(8);
employee1.AddScore(9);
employee1.SubstractScore(2);
employee1.AddScore(9);

employee2.SubstractScore(1);
employee2.AddScore(8);
employee2.AddScore(6);
employee2.AddScore(9);
employee2.AddScore(7);

employee3.AddScore(5);
employee3.AddScore(7);
employee3.SubstractScore(2);
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
        if (employee1.Result > employee2.Result && employee1.Result > employee3.Result)
        {
            employeeWithMaxResult = employee1;
        }
        else if (employee2.Result > employee1.Result && employee2.Result > employee3.Result)
        {
            employeeWithMaxResult = employee2;
        }
        else if (employee3.Result > employee1.Result && employee3.Result > employee2.Result)
        {
            employeeWithMaxResult = employee3;
        }
        else if (employee1.Result == employee2.Result && employee1.Result > employee3.Result)
        {
            draw1and2 = true;
        }
        else if (employee1.Result == employee3.Result && employee1.Result > employee2.Result)
        {
            draw1and3 = true;
        }
        else if (employee2.Result == employee3.Result && employee1.Result < employee2.Result)
        {
            draw2and3 = true;
        }
        else if (employee1.Result == employee2.Result && employee1.Result == employee3.Result && employee2.Result == employee3.Result)
        {
            drawAll = true;
        }
    }
}

Console.WriteLine("       " + result1 + "    -->  " + person1);
Console.WriteLine("       " + result2 + "    -->  " + person2);
Console.WriteLine("       " + result3 + "    -->  " + person3);
Console.WriteLine(" ");

if (employeeWithMaxResult == employee1 || employeeWithMaxResult == employee2 || employeeWithMaxResult == employee3)
{
    Console.WriteLine(" Employee of the week is: " + employeeWithMaxResult.Name + employeeWithMaxResult.Surname + employeeWithMaxResult.Age + ", this person achieved the highest score with the number of points: " + employeeWithMaxResult.Result + ".");
}
else if (drawAll = true)
{
    Console.WriteLine("Employees of the week are: " + person1 + " and " + person2 + " and " + person3 + ", with the same number of points.");
}
else if (draw1and2 = true)
{
    Console.WriteLine(" Employees of the week are: " + person1 + " and " + person2 + ", with the same number of points.");
}
else if (draw1and3 = true)
{
    Console.WriteLine(" Employees of the week are: " + person1 + " and " + person3 + ", with the same number of points.");
}
else if (draw2and3 = true)
{
    Console.WriteLine("Employees of the week are: " + person2 + " and " + person3 + ", with the same number of points.");
}