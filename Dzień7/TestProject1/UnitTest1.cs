

using Dzieñ7;

namespace TestProject1
{
    public class Tests
    {
        

        [Test]
        public void TestEmployee1()
        {
            var employee = new Employee("Marek", "Nowak", 50);
            employee.AddScore(7);
            employee.AddScore(9);
            employee.AddScore(-8);

            var result = employee.Result;

            Assert.AreEqual(8, result);
        }

        [Test]
        public void TestEmployee2()
        {
            var employee = new Employee("Marek", "Malina", 50);
            employee.AddScore(7);
            employee.AddScore(3);
            employee.AddScore(-5);

            var result = employee.Result;

            Assert.AreEqual(5, result);
        }
    }
}