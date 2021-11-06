using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using myApps;

namespace MyTest
{
    [TestFixture]
    public class TDDTestCalculation 
    {
        [Test]
        public void Calculator_MultiplicationT()
        {
            Calculation calculation = new Calculation();

            Assert.AreEqual(12, calculation.SI(3, 2, 2));
            Assert.AreEqual(1220, calculation.SI(5, 122, 2));


        }

        [Test]
        public void Calculator_Division()
        {
            Calculation calculation = new Calculation();
            Assert.AreEqual(3, calculation.Di( 6, 2));
            Assert.AreEqual(-9999, calculation.Di(20, 0));
            Assert.AreEqual(0, calculation.Di(8, 0));
        }

       


    }
}
