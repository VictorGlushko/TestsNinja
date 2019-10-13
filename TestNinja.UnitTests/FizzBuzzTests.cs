using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    class FizzBuzzTests
    {
        [Test]
        [TestCase(15, "FizzBuzz")]
        [TestCase(3, "Fizz")]
        [TestCase(20, "Buzz")]
        [TestCase(4, "4")]
        public void FizzBuzz_Check_Return(int a, string expectedResult)
        {

            var result = FizzBuzz.GetOutput(a);

            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}
