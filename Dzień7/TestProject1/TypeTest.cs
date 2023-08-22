

using Dzień7;

namespace TestProject1
{
    public class TypeTest
    {
        [Test]
        public void STRING_TEST()
        {
            //arrange
            string nb1 = "Lewy";
            string nb2 ="Lewy";
            //act

            //assert
            Assert.AreEqual(nb1, nb2);

        }


        [Test]
        public void GetemployeeShouldReturndifferentObjects()
        {
            //arrange
            var employee1 = GetEmployee("Adam", "Ślusarczyk", 80);
            var employee2 = GetEmployee("Adam", "Ślusarczyk", 80);
            //act

            //assert
            Assert.AreEqual(employee1.Name, employee2.Name);
            Assert.AreEqual(employee1.Surname, employee2.Surname);
            Assert.AreEqual(employee1.Age, employee2.Age);

        }

        [Test]
        public void INT_TEST()
        {
            //arrange
            int number1 = 5;
            int number2 = 5;
            //act

            //assert
            Assert.AreEqual(number1, number2);

        }

        [Test]
        public void FLOAT_TEST()
        {
            //arrange
            float number3 = 5.6f;
            float number4 = 5.6f;
            //act

            //assert
            Assert.AreEqual(number3, number4);

        }

        private Employee GetEmployee(string name, string surname, int age)
        {
            return new Employee(name, surname, age);
        }



    }
}
