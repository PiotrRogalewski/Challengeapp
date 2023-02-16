namespace Challengeapp
{
    public abstract class Person
    {
        public Person(string name, string surname, string gender)
        {
            this.Name = name;
            this.Surname = surname;
            this.Gender = gender;
        }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public string Gender { get; protected set; }
    }
}