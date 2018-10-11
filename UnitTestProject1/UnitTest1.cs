using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
//using 
using System.Diagnostics;

namespace MathMethodsTests
{
    [TestClass]
    public class StringlibraryTests
    {
        
        #region EuclidAlgorithmTest
        [TestMethod]
        public void EuclidAlgorithmTestMethod()
        {
            int first = 789;
            int second = 6;
            
            Assert.AreEqual(1, Stringlibrary.EuclidAlgorithm(first, second, ));
        }

       

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void ExeptionEuclidAlgorithmTestMethod()
        {
            int[] numbers = null;
            Stringlibrary.EuclidAlgorithm(numbers);
        }
        #endregion

        #region BinaryEuclidAlgorithmTest
        [TestMethod]
        public void BinaryEuclidAlgorithmTestMethod1()
        {
            int first = 7435446;
            int second = 7;
           
            Assert.AreEqual(1, Stringlibrary.BinaryEuclidAlgorithm(first, second));
        }

       

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void ExeptionBinaryEuclidAlgorithmTestMethod()
        {
            int[] numbers = null;
            Stringlibrary.BinaryEuclidAlgorithm(numbers);
        }
        #endregion

        #region NewtonMethodTest
        [TestMethod]
        public void NewtonMethodTestMethod1()
        {
            double number = 156;
            int power = 3;
            double accuracy = 0;
            Assert.AreEqual(8, StringlibraryTests.Radical(number, power, accuracy));
        }

        
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ExeptionNewtonMethodTestMethod()
        {
            double number = -1030;
            int power = 2;
            double accurancy = 0;
            Stringlibrary.Radical(number, power, accurancy);
        }

        
        #endregion
    }
}