namespace Challengeapp.Tests
{
    public class EmployeeTests
    {
        [Test]
        public void StatisticsTestForMin()
        {
            var employee = new Employee("Pawe³", "Kowalski");

            employee.AddGrade(2ul);
            employee.AddGrade(8d);
            employee.AddGrade(5f);
            var statistics = employee.GetStatistics();

            Assert.AreEqual(statistics.Min, 2);
        }

        [Test]
        public void StatisticsTestForMax()
        {
            var employee = new Employee("Robert", "Nowak");

            employee.AddGrade(675365m);
            employee.AddGrade(7);
            employee.AddGrade("5");
            var statistics = employee.GetStatistics();

            Assert.AreEqual(statistics.Max, 7);
        }

        [Test]
        public void StatisticsTesForAverage()
        {
            var employee = new Employee("Karol", "Heisenberg");

            employee.AddGrade(8u);
            employee.AddGrade(2l);
            employee.AddGrade(5);
            var statistics = employee.GetStatistics();

            Assert.AreEqual(statistics.Average, 5);
        }
    }
}