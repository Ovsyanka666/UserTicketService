using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace UserTicketService.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void SubstructionMustBeCorrect()
        {
            var calculator = new Calculator();
            Assert.True(calculator.Substraction(100, 10) == 90);
        }

        [Fact]
        public void DivisionMustBeCorrect()
        {
            var calc = new Calculator();
            Assert.True(calc.Division(140, 7) == 20);
        }

        [Fact]
        public void DivisionByZeroMustReturnException()
        {
            var calc = new Calculator();
            Assert.Throws<DivideByZeroException>(() => calc.Division(100, 0));
        }
    }
}
