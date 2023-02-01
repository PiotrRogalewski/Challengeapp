namespace Challengeapp.Tests
{
    public class Tests
    {

        [Test]
        public void WhenUser1GetsPoints_ShouldReturnCorrectResult()
        {
            var user1 = new Employee("Jakub", "Kowal", "32");
            user1.SubstractScore(1);
            user1.AddScore(5);
            user1.AddScore(6);
            user1.SubstractScore(4);
            user1.AddScore(4);

            var result1 = user1.Result;

            Assert.AreEqual(10, result1);
        }
        [Test]
        public void WhenUser2GetsPoints_ShouldReturnCorrectResult()
        {
            var user2 = new Employee("Tomasz", "Szewc", "29");
            user2.AddScore(5);
            user2.SubstractScore(4);
            user2.AddScore(7);
            user2.SubstractScore(3);
            user2.AddScore(6);

            var result2 = user2.Result;
            Assert.AreEqual(11, result2);
        }
        [Test]
        public void WhenUser3GetsPoints_ShouldReturnCorrectResult()
        {
            var user3 = new Employee("Krystian", "Jarosz", "35");
            user3.AddScore(8);
            user3.SubstractScore(3);
            user3.AddScore(2);
            user3.SubstractScore(1);
            user3.AddScore(6);

            var result3 = user3.Result;
            Assert.AreEqual(12, result3);
        }
    }
}