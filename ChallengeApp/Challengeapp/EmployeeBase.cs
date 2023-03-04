namespace Challengeapp
{
    public abstract class EmployeeBase : IEmployee
    {
        public delegate void GradeAddedDelegate(object sender, EventArgs args);

        public abstract event GradeAddedDelegate GradeAdded;

        public EmployeeBase(string name, string surname, string gender, int age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Gender = gender;
            this.Age = age;

            switch (gender)
            {
                case "M" or "m" or "mężczyzna" or "mezczyzna" or "man":
                    this.Gender = "mężczyzna";
                    break;
                case "K" or "k" or "kobieta" or "woman" or "W" or "w":
                    this.Gender = "kobieta";
                    break;
                case "I" or "i" or "inna płeć" or "other" or "Inna płeć":
                    this.Gender = "inna płeć";
                    break;
                default:
                    {
                        Console.WriteLine("  Wykryto błąd:  Nazwa płci tej osoby jest nieprawidłowa. Masz do wyboru 3 opcje: 'mężczyzna', 'kobieta' lub 'inna płeć'. Możesz wpisać 'M' lub 'm' lub 'man' dla płci: mężczyzna, 'K' lub 'k' lub 'woman' dla płci: kobieta, albo 'I' lub 'i' lub 'other' dla opcji 'inna płeć'. Aby poprawnie ustalić płeć osoby: wpisz jedną z podanych liter, lub wpisz pełną nazwę jednej z trzech podanych opcji dla parametru płeć.");
                    }
                    break;
            }
        }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public string Gender { get; protected set; }
        public int Age { get; private set; }

        public abstract void AddGrade(float grade);

        public abstract void AddGrade(int grade);

        public abstract void AddGrade(double grade);

        public abstract void AddGrade(string grade);

        public abstract void AddGrade(char grade);

        public abstract Statistics GetStatistics();
    }
}