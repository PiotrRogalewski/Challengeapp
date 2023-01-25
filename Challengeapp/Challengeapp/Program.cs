//ZADANIE DOMOWE z dnia 4

// zmienne z danymi:
var name = "Piotr";
int age = 34;
bool man = true;

// Jeden z komunikatów:

// (1) Kobieta poniżej 30 lat.
// (2) Ewa, lat 33.
// (3) Niepełnoletni Mężczyzna.
// *(4) Piotr, powyżej 30 lat.
// *(5) Kinga, nie mniej niż 30 lat.
// *(6) Franek, pomiędzy 40 a 50 lat.

// Jeśli imię jest inne niż: Ewa, Piotr, Franek, Kinga wówczas dochodzą dwa nowe komunikaty oprócz już istniejących:
// *(7) Pełnoletni Mężczyzna.
// *(8) Kobieta, 30 lat lub więcej.


// sprawdzam czy:
// Płeć:    Mężczyzna czy Kobieta
// Wiek:    jeśli mężczyzna: <18, >30, >=40 i <=50, >=18
//          jeśli kobieta: <30, ==33, >=30
// Imię:    Ewa, Piotr, Franek, Kinga

if (man == true)
{
    if (name == "Piotr")
    {
        if (age < 18)
        {
            Console.WriteLine("Niepełnoletni Mężczyzna.");
        }
        else if (age > 30)
        {
            Console.WriteLine("Piotr, powyżej 30 lat.");
        }
    }
    else if (name == "Franek")
    {
        if (age < 18)
        {
            Console.WriteLine("Niepełnoletni Mężczyzna.");
        }
        else if (age >= 40 && age <= 50)
        {
            Console.WriteLine("Franek, pomiędzy 40 a 50 lat.");
        }
    }
    if (name != "Piotr" && name != "Franek")
    {
        if (age < 18)
        {
            Console.WriteLine("Niepełnoletni Mężczyzna.");
        }
        else if (age >= 18)
        {
            Console.WriteLine("Pełnoletni Mężczyzna");
        }
    }
}
else if (man == false)
{
    if (name == "Ewa")
    {
        if (age < 30)
        {
            Console.WriteLine("Kobieta poniżej 30 lat.");
        }
        else if (age == 33)
        {
            Console.WriteLine("Ewa, lat 33.");
        }
    }
    else if (name == "Kinga")
    {
        if (age < 30)
        {
            Console.WriteLine("Kobieta poniżej 30 lat.");
        }
        else if (age >= 30)
        {
            Console.WriteLine("Kinga, nie mniej niż 30 lat.");
        }
    }
    if (name != "Ewa" && name != "Kinga")
    {
        if (age < 30)
        {
            Console.WriteLine("Kobieta poniżej 30 lat.");
        }
        else if (age >= 30)
        {
            Console.WriteLine("Kobieta, 30 lat lub więcej.");
        }
    }
}
// Podstaw pod zmienną "name" dowolne imię, pod zmienną "age" dowolny wiek, a pod zmienną "man" true lub false
// - zawsze wyświetli się jeden z ośmiu dostępnych komunikatów.

// PS. To była czysta przyjemność. :) 
// Pozdrawiam, Piotr (Tanard)