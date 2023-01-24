var name = "Piotr";
var age = 34;
bool isActive = true;
if (name != "Piotr")
{
    isActive = false;
}
Console.WriteLine("CZY NAZYWASZ SIĘ PIOTR? I CZY MASZ PONIŻEJ 40 LAT?");
if (age < 40)

{
    if (isActive == true)
    {
        Console.WriteLine("- Tak. Jestem Piotr, mam poniżej 40 lat.");
    }
    else
    {

        Console.WriteLine("- Jestem kimś innym, ale mam poniżej 40 lat.");
    }
}
else if (age < 50)
{
    Console.WriteLine("- Mam pomiędzy 40, a 50 lat!");
    if (isActive == true)
    {
        Console.WriteLine("I nazywam się Piotr.");
    }
    else
    {
        Console.WriteLine("Jestem kimś innym.");
    }
}
else
{
    Console.WriteLine("- Jestem starszy...");
    if (isActive == true)
    {
        Console.WriteLine("...Ale nazywam się Piotr.");
    }
    else 
    {
        Console.WriteLine("...i nie nazywam się Piotr.");
    }
}

