using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EvaluationSampleCode;

namespace EvaluationSampleCodeTest
{
    [TestClass]
    public class BaptizmTest
    {
        private ClergyMember _creator;
        private Baptizm _baptizm;

        [TestInitialize]
        public void Init()
        {
            _creator = new ClergyMember { IsPriest = true };
            _baptizm = new Baptizm(_creator);
        }

        [TestMethod]
        public void CanBeBaptizedBy_WithPriest_ReturnsTrue()
        {
            var priest = new ClergyMember { IsPriest = true, IsPope = false };
            Assert.IsTrue(_baptizm.CanBeBaptizedBy(priest));
        }

        [TestMethod]
        public void CanBeBaptizedBy_WithPope_ReturnsTrue()
        {
            var pope = new ClergyMember { IsPriest = false, IsPope = true };
            Assert.IsTrue(_baptizm.CanBeBaptizedBy(pope));
        }

        [TestMethod]
        public void CanBeBaptizedBy_WithNeitherPriestNorPope_ReturnsFalse()
        {
            var notClergy = new ClergyMember { IsPriest = false, IsPope = false };
            Assert.IsFalse(_baptizm.CanBeBaptizedBy(notClergy));
        }
    }
}
