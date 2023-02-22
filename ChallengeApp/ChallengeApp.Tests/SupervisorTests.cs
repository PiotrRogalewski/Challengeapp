namespace Challengeapp.Tests
{
    public class SupervisorTests
    {
        [Test]
        public void IfTheAddGradeAsAStringWorksProperly_ShouldReturnTheCorrectStatisticsResult()
        {
            // arrange
            var supervisor = new Supervisor("noname", "nosurname", "i");

            // act
            supervisor.AddGrade("+2");
            supervisor.AddGrade("5+");
            supervisor.AddGrade("-4");
            supervisor.AddGrade("4+");
            supervisor.AddGrade("6-");

            var statistics = supervisor.GetStatistics();

            // assert
            Assert.AreEqual(statistics.Min, 25);
            Assert.AreEqual(statistics.Max, 95);
            Assert.AreEqual(statistics.Average, 65);
        }

        [Test]
        public void IfTheAddGradeAsAFloatWorksProperly_ShouldReturnTheCorrectStatisticsResult()
        {
            var supervisor = new Supervisor("noname", "nosurname", "i");

            supervisor.AddGrade(33);
            supervisor.AddGrade(56);
            supervisor.AddGrade(99);
            supervisor.AddGrade(75);
            supervisor.AddGrade(5);

            var statistics = supervisor.GetStatistics();

            Assert.AreEqual(statistics.Min, 5);
            Assert.AreEqual(statistics.Max, 99);
            Assert.AreEqual(statistics.Average, 53,6);
        }
    }
}



//      //--------------------------------------------------------------------||--------------------------------------------------------------------\\
//                                                                  ~~~~~~ NOTATKI ~~~~~~


//      nazwa testu:    public void IfSthWorkProperly_ShouldReturnTheCorrectSthResult

//          1)          assert
//          2)          act
//          3)          arrange

//      \\--------------------------------------------------------------------||--------------------------------------------------------------------//