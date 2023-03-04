namespace Challengeapp
{
    public class EmployeeInFile : EmployeeBase
    {
        public override event GradeAddedDelegate GradeAdded;

        private readonly string fileNameWithEmployeeName;

        private readonly static string fileName = "grades.txt";

        public EmployeeInFile(string name, string surname, string gender, int age)
                : base(name, surname, gender, age)
        {
            fileNameWithEmployeeName = $"{name}_{surname}_{fileName}";
        }

        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                using (var writer = File.AppendText(fileNameWithEmployeeName))
                {
                    writer.WriteLine(grade);
                }

                if (GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
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
                    AddGrade((float)100);
                    break;
                case 'B' or 'b':
                    AddGrade((float)90);
                    break;
                case 'C' or 'c':
                    AddGrade((float)80);
                    break;
                case 'D' or 'd':
                    AddGrade((float)70);
                    break;
                case 'E' or 'e':
                    AddGrade((float)60);
                    break;
                case 'F' or 'f':
                    AddGrade((float)50);
                    break;
                case 'G' or 'g':
                    AddGrade((float)40);
                    break;
                case 'H' or 'h':
                    AddGrade((float)30);
                    break;
                case 'I' or 'i':
                    AddGrade((float)20);
                    break;
                case 'J' or 'j':
                    AddGrade((float)10);
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

            if (File.Exists($"{fileNameWithEmployeeName} "))
            {
                using (var reader = File.OpenText(fileNameWithEmployeeName))
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
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" Plik do zapisu danych tego pracownika nie istnieje");
                Console.ResetColor();
            }
            return grades;
        }

        private Statistics CountStatistics(List<float> grades)
        {
            var statistics = new Statistics();

            foreach (var grade in grades)
            {
                statistics.AddGrade(grade);
            }

            return statistics;
        }
    }
}