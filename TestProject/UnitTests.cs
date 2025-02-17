using CalculatorLibrary;
using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace TestProject
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void Addition_PositiveNumbers_ReturnsCorrectSum()
        {
            ClassLibrary library = new ClassLibrary();
            List<double> numbers = new List<double> { 10, 20, 30 };
            double result = library.Addition(numbers);
            Assert.AreEqual(60, result);
        }

        [TestMethod]
        public void Difference_PositiveNumbers_ReturnsCorrectDifference()
        {
            ClassLibrary library = new ClassLibrary();
            List<double> numbers = new List<double> { 100, 20, 10 };
            double result = library.Difference(numbers);
            Assert.AreEqual(70, result);
        }

        [TestMethod]
        public void Division_ValidNumbers_ReturnsCorrectQuotient()
        {
            ClassLibrary library = new ClassLibrary();
            List<double> numbers = new List<double> { 100, 10, 2 };
            double result = library.Division(numbers);
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void Division_DivideByZero_ThrowsException()
        {
            ClassLibrary library = new ClassLibrary();
            List<double> numbers = new List<double> { 10, 0 };
            Assert.ThrowsException<DivideByZeroException>(() => library.Division(numbers));
        }

        [TestMethod]
        public void Multiplication_PositiveNumbers_ReturnsCorrectProduct()
        {
            ClassLibrary library = new ClassLibrary();
            List<double> numbers = new List<double> { 5, 6, 2 };
            double result = library.Multiplication(numbers);
            Assert.AreEqual(60, result);
        }

        [TestMethod]
        public void Exponentiation_PositiveNumberAndPower_ReturnsCorrectResult()
        {
            ClassLibrary library = new ClassLibrary();
            double number = 2;
            double power = 3;
            double expectedResult = Math.Pow(number, power);

            using (var consoleOutput = new StringWriter())
            {
                Console.SetOut(consoleOutput);
                // Имитация пользовательского ввода, т.к. проверяемая функция являеться типа void
                Console.SetIn(new StringReader($"{number}{Environment.NewLine}{power}"));
                library.Exponentiation();

                string output = consoleOutput.ToString();
                Assert.IsTrue(output.Contains(expectedResult.ToString()));
            }
        }

        [TestMethod]
        public void Rooting_PositiveNumber_ReturnsCorrectResult()
        {
            ClassLibrary library = new ClassLibrary();
            double number = 9;
            double expectedResult = Math.Sqrt(number);

            using (var consoleOutput = new StringWriter())
            {
                Console.SetOut(consoleOutput);
                Console.SetIn(new StringReader($"{number}"));
                library.Rooting();
                string output = consoleOutput.ToString();
                Assert.IsTrue(output.Contains(expectedResult.ToString()));
            }
        }

        [TestMethod]
        public void Percentage_PositiveNumberAndPercent_ReturnsCorrectResult()
        {
            ClassLibrary library = new ClassLibrary();
            double number = 200;
            double percent = 10;
            double expectedResult = number * percent / 100;

            using (var consoleOutput = new StringWriter())
            {
                Console.SetOut(consoleOutput);
                Console.SetIn(new StringReader($"{number}{Environment.NewLine}{percent}"));
                library.Percentage();

                string output = consoleOutput.ToString();
                Assert.IsTrue(output.Contains(expectedResult.ToString()));
            }
        }

        [TestMethod]
        public void Log_PositiveNumberAndOsn_ReturnsCorrectResult()
        {
            ClassLibrary library = new ClassLibrary();
            double number = 8;
            double osn = 2;
            double expectedResult = Math.Log(number, osn);

            using (var consoleOutput = new StringWriter())
            {
                Console.SetOut(consoleOutput);
                Console.SetIn(new StringReader($"{number}{Environment.NewLine}{osn}"));
                library.Log();

                string output = consoleOutput.ToString();
                Assert.IsTrue(output.Contains(expectedResult.ToString()));
            }
        }

        [TestMethod]
        public void Sin_PositiveNumber_ReturnsCorrectResult()
        {
            ClassLibrary library = new ClassLibrary();
            double degree = 30;
            double radians = degree * Math.PI / 180;
            double expectedResult = Math.Sin(radians);

            using (var consoleOutput = new StringWriter())
            {
                Console.SetOut(consoleOutput);
                Console.SetIn(new StringReader($"{degree}"));
                library.Sin();

                string output = consoleOutput.ToString();
                Assert.IsTrue(output.Contains(expectedResult.ToString()));
            }
        }
    }
}