namespace Challengeapp
{
    public class EmployeeInFile : EmployeeBase
    {
        private const string fileName = "grades.txt";

        public EmployeeInFile(string name, string surname, string gender)
            : base(name, surname, gender)
        { }

        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                using (var writer = File.AppendText(fileName))
                {
                    writer.WriteLine(grade);
                }
            }
            else
            {
                throw new Exception("  Nieprawidłowa wartość liczbowa. Podaj wartość z zakresu od 0 do 100 lub jedną z liter z Tabeli liter.");
            }
        }

        public override void AddGrade(int grade)
        {
            AddGrade((float)grade);
        }

        public override void AddGrade(double grade)
        {
            AddGrade((float)grade);
        }

        public override void AddGrade(string grade)
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
                throw new Exception("  Nieprawidłowa wartość tekstowa. Podaj wartość z zakresu od 0 do 100 lub jedną z liter z Tabeli liter.");
            }
        }

        public override void AddGrade(char grade)
        {
            switch (grade)
            {
                case 'A' or 'a':
                    using (var writer = File.AppendText(fileName))
                    {
                        writer.WriteLine((float)100);
                    }
                    break;
                case 'B' or 'b':
                    using (var writer = File.AppendText(fileName))
                    {
                        writer.WriteLine((float)90);
                    }
                    break;
                case 'C' or 'c':
                    using (var writer = File.AppendText(fileName))
                    {
                        writer.WriteLine((float)80);
                    }
                    break;
                case 'D' or 'd':
                    using (var writer = File.AppendText(fileName))
                    {
                        writer.WriteLine((float)70);
                    }
                    break;
                case 'E' or 'e':
                    using (var writer = File.AppendText(fileName))
                    {
                        writer.WriteLine((float)60);
                    }
                    break;
                case 'F' or 'f':
                    using (var writer = File.AppendText(fileName))
                    {
                        writer.WriteLine((float)50);
                    }
                    break;
                case 'G' or 'g':
                    using (var writer = File.AppendText(fileName))
                    {
                        writer.WriteLine((float)40);
                    }
                    break;
                case 'H' or 'h':
                    using (var writer = File.AppendText(fileName))
                    {
                        writer.WriteLine((float)30);
                    }
                    break;
                case 'I' or 'i':
                    using (var writer = File.AppendText(fileName))
                    {
                        writer.WriteLine((float)20);
                    }
                    break;
                case 'J' or 'j':
                    using (var writer = File.AppendText(fileName))
                    {
                        writer.WriteLine((float)10);
                    }
                    break;
                default:
                    throw new Exception("  Nieprawidłowa wartość literowa. Podaj wartość z zakresu od 0 do 100 lub jedną z liter z Tabeli liter.");
            }
        }

        public override Statistics GetStatistics()
        {
            var gradesFromFile = this.ReadGradesFromFile();
            var result = this.CountStatistics(gradesFromFile);
            return result;
        }

        private List<float> ReadGradesFromFile()
        {
            var grades = new List<float>();
            if (File.Exists($"{fileName} "))
            {
                using (var reader = File.OpenText(fileName))
                {
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        var number = float.Parse(line);
                        grades.Add(number);
                        line = reader.ReadLine();
                    }
                }
            }
            return grades;
        }

        private Statistics CountStatistics(List<float> grades)
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var grade in grades)
            {
                if (grade >= 0)
                {
                    statistics.Max = Math.Max(statistics.Max, grade);
                    statistics.Max = (float)Math.Round(statistics.Max, 2);
                    statistics.Min = Math.Min(statistics.Min, grade);
                    statistics.Min = (float)Math.Round(statistics.Min, 2);
                    statistics.Average += grade;
                }
            }

            statistics.Average /= grades.Count;
            statistics.Average = statistics.Average * 10;
            statistics.Average = (float)Math.Round(statistics.Average, 2) / 10;

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
