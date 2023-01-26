int number = 6373;

string numberAsString = number.ToString();
char[] digits = numberAsString.ToArray();

int counter0 = 0;
int counter1 = 0;
int counter2 = 0;
int counter3 = 0;
int counter4 = 0;
int counter5 = 0;
int counter6 = 0;
int counter7 = 0;
int counter8 = 0;
int counter9 = 0;

Console.WriteLine(numberAsString);

foreach (char digit in digits)
{
    if (digit == '0')
    {
        counter0++;
    }
    else if (digit == '1')
    {
        counter1++;
    }
    if (digit == '2')
    {
        counter2++;
    }
    else if (digit == '3')
    {
        counter3++;
    }
    if (digit == '4')
    {
        counter4++;
    }
    else if (digit == '5')
    {
        counter5++;
    }
    if (digit == '6')
    {
        counter6++;
    }
    else if (digit == '7')
    {
        counter7++;
    }
    if (digit == '8')
    {
        counter8++;
    }
    else if (digit == '9')
    {
        counter9++;
    }
}

List<int> scoringDigits = new List<int>();
scoringDigits.Add(1);

foreach (int scoringDigit in scoringDigits)
{
    if (counter0 == 0)
    {
        Console.WriteLine("0 => 0");
    }
    else if (counter0 == 1)
    {
        Console.WriteLine("0 => 1");
    }
    if (counter0 == 2)
    {
        Console.WriteLine("0 => 2");
    }
    else if (counter0 == 3)
    {
        Console.WriteLine("0 => 3");
    }
    if (counter0 == 4)
    {
        Console.WriteLine("0 => 4");
    }
    if (counter1 == 0)
    {
        Console.WriteLine("1 => 0");
    }
    else if (counter1 == 1)
    {
        Console.WriteLine("1 => 1");
    }
    if (counter1 == 2)
    {
        Console.WriteLine("1 => 2");
    }
    else if (counter1 == 3)
    {
        Console.WriteLine("1 => 3");
    }
    if (counter1 == 4)
    {
        Console.WriteLine("1 => 4");
    }
    if (counter2 == 0)
    {
        Console.WriteLine("2 => 0");
    }
    else if (counter2 == 1)
    {
        Console.WriteLine("2 => 1");
    }
    if (counter2 == 2)
    {
        Console.WriteLine("2 => 2");
    }
    else if (counter2 == 3)
    {
        Console.WriteLine("2 => 3");
    }
    if (counter2 == 4)
    {
        Console.WriteLine("2 => 4");
    }
    if (counter3 == 0)
    {
        Console.WriteLine("3 => 0");
    }
    else if (counter3 == 1)
    {
        Console.WriteLine("3 => 1");
    }
    if (counter3 == 2)
    {
        Console.WriteLine("3 => 2");
    }
    else if (counter3 == 3)
    {
        Console.WriteLine("3 => 3");
    }
    if (counter3 == 4)
    {
        Console.WriteLine("3 => 4");
    }
    if (counter4 == 0)
    {
        Console.WriteLine("4 => 0");
    }
    else if (counter4 == 1)
    {
        Console.WriteLine("4 => 1");
    }
    if (counter4 == 2)
    {
        Console.WriteLine("4 => 2");
    }
    else if (counter4 == 3)
    {
        Console.WriteLine("4 => 3");
    }
    if (counter4 == 4)
    {
        Console.WriteLine("4 => 4");
    }
    if (counter5 == 0)
    {
        Console.WriteLine("5 => 0");
    }
    else if (counter5 == 1)
    {
        Console.WriteLine("5 => 1");
    }
    if (counter5 == 2)
    {
        Console.WriteLine("5 => 2");
    }
    else if (counter5 == 3)
    {
        Console.WriteLine("5 => 3");
    }
    if (counter5 == 4)
    {
        Console.WriteLine("5 => 4");
    }
    if (counter6 == 0)
    {
        Console.WriteLine("6 => 0");
    }
    else if (counter6 == 1)
    {
        Console.WriteLine("6 => 1");
    }
    if (counter6 == 2)
    {
        Console.WriteLine("6 => 2");
    }
    else if (counter6 == 3)
    {
        Console.WriteLine("6 => 3");
    }
    if (counter6 == 4)
    {
        Console.WriteLine("6 => 4");
    }
    if (counter7 == 0)
    {
        Console.WriteLine("7 => 0");
    }
    else if (counter7 == 1)
    {
        Console.WriteLine("7 => 1");
    }
    if (counter7 == 2)
    {
        Console.WriteLine("7 => 2");
    }
    else if (counter7 == 3)
    {
        Console.WriteLine("7 => 3");
    }
    if (counter7 == 4)
    {
        Console.WriteLine("7 => 4");
    }
    if (counter8 == 0)
    {
        Console.WriteLine("8 => 0");
    }
    else if (counter8 == 1)
    {
        Console.WriteLine("8 => 1");
    }
    if (counter8 == 2)
    {
        Console.WriteLine("8 => 2");
    }
    else if (counter8 == 3)
    {
        Console.WriteLine("8 => 3");
    }
    if (counter8 == 4)
    {
        Console.WriteLine("8 => 4");
    }
    if (counter9 == 0)
    {
        Console.WriteLine("9 => 0");
    }
    else if (counter9 == 1)
    {
        Console.WriteLine("9 => 1");
    }
    if (counter9 == 2)
    {
        Console.WriteLine("9 => 2");
    }
    else if (counter9 == 3)
    {
        Console.WriteLine("9 => 3");
    }
    if (counter9 == 4)
    {
        Console.WriteLine("9 => 4");
    }
}
