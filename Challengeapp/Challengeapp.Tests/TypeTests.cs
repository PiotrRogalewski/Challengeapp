namespace Challengeapp.Tests
{
    public class TypeTests
    {
        // Reference Type Tests:
        [Test] // 1.
        public void ReferenceTypeTestForUser()
        {
            var user1 = GetUser("Robert");
            var user2 = GetUser("Robert");
            Assert.AreNotEqual(user1, user2);
        }
        private Employee GetUser(string user)
        {
            return new Employee(user);
        }

        [Test] // 2.
        public void ReferenceTypeTestForUserAge()
        {
            var user3Age = GetAge("34");
            var user4Age = GetAge("34");
            Assert.AreNotEqual(user3Age, user4Age);
        }
        private Employee GetAge(string age)
        {
            return new Employee(age);
        }

        [Test] // 3.
        public void ReferenceTypeTestOnlyForUserName()
        {
            var user3Name = GetName("Piotr");
            var user4Name = GetName("Piotr");
            Assert.AreEqual(user3Name.Name, user4Name.Name);
        }
        private Employee GetName(string name)
        {
            return new Employee(name);
        }

        // Value Type Tests:
        [Test] // 4.
        public void ValueTypeTestForInt()
        {
            int number1 = 11;
            int number2 = 21;

            Assert.AreNotEqual(number1, number2);
        }

        [Test] // 5.
        public void ValueTypeTestForString()
        {
            string character1 = "Knight";
            string character2 = "Knight";

            Assert.AreEqual(character1, character2);
        }

        [Test] // 6.
        public void ValueTypeTestForFloat()
        {
            float number3 = 444555777888999111;
            float number4 = 444565777888599111;

            Assert.AreNotEqual(number3, number4);
        }
    }
}