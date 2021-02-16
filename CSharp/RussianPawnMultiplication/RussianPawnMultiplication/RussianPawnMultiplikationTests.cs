using System.Collections.Generic;
using NUnit.Framework;

namespace RussianPawnMultiplication
{
    public class RussianPawnMultiplikationTests
    {
        private RussianPawnMultiplikationCalculator _russianPawnMultiplikationCalculator;

        [SetUp]
        public void Setup()
        {
            _russianPawnMultiplikationCalculator = new RussianPawnMultiplikationCalculator();
        }

        [Test]
        public void Test_Initialize()
        {
            Assert.IsNotNull(_russianPawnMultiplikationCalculator);
        }

        [Test]
        public void Test_left_0_right_0_return_0()
        {
            
            var result = _russianPawnMultiplikationCalculator.Calculate(0, 0);
            Assert.AreEqual(0,result);
        }

        [Test]
        public void Test_left_1_right_1_return_1()
        {
            var result = _russianPawnMultiplikationCalculator.Calculate(1, 1);
            Assert.AreEqual(1, result);
        }

        [Test]
        public void Test_left_2_right_1_return_2()
        {
            var result = _russianPawnMultiplikationCalculator.Calculate(2, 1);
            Assert.AreEqual(2, result);
        }

        [Test]
        public void Test_left_1_right_2_return_2()
        {
            var result = _russianPawnMultiplikationCalculator.Calculate(1, 2);
            Assert.AreEqual(2, result);
        }

        [Test]
        public void Test_left_2_right_2_return_4()
        {
            var result = _russianPawnMultiplikationCalculator.Calculate(2, 2);
            Assert.AreEqual(4, result);
        }

        [Test]
        public void Test_left_3_right_3_return_9()
        {
            var result = _russianPawnMultiplikationCalculator.Calculate(3, 3);
            Assert.AreEqual(9, result);
        }

        [Test]
        public void Test_left_47_right_42_return_1974()
        {
            var result = _russianPawnMultiplikationCalculator.Calculate(47, 42);
            Assert.AreEqual(1974, result);
        }
    }

    public class RussianPawnMultiplikationCalculator
    {
        public int Calculate(int left, int right)
        {
            if (left == 0 || right == 0)
            {
                return 0;
            }

            if (left==1)
            {
                return right;
            }

            if (right==1)
            {
                return left;
            }

            var lefts = new List<int> {left};
            var rights = new List<int> {right};

            while (true)
            {
                left = left / 2;
                lefts.Add(left);

                right = right * 2;
                rights.Add(right);

                if (left == 1)
                {
                    break;
                }
            }

            for (var i = 0; i < lefts.Count; i++)
            {
                if (lefts[i]%2==0)
                {
                    rights[i] = 0;
                }
            }

            var result = 0;
            foreach (var temp in rights)
            {
                result += temp;
            }
            return result;
        }
    }
}