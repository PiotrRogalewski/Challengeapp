Console.Write("Wpisz liczbę i naciśnij ENTER: ");
string chooseYourNumber = Console.ReadLine();
char[] digits = chooseYourNumber.ToCharArray();

for (int n = 0; n < 10; n++)
{
    int count = 0;
    foreach (char digit in digits)
    {
        if (n == char.GetNumericValue(digit))
        {
            count++;
        }
    }
    Console.WriteLine(n + " => " + count);
}