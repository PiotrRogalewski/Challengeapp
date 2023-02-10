namespace Challengeapp.Tests
{
    public class EmployeeTests
    {
        [Test]
        public void WhenAddingCharLettersAsAGradeIsCorrect_ReturnMinMaxAndAverageResult()
        {
            var employee = new Employee();

            employee.AddGrade('a');
            employee.AddGrade('C');
            employee.AddGrade('D');
            employee.AddGrade('c');
            employee.AddGrade('i');

            var statistics = employee.GetStatistics();

            Assert.AreEqual(statistics.Min, 20);
            Assert.AreEqual(statistics.Max, 100);
            Assert.AreEqual(statistics.Average, 70);
        }

        [Test]
        public void WhenSwitchInGetStatisticsWorkingCorrect_ReturnAverageLetterResult()
        {
            var employee = new Employee();

            employee.AddGrade('b');
            employee.AddGrade(78);
            employee.AddGrade("43");
            employee.AddGrade('c');
            employee.AddGrade(91);

            var statistics = employee.GetStatistics();

            Assert.AreEqual(statistics.AverageLetter, 'B');
        }
    }
}