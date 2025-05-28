using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EvaluationSampleCode;

namespace EvaluationSampleCodeTest
{
    [TestClass]
    public class MathOperationsTests
    {
        private MathOperations _mathoperation;

        [TestInitialize]
        public void Init()
        {
            _mathoperation = new MathOperations();
        }


        [TestMethod]
        [DataRow(30, 10, 20)]
        [DataRow(50, 25, 25)]
        [DataRow(7, 3, 4)]
        public void SubStract_WithNumber_ReturnInt(int numberOne, int numberTwo, int expectedResult)
        {
            Assert.AreEqual(expectedResult, _mathoperation.Subtract(numberOne, numberTwo));
        }

        [TestMethod]
        public void SubStract_WithNumberOneLittleThanNumberTwo_ThrowsArgumentException()
        {

            Assert.ThrowsException<ArgumentException>(() => _mathoperation.Subtract(1, 5));
        }
        
        [TestMethod]
        public void SubStract_WithNumberOneTooHight_ThrowsArgumentException()
        {

            Assert.ThrowsException<ArgumentException>(() => _mathoperation.Subtract(1200, 3600));
        }


        [TestMethod]
        [DataRow(2, "Red")]
        [DataRow(3, "Blue")] 
        [DataRow(0, "Red")]
        public void GetColorFromOddsNumber_WithVariousPositiveNumbers_ReturnsString(int number, string expectedResult)
        {

            Assert.AreEqual(expectedResult, _mathoperation.GetColorFromOddsNumber(number));
        }

        [TestMethod]
        public void GetColorFromOddsNumber_WithNegativeNumber_ThrowsArgumentException()
        {

            Assert.ThrowsException<ArgumentException>(() => _mathoperation.GetColorFromOddsNumber(-1));
        }

    }
}

