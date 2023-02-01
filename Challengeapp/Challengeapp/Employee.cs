namespace Challengeapp

{
    public class Employee
    {
        public static string NameOfScoreboard = "           EMPLOYEE SCOREBOARD";

        private List<int> employeeScore = new List<int>();

        public Employee(string name, string surname, string age)
        {
            this.Name = name;
            this.Surname = " " + surname + ",";
            this.Age = " lat " + age;
        }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public string Age { get; private set; }
        public int Result
        {
            get
            {
                return this.employeeScore.Sum();
            }
        }

        public void AddScore(int points)
        {
            this.employeeScore.Add(points);
        }
        public void SubstractScore(int minusPoints)
        {
            this.employeeScore.Add(-minusPoints);
        }

    }
}