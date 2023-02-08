using System;
using System.ComponentModel;
using System.Diagnostics;

namespace Challengeapp
{
    public class Employee
    {
        private List<float> grades = new List<float>();
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
                Console.WriteLine("Invalid grade value.The value must be in range from 0 to 100.");
            }
        }
        public void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {

                this.AddGrade(result);
            }
            else
            {
                Console.WriteLine("String is not float.");
            }
        }
        public void AddGrade(sbyte grade)
        {
            AddGrade((float)grade);
        }
        public void AddGrade(byte grade)
        {
            AddGrade((float)grade);
        }
        public void AddGrade(short grade)
        {
            AddGrade((float)grade);
        }
        public void AddGrade(ushort grade)
        {
            AddGrade((float)grade);
        }
        public void AddGrade(int grade)
        {
            AddGrade((float)grade);
        }
        public void AddGrade(uint grade)
        {
            AddGrade((float)grade);
        }
        public void AddGrade(long grade)
        {
            AddGrade((float)grade);
        }
        public void AddGrade(ulong grade)
        {
            AddGrade((float)grade);
        }
        public void AddGrade(double grade)
        {
            AddGrade((float)grade);
        }
        public void AddGrade(decimal grade)
        {
            AddGrade((float)grade);
        }

        public Statistics GetStatisticsWithForEach()
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
            return statistics;
        }

        public Statistics GetStatisticsWithFor()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            for (var index = 0; index < this.grades.Count; index++)
            {
                statistics.Max = Math.Max(statistics.Max, this.grades[index]);
                statistics.Max = (float)Math.Round(statistics.Max, 2);
                statistics.Min = Math.Min(statistics.Min, this.grades[index]);
                statistics.Min = (float)Math.Round(statistics.Min, 2);
                statistics.Average += this.grades[index];
            }
            statistics.Average /= this.grades.Count;
            statistics.Average = (float)Math.Round(statistics.Average, 2);
            return statistics;
        }

        public Statistics GetStatisticsWithDoWile()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            var index = 0;

            do
            {
                statistics.Max = Math.Max(statistics.Max, this.grades[index]);
                statistics.Max = (float)Math.Round(statistics.Max, 2);
                statistics.Min = Math.Min(statistics.Min, this.grades[index]);
                statistics.Min = (float)Math.Round(statistics.Min, 2);
                statistics.Average += this.grades[index];
                index++;
            } while (index < this.grades.Count);
            statistics.Average /= this.grades.Count;
            statistics.Average = (float)Math.Round(statistics.Average, 2);
            return statistics;
        }

        public Statistics GetStatisticsWithWile()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            var index = 0;

            while (index < this.grades.Count)
            {
                statistics.Max = Math.Max(statistics.Max, this.grades[index]);
                statistics.Max = (float)Math.Round(statistics.Max, 2);
                statistics.Min = Math.Min(statistics.Min, this.grades[index]);
                statistics.Min = (float)Math.Round(statistics.Min, 2);
                statistics.Average += this.grades[index];
                index++;
            }
            statistics.Average /= this.grades.Count;
            statistics.Average = (float)Math.Round(statistics.Average, 2);
            return statistics;
        }
    }
}