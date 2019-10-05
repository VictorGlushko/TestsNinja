﻿using NUnit.Framework;
using TestNinja.Fundamentals;


namespace TestNinja.UnitTests
{
    [TestFixture]
    class MathTest
    {

        //SetUp
        //TrearDown
        private Math _math;

        [SetUp]
        public void SetUp()
        {
            _math = new Math();
        }


        [Test]
        public void Add_WhenCalled_ReturnTheSumOfArguments()
        {
        

            var result =  _math.Add(1, 2);

            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        [TestCase(1, 2, 2)]
        [TestCase(2, 1, 2)]
        [TestCase(1, 1, 1)]
        [TestCase(2, 5, 5)]
        public void Max_FirstArgumentIsGreater_ReturnTheGreaterArgument(int a, int b, int expectedResult)
        {
          

            var result = _math.Max(a, b);

            Assert.That(result, Is.EqualTo(expectedResult));
        }

    }
}
