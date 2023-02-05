namespace Challengeapp.Tests
{
    public class EmployeeTests
    {
        [Test]
        public void StatisticsTestForMin()
        {
            var employee = new Employee("Pawe³", "Kowalski");

            employee.AddGrade(2);
            employee.AddGrade(8);
            employee.AddGrade(5);
            var statistics = employee.GetStatistics();

            Assert.AreEqual(statistics.Min, 2);
        }

        [Test]
        public void StatisticsTestForMax()
        {
            var employee = new Employee("Robert", "Nowak");

            employee.AddGrade(3);
            employee.AddGrade(7);
            employee.AddGrade(5);
            var statistics = employee.GetStatistics();

            Assert.AreEqual(statistics.Max, 7);
        }

        [Test]
        public void StatisticsTesForAverage()
        {
            var employee = new Employee("Karol", "Heisenberg");
             
            employee.AddGrade(8);
            employee.AddGrade(-2);
            employee.AddGrade(6);
            var statistics = employee.GetStatistics();

            Assert.AreEqual(statistics.Average, 4);
        }
    }
}