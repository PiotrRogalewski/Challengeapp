using System;
using System.ComponentModel;

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
            sbyte valueInSbyte = grade;
            if (grade >= 0 && grade <= 100)
            {
                float valueInFloat = valueInSbyte;
                this.grades.Add(valueInFloat);
            }
            else
            {
                Console.WriteLine("Invalid grade value.The value must be in range from 0 to 100.");
            }
        }
        public void AddGrade(byte grade)
        {
            byte valueInByte = grade;
            if (grade >= 0 && grade <= 100)
            {
                float valueInFloat = valueInByte;
                this.grades.Add(valueInFloat);
            }
            else
            {
                Console.WriteLine("Invalid grade value.The value must be in range from 0 to 100.");
            }
        }
        public void AddGrade(short grade)
        {
            short valueInShort = grade;
            if (grade >= 0 && grade <= 100)
            {
                float valueInFloat = valueInShort;
                this.grades.Add(valueInFloat);
            }
            else
            {
                Console.WriteLine("Invalid grade value.The value must be in range from 0 to 100.");
            }
        }
        public void AddGrade(ushort grade)
        {
            ushort valueInUshort = grade;
            if (grade >= 0 && grade <= 100)
            {
                float valueInFloat = valueInUshort;
                this.grades.Add(valueInFloat);
            }
            else
            {
                Console.WriteLine("Invalid grade value.The value must be in range from 0 to 100.");
            }
        }
        public void AddGrade(int grade)
        {
            int valueInInt = grade;
            if (grade >= 0 && grade <= 100)
            {
                float valueInFloat = valueInInt;
                this.grades.Add(valueInFloat);
            }
            else
            {
                Console.WriteLine("Invalid grade value.The value must be in range from 0 to 100.");
            }
        }
        public void AddGrade(uint grade)
        {
            uint valueInUint = grade;
            if (grade >= 0 && grade <= 100)
            {
                float valueInFloat = valueInUint;
                this.grades.Add(valueInFloat);
            }
            else
            {
                Console.WriteLine("Invalid grade value.The value must be in range from 0 to 100.");
            }
        }
        public void AddGrade(long grade)
        {
            long valueInLong = grade;
            if (grade >= 0 && grade <= 100)
            {
                float valueInFloat = valueInLong;
                this.grades.Add(valueInFloat);
            }
            else
            {
                Console.WriteLine("Invalid grade value.The value must be in range from 0 to 100.");
            }
        }
        public void AddGrade(ulong grade)
        {
            ulong valueInUlong = grade;
            if (grade >= 0 && grade <= 100)
            {
                float valueInFloat = valueInUlong;
                this.grades.Add(valueInFloat);
            }
            else
            {
                Console.WriteLine("Invalid grade value.The value must be in range from 0 to 100.");
            }
        }
        public void AddGrade(double grade)
        {
            double valueInDouble = grade;
            if (grade >= 0 && grade <= 100)
            {
                float valueInFloat = (float)valueInDouble;
                this.grades.Add(valueInFloat);
            }
            else
            {
                Console.WriteLine("Invalid grade value.The value must be in range from 0 to 100.");
            }
        }
        public void AddGrade(decimal grade)
        {
            decimal valueInDecimal = grade;
            if (grade >= 0 && grade <= 100)
            {
                float valueInFloat = (float)valueInDecimal;
                this.grades.Add(valueInFloat);
            }
            else
            {
                Console.WriteLine("Invalid grade value.The value must be in range from 0 to 100.");
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
            return statistics;
        }
    }
}