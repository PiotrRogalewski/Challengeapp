// po prostu przyjmijmy że tego tutaj nie ma ;P
// dzięks ^^


// notatki:
//__________________________________________________________________________________________________________________________________

//namespace Challengeapp
//{
//    public abstract class Person
//    {
//        public Person(string name, string surname, string gender)
//        {
//            this.Name = name;
//            this.Surname = surname;
//            this.Gender = gender;
//        }
//        public string Name { get; private set; }
//        public string Surname { get; private set; }
//        public string Gender { get; protected set; }
//    }
//}


// to do Konstruktora Employee:
//        : base(name, surname, gender)



// Składowe interfacu nie mogą być oznaczone atrybutem dostępu (domyślnie ustawiony jest public)
// Interface umożliwia jedynie deklarację składowych, bez implementacji 
// Interface może dziedziczyć jedynie po innych interface-sach
// Klasa abstrakcyjna może dziedziczyć po klasach abstrakcyjnych, interfejsach, a nawet po zwykłych klasach
// Jeśli do interfejsu zostanie dodana nowa metoda trzeba prześledzić wszystki klasy implementujące dany interface i dodać implementację nowej metody (muszą istnieć - nawet jeśli to tylko takie "wydmuszki" które jedynie rzucają exeptiona, ale istnieją)
// Interface nie może mieć konstruktora
// Jeśli w klasie nie ma logiki zróbmy z niej interface a nie klasę abstrakcyjną (taka jest dobra praktyka)


// Interface - określa CO ...?? - ma być zaimplementowane. Zawiera definicje metod, (pól) property. Nie zawiera logiki.
// Interface - Nie ma public/private - bo to jedynie definicje. Nie zawiera prywatnych metod i niczego co prywatne.
// Klasa - określa JAK ...?? czyli rozwiąznie jak to zrobić. Implementujemy metody, pola.
// </summary>

//__________________________________________________________________________________________________________________________________