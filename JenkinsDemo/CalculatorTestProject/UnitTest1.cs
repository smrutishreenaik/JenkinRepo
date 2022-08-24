using CalculatorNamespace;

namespace CalculatorTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddTest()
        {
            Calculator c = new Calculator();
            int expected = 10;
            int actual = c.Add(7, 3);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void SubtractTest()
        {
            Calculator c = new Calculator();
            int expected = 4;
            int actual = c.Substract(7, 3);
            Assert.AreEqual(expected, actual);
        }
    }
}