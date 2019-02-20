using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Internal;
using Calculator;

namespace CalculatorUnitTest
{
        [TestFixture]
        public class CalculatorUnitTest
        {
            private Calculator.Calculator uut;

           [SetUp]
           public void Setup()
            {
              uut = new Calculator.Calculator();
            }
    


        //Test add With Different Values
            [TestCase(2,4,6)]
            [TestCase(-2,4,2)]
            [TestCase(-4,-4,-8)]
            public void Test_add_WithDifferentValues(double a, double b, double result)
            {
            Assert.That(uut.Add(a, b), Is.EqualTo(result));
            }



        //Test overload add
            [TestCase(1, 5)]
            [TestCase(10, 14)]
            [TestCase(-10, -6)]

            public void Ted_add_WithDifferentValuesAndAccumulator(int a, int result)
            {

                uut.Add(2 + 2); //accumulator = 4
                Assert.That(uut.Add(a), Is.EqualTo(result));
            }



        //Test Subtract With Different Values
            [TestCase(2,4,-2)]
            [TestCase(4,5,-1)]
            [TestCase(-2,-2,0)]
            public void Ted_Subtract_WithDifferentValues(double a, double b, double result)
            {
            Assert.That(uut.Subtract(a, b), Is.EqualTo(result));
            }


        //Test subtract overload
            [TestCase(2, -2)]
            [TestCase(-2, -6)]
            [TestCase(10, 6)]
            public void Ted_Subtract_WithDifferentValuesAndAccumulator4(double d, double result)
            {
                uut.Add(2 + 2); //accumulator = 4
                Assert.That(uut.Subtract(d), Is.EqualTo(result));
            }



        //Test Multiply with different values 
            [TestCase(5,5,25)]
            [TestCase(5,-5,-25)]
            [TestCase(-5, -5, 25)]
            public void Ted_Multiply_WithDifferentValues(double a, double b, double result)
            {
                Assert.That(uut.Multiply(a, b), Is.EqualTo(result));
            }



        //Test multiply overload
            [TestCase(2, 8)]
            [TestCase(-2, -8)]
            [TestCase(10, 40)]
            public void Test_Multiply_WithDifferentValuesAndAccumulator4(double a, double result)
            {
                uut.Add(2 + 2);
                Assert.That(uut.Multiply(a), Is.EqualTo(result));
            }


        //Test power With different values
            [TestCase(2,2,4)]
            [TestCase(2,5,32)]
            [TestCase(2,-3,0.125)]
            public void Test_Power_WithDifferentValues(double x, double exp, double result)
            {
            Assert.That(uut.Power(x, exp), Is.EqualTo(result));
            }

        //Test power overload
            [TestCase(2, 16)]
            [TestCase(0, 0)]
            [TestCase(-2, 16)]
            public void Test_Power_WithDifferntValuesAndAccumulator4(double a, double result)
            {
                uut.Add(2 + 2);
                Assert.That(uut.Power(a), Is.EqualTo(result));
            }
            // hvis der skal ingå en acceptabel varriabel kan kan skrive(resultat).within(0.01));


        //Test divide with different values 
            [TestCase(4,2,2)]
            [TestCase(8,2,4)]
            [TestCase(-4,2,-2)]
            [TestCase(-4, -2, 2)]
            public void Test_Divide_WithDifferentValues(double dividend, double divisor, double result)
            {
                Assert.That(uut.Divide(dividend, divisor), Is.EqualTo(result));
            }


        //Test DivideByZeroException
            [TestCase(10, 0)]
            [TestCase(5, 0)]
            [TestCase(0, 0)]
            public void Divide_DivideByZero_ResultIsException(double dividend, double divisor)
            {
                Assert.Throws<DivideByZeroException>(() => uut.Divide(dividend, divisor));
            }
        
        //Test fresh Accumulator
            [TestCase()]
            public void Test_Fresh_Accumulator()
            {
                Assert.That(uut.Accumulator, Is.EqualTo(0));
            }

        //Test accumulator after adding 
            [TestCase(2, 2, 4)]
            [TestCase(3, 3, 6)]
            public void Test_Accumulator_After_Add(double a, double b, double c)
            {
                uut.Add(a, b);
                Assert.That(uut.Accumulator, Is.EqualTo(c));
            }

        //Test Clear
            [TestCase()]
            public void Test_Clear_ResultIsZero()
            {
                uut.Clear();
                Assert.That(uut.Accumulator, Is.EqualTo(0));
            }
            [TestCase()]
            public void Test_Clear_IsResultZeroAfterAccumulate()
            {
                uut.Add(2, 2);
                uut.Clear();
                Assert.That(uut.Accumulator, Is.EqualTo(0));
            }















    }
}
