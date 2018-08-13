using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using CIV_UnitTesting_Exercises;

namespace UnitTesting
{
    [TestFixture]
    public class Test
    {
        
        [TestCase]
        public void FibocacciRec()
        {
            var ans = RecursiveCalculations.FibocacciRec(0, 1, 3);
            Assert.AreEqual(3, ans);
        }

        [TestCase]
        public void FactorialRec()
        {
            var ans = RecursiveCalculations.FactorialRec(3, 1);
            Assert.AreEqual(6, ans);
        }

        [TestCase]
        public void FibCheck()
        {
            var ans = RecursiveCalculations.FibCheck(3);
            Assert.AreEqual(true, ans);
        }
        [TestCase]
        public void PrimeCheckRec()
        {
            var ans = RecursiveCalculations.PrimeCheckRec(27, 2);
            Assert.AreEqual(true, ans);
        }
    }

    
}
