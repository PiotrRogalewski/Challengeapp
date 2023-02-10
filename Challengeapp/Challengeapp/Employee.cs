namespace Challengeapp
{
    public class Employee
    {

        private List<float> grades = new List<float>();
        public Employee()
        {

        }
        public Employee(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }
        public string Name { get; private set; }
        public string Surname { get; private set; }

        public void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                throw new Exception("Nieprawidłowa wartość. Podaj wartość z zakresu od 0 do 100 lub jedną z liter z Tabeli liter.");
            }
        }
        public void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {

                this.AddGrade(result);
            }
            else if (char.TryParse(grade, out char gradesInLetters))
            {
                AddGrade(gradesInLetters);
            }
            else
            {
                throw new Exception("Nieprawidłowa wartość. Podaj wartość z zakresu od 0 do 100 lub jedną z liter z Tabeli liter.");
            }
        }

        public void AddGrade(char grade)
        {
            switch (grade)
            {
                case 'A' or 'a':
                    this.grades.Add(100);
                    break;
                case 'B' or 'b':
                    this.grades.Add(90);
                    break;
                case 'C' or 'c':
                    this.grades.Add(80);
                    break;
                case 'D' or 'd':
                    this.grades.Add(70);
                    break;
                case 'E' or 'e':
                    this.grades.Add(60);
                    break;
                case 'F' or 'f':
                    this.grades.Add(50);
                    break;
                case 'G' or 'g':
                    this.grades.Add(40);
                    break;
                case 'H' or 'h':
                    this.grades.Add(30);
                    break;
                case 'I' or 'i':
                    this.grades.Add(20);
                    break;
                case 'J' or 'j':
                    this.grades.Add(10);
                    break;
                default:
                    throw new Exception("Nieprawidłowa wartość. Podaj wartość z zakresu od 0 do 100 lub jedną z liter z Tabeli liter.");
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