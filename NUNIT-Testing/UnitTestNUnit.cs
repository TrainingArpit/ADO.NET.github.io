using System;
using NUnit.Framework;
using ClassLibraryCalc;

namespace UnitTestProjectNUnit
{                                         
 /// <summary>
//-----For Nunit[nunit , nunit test adapter]       --------For Xunit - [xunit, xunit.visual studio.runner]
/// </summary>
    //[TestFixtue
    public class UnitTestNUnit
    {
        private  Calculator calc;
        int x = 10; int y = 20;
        [SetUp]
        public void CalcSetup()
        {            
            calc = new Calculator();
            Console.Beep();
        }
        [TestCase(50, 20, 70)]//----------------------------------------for only this 
        [TestCase(40, 20)]//[theory]--- [InlinedData] is used in xunit
        [Order(1)]
        //[Ignore("Ignore Add")]
        public void TestMethodAdd(int x, int y, int z=60)
        {
            
            int r = calc.Add(x, y);
            Assert.That(z, Is.EqualTo(r));
        }
        [Test]//fact in x unit
        [Order(2)]
        public void TestMethodSubtract()
        {            
            int r = calc.Subtract(y, x);
            Assert.That(10, Is.EqualTo(r));
        }
        [Test]
        [Order(3)]
        public void TestMethodMultiply()
        {
            int r = calc.Multiply(y, x);
            Assert.That(200, Is.EqualTo(r));
        }
        [TearDown]//----[dispose]
        public void CalcTearDown()
        {
            calc = null;
            Console.Beep();
        }
       
    }
}
