using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CalculatorUnitTest
{
        [TestFixture]
        public class CalculatorUnitTest
        {
            [Test]
            public void Add_Add2to4_Returns6()
            {
                var uut = new Calculator.Calculator();

                Assert.That(uut.Add(2, 4), Is.EqualTo(6));
            }

            [Test]
            public void Add_AddMinus2and4_Returns2()
            {
                var uut = new Calculator.Calculator();

                Assert.That(uut.Add(-2, 4), Is.EqualTo(2));
            }

            [Test]
            public void Subtract_Subtract2from4_Returns2()
            {
                var uut = new Calculator.Calculator();

                Assert.That(uut.Subtract(4, 2), Is.EqualTo(2));
            }

            [Test]
            public void Subtract_Subtract5from4_ReturnsNegative1()
            {
                var uut = new Calculator.Calculator();

                Assert.That(uut.Subtract(4, 5), Is.EqualTo(-1));
            }

            [Test]
            public void Multiply_Multiply5times5_Return25()
            {
                var uut = new Calculator.Calculator();

                Assert.That(uut.Multiply(5, 5), Is.EqualTo(25));
            }


            [Test]
            public void Multiply_Multiply5timesNegative5_ReturnNegative25()
            {
                var uut = new Calculator.Calculator();

                Assert.That(uut.Multiply(5, -5), Is.EqualTo(-25));
            }

            [Test]
            public void Power_Power2times2_Return4()
            {
                var uut = new Calculator.Calculator();

                Assert.That(uut.Power(2, 2), Is.EqualTo(4));
            }

            [Test]
            public void Power_Power2times5_Returns32()
            {
                var uut = new Calculator.Calculator();

                Assert.That(uut.Power(2, 5), Is.EqualTo(32));
            }

            // hvis der skal ingå en acceptabel varriabel kan kan skrive(resultat).within(0.01));

         








    }
}
