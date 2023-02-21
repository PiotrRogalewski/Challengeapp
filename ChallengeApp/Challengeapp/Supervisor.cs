namespace Challengeapp
{
    public class Supervisor : IEmployee
    {
        private List<float> grades = new List<float>();

        public Supervisor(string name, string surname, string gender)
        {
            this.Name = name;
            this.Surname = surname;
            this.Gender = gender;

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
                        Console.WriteLine("Wykryto błąd:  Nazwa płci tej osoby jest nieprawidłowa. Masz do wyboru 3 opcje: 'mężczyzna', 'kobieta' lub 'inna płeć'. Możesz wpisać 'M' lub 'm' lub 'man' dla płci: mężczyzna, 'K' lub 'k' lub 'woman' dla płci: kobieta, albo 'I' lub 'i' lub 'other' dla opcji 'inna płeć'. Aby poprawnie ustalić płeć osoby: wpisz jedną z podanych liter, lub wpisz pełną nazwę jednej z trzech podanych opcji dla parametru płeć.");
                    }
                    break;
            }
        }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public string Gender { get; private set; }

        public void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else if (grade < 0 || grade > 100)
            {
                throw new Exception("  Nieprawidłowa wartość 'float'.   Podaj wartość z zakresu od 0 do 100 lub wartość w formie oceny od 1 do 6. Nie możesz dać ocen 6+ (lub +6) oraz 1- (lub -1), gdyż byłyby one poza zakresem 0-100 punktów.");
            }
        }

        public void AddGrade(string grade)
        {
            switch (grade)
            {
                case "6" or "sześć":
                    this.grades.Add(100);
                    break;
                case "5" or "pięć":
                    this.grades.Add(80);
                    break;
                case "4" or "cztery":
                    this.grades.Add(60);
                    break;
                case "3" or "trzy":
                    this.grades.Add(40);
                    break;
                case "2" or "dwa":
                    this.grades.Add(20);
                    break;
                case "1" or "jeden":
                    this.grades.Add(0);
                    break;
                case "6-" or "-6" or "sześć minus":
                    this.grades.Add(95);
                    break;
                case "5+" or "+5" or "pięć plus":
                    this.grades.Add(85);
                    break;
                case "5-" or "-5" or "pięć minus":
                    this.grades.Add(75);
                    break;
                case "4+" or "+4" or "cztery plus":
                    this.grades.Add(65);
                    break;
                case "4-" or "-4" or "cztery minus":
                    this.grades.Add(55);
                    break;
                case "3+" or "+3" or "trzy plus":
                    this.grades.Add(45);
                    break;
                case "3-" or "-3" or "trzy minus":
                    this.grades.Add(35);
                    break;
                case "2+" or "+2" or "dwa plus":
                    this.grades.Add(25);
                    break;
                case "2-" or "-2" or "dwa minus":
                    this.grades.Add(15);
                    break;
                case "1+" or "+1" or "jeden plus":
                    this.grades.Add(5);
                    break;
                default:
                    if (float.TryParse(grade, out float result))
                    {
                        this.AddGrade(result);
                    }
                    else
                    {
                        throw new Exception("  Nieprawidłowa wartość 'string'.  Podaj wartość z zakresu od 0 do 100 lub wartość w formie oceny od 1 do 6. Nie możesz dać ocen 6+ (lub +6) oraz 1- (lub -1), gdyż byłyby one poza zakresem 0-100 punktów.");
                    }
                    break;
            }
        }

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var grade in this.grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Max = (float)Math.Round(statistics.Max, 2);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Min = (float)Math.Round(statistics.Min, 2);
                statistics.Average += grade;
            }
            statistics.Average /= this.grades.Count;
            statistics.Average = (float)Math.Round(statistics.Average, 2);

            switch (statistics.Average)
            {
                case var average when average >= 80:
                    statistics.AverageLetter = 'A';
                    break;
                case var average when average >= 60:
                    statistics.AverageLetter = 'B';
                    break;
                case var average when average >= 40:
                    statistics.AverageLetter = 'C';
                    break;
                case var average when average >= 20:
                    statistics.AverageLetter = 'D';
                    break;
                default:
                    statistics.AverageLetter = 'E';
                    break;
            }
            return statistics;
        }
    }
}