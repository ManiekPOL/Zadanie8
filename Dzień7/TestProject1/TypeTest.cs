

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
        public void GetEmployeeShouldReturndifferentObjects()
        {
            //arrange
            var Employee1 = GetEmployee("Adam", "Ślusarczyk", 80);
            var Employee2 = GetEmployee("Adam", "Ślusarczyk", 80);
            //act

            //assert
            Assert.AreEqual(Employee1.Name, Employee2.Name);
            Assert.AreEqual(Employee1.Surname, Employee2.Surname);
            Assert.AreEqual(Employee1.Age, Employee2.Age);

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
            float number1 = 5.6f;
            float number2 = 5.6f;
            //act

            //assert
            Assert.AreEqual(number1, number2);

        }

        private Employee GetEmployee(string name, string surname, int age)
        {
            return new Employee(name, surname, age);
        }



    }
}
