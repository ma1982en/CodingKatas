using NUnit.Framework;

namespace FizzBuzzKata
{
    public class FizzBuzzTests
    {
        private IFizzBuzzConverter _fizzBuzzConverter;

        [SetUp]
        public void Setup()
        {
            _fizzBuzzConverter = new FizzBuzzConverter();
        }

        [Test]
        public void Test_Initialize()
        {
            //arrange

            //act
            _fizzBuzzConverter = new FizzBuzzConverter();

            //assert
            Assert.Pass("Initialize successful");
        }

        [Test]
        public void Test_Inside_0_return_0()
        {
            //arrange
            const int parameter = 0;

            //act
            var current= _fizzBuzzConverter.Convert(parameter);

            //assert
            Assert.AreEqual(parameter.ToString(),current);
        }

        [Test]
        public void Test_Inside_3_return_FIZZ()
        {
            //arrange
            const int parameter = 3;

            //act
            var current = _fizzBuzzConverter.Convert(parameter);

            //assert
            Assert.AreEqual("FIZZ", current);
        }

        [Test]
        public void Test_Inside_4_return_4()
        {
            //arrange
            const int parameter = 4;

            //act
            var current = _fizzBuzzConverter.Convert(parameter);

            //assert
            Assert.AreEqual("4", current);
        }

        [Test]
        public void Test_Inside_5_return_BUZZ()
        {
            //arrange
            const int parameter = 5;

            //act
            var current = _fizzBuzzConverter.Convert(parameter);

            //assert
            Assert.AreEqual("BUZZ", current);
        }

        [Test]
        public void Test_Inside_6_return_FIZZ()
        {
            //arrange
            const int parameter = 6;

            //act
            var current = _fizzBuzzConverter.Convert(parameter);

            //assert
            Assert.AreEqual("FIZZ", current);
        }

        [Test]
        public void Test_Inside_7_return_7()
        {
            //arrange
            const int parameter = 7;

            //act
            var current = _fizzBuzzConverter.Convert(parameter);

            //assert
            Assert.AreEqual("7", current);
        }

        [Test]
        public void Test_Inside_9_return_FIZZ()
        {
            //arrange
            const int parameter = 9;

            //act
            var current = _fizzBuzzConverter.Convert(parameter);

            //assert
            Assert.AreEqual("FIZZ", current);
        }

        [Test]
        public void Test_Inside_10_return_BUZZ()
        {
            //arrange
            const int parameter = 10;

            //act
            var current = _fizzBuzzConverter.Convert(parameter);

            //assert
            Assert.AreEqual("BUZZ", current);
        }

        [Test]
        public void Test_Inside_12_return_FIZZ()
        {
            //arrange
            const int parameter = 12;

            //act
            var current = _fizzBuzzConverter.Convert(parameter);

            //assert
            Assert.AreEqual("FIZZ", current);
        }

        [Test]
        public void Test_Inside_15_return_FIZZBUZZ()
        {
            //arrange
            const int parameter = 15;

            //act
            var current = _fizzBuzzConverter.Convert(parameter);

            //assert
            Assert.AreEqual("FIZZBUZZ", current);
        }


    }
}