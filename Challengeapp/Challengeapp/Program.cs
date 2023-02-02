using Challengeapp;

var boardTitle = Employee.NameOfScoreboard;

Console.WriteLine(boardTitle);
Console.WriteLine(" ");
Console.WriteLine("     Points:      Employee details: ");
Console.WriteLine(" ");

Employee employee1 = new Employee("Jan", "Kowalski", "34");
Employee employee2 = new Employee("Anna", "Nowak", "31");
Employee employee3 = new Employee("Leon", "Wiśniewski", "38");
//employee1 score:
employee1.AddScore(5);
employee1.AddScore(8);
employee1.AddScore(7);
employee1.SubstractScore(2);
employee1.AddScore(9);
//employee2 score:
employee2.SubstractScore(1);
employee2.AddScore(7);
employee2.AddScore(6);
employee2.AddScore(9);
employee2.AddScore(7);
//employee3 score: 
employee3.AddScore(6);
employee3.AddScore(8);
employee3.SubstractScore(2);
employee3.AddScore(8);
employee3.AddScore(9);

int result1 = employee1.Result;
int result2 = employee2.Result;
int result3 = employee3.Result;
var person1 = employee1.Name + employee1.Surname + employee1.Age;
var person2 = employee2.Name + employee2.Surname + employee2.Age;
var person3 = employee3.Name + employee3.Surname + employee3.Age;
bool draw1and2 = !true;
bool draw1and3 = !true;
bool draw2and3 = !true;
bool drawAll = !true;
Employee employeeWithMaxResult = null;

Console.WriteLine("       " + result1 + "    -->  " + person1);
Console.WriteLine("       " + result2 + "    -->  " + person2);
Console.WriteLine("       " + result3 + "    -->  " + person3);
Console.WriteLine(" ");

for (var checkIt = 1; checkIt < 2; checkIt++)
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
        if (draw1and2 = true)
        {
            Console.WriteLine(" Employees of the week are: " + person1 + " and " + person2 + ", with the same number of points.");
        }
    }
    else if (employee1.Result == employee3.Result && employee1.Result > employee2.Result)
    {
        draw1and3 = true;
        if (draw1and3 = true)
        {
            Console.WriteLine(" Employees of the week are: " + person1 + " and " + person3 + ", with the same number of points.");
        }
    }
    else if (employee2.Result == employee3.Result && employee1.Result < employee2.Result)
    {
        draw2and3 = true;
        if (draw2and3 = true)
        {
            Console.WriteLine("Employees of the week are: " + person2 + " and " + person3 + ", with the same number of points.");
        }
    }
    else if (employee1.Result == employee2.Result && employee1.Result == employee3.Result && employee2.Result == employee3.Result)
    {
        drawAll = true;
        if (drawAll = true)
        {
            Console.WriteLine("Employees of the week are: " + person1 + " and " + person2 + " and " + person3 + ", with the same number of points.");
        }
    }
    if (employeeWithMaxResult == employee1 || employeeWithMaxResult == employee2 || employeeWithMaxResult == employee3)
    {
        Console.WriteLine(" Employee of the week is: " + employeeWithMaxResult.Name + employeeWithMaxResult.Surname + employeeWithMaxResult.Age + ", this person achieved the highest score with the number of points: " + employeeWithMaxResult.Result + ".");
    }
}