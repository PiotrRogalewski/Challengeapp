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
            if (points >= 0 && points <= 10)
            {
                this.employeeScore.Add(points);
            }
            else if (points > 10 || points < 0)
            {
                Console.WriteLine("Looks like someone is cheating here! You can only give 0-10 points, no more, no less.");
                Console.WriteLine("If you want to substract points, you should use: --> SubstractScore <-- method.");
                Console.WriteLine("PLEASE SET THE CORRECT NUMBER OF POINTS!");
                Console.WriteLine(" ");
            }
            //please set the correct number of points!
        }
        public void SubstractScore(int minusPoints)
        {
            if (minusPoints >= 0 && minusPoints <= 10)
            {
                this.employeeScore.Add(minusPoints);
            }
            else if (minusPoints > 10 || minusPoints < 0)
            {
                Console.WriteLine("Looks like someone is cheating here! You can only give 0-10 minus points, no more, no less.");
                Console.WriteLine("If you want to add points use: --> AddScore <-- method.");
                Console.WriteLine("PLEASE SET THE CORRECT NUMBER OF POINTS!");
                Console.WriteLine(" ");
            }
        }
    }
}