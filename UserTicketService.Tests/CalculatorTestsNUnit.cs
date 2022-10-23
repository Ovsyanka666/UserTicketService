using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserTicketService.Tests
{
    [TestFixture]
    class CalculatorTestsNUnit
    {
        [Test]
        public void SubstractionMustBeCorrect()
        {
            var calc = new Calculator();
            Assert.That(calc.Substraction(140, 7) == 133);
        }

        [Test]
        public void DivisionMustBeCorrect()
        {
            var calc = new Calculator();
            Assert.That(calc.Division(140, 7) == 20);
        }

        [Test]
        public void DivisionByZeroMustReturnException()
        {
            var calc = new Calculator();
            Assert.Throws<DivideByZeroException>(() => calc.Division(100, 0));
        }

    }
}
