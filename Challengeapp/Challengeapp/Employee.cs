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
            var statistics1 = new Statistics();
            statistics1.Average = 0;
            statistics1.Max = float.MinValue;
            statistics1.Min = float.MaxValue;

            foreach (var grade in this.grades)
            {
                statistics1.Max = Math.Max(statistics1.Max, grade);
                statistics1.Max = (float)Math.Round(statistics1.Max, 2);
                statistics1.Min = Math.Min(statistics1.Min, grade);
                statistics1.Min = (float)Math.Round(statistics1.Min, 2);
                statistics1.Average += grade;
            }
            statistics1.Average /= this.grades.Count;
            statistics1.Average = (float)Math.Round(statistics1.Average, 2);
            return statistics1;
        }

        public Statistics GetStatisticsWithFor()
        {
            var statistics2 = new Statistics();
            statistics2.Average = 0;
            statistics2.Max = float.MinValue;
            statistics2.Min = float.MaxValue;

            for (var index = 0; index < this.grades.Count; index++)
            {
                statistics2.Max = Math.Max(statistics2.Max, this.grades[index]);
                statistics2.Max = (float)Math.Round(statistics2.Max, 2);
                statistics2.Min = Math.Min(statistics2.Min, this.grades[index]);
                statistics2.Min = (float)Math.Round(statistics2.Min, 2);
                statistics2.Average += this.grades[index];
            }
            statistics2.Average /= this.grades.Count;
            statistics2.Average = (float)Math.Round(statistics2.Average, 2);
            return statistics2;
        }

        public Statistics GetStatisticsWithDoWile()
        {
            var statistics3 = new Statistics();
            statistics3.Average = 0;
            statistics3.Max = float.MinValue;
            statistics3.Min = float.MaxValue;
            var index = 0;

            do
            {
                statistics3.Max = Math.Max(statistics3.Max, this.grades[index]);
                statistics3.Max = (float)Math.Round(statistics3.Max, 2);
                statistics3.Min = Math.Min(statistics3.Min, this.grades[index]);
                statistics3.Min = (float)Math.Round(statistics3.Min, 2);
                statistics3.Average += this.grades[index];
                index++;
            } while (index < this.grades.Count);
            statistics3.Average /= this.grades.Count;
            statistics3.Average = (float)Math.Round(statistics3.Average, 2);
            return statistics3;
        }

        public Statistics GetStatisticsWithWile()
        {
            var statistics4 = new Statistics();
            statistics4.Average = 0;
            statistics4.Max = float.MinValue;
            statistics4.Min = float.MaxValue;
            var index = 0;

            while (index < this.grades.Count)
            {
                statistics4.Max = Math.Max(statistics4.Max, this.grades[index]);
                statistics4.Max = (float)Math.Round(statistics4.Max, 2);
                statistics4.Min = Math.Min(statistics4.Min, this.grades[index]);
                statistics4.Min = (float)Math.Round(statistics4.Min, 2);
                statistics4.Average += this.grades[index];
                index++;
            }
            statistics4.Average /= this.grades.Count;
            statistics4.Average = (float)Math.Round(statistics4.Average, 2);
            return statistics4;
        }
    }
}