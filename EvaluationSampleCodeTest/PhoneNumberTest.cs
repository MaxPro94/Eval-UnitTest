using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EvaluationSampleCode;

namespace EvaluationSampleCodeTest
{
    [TestClass]
    public class PhoneNumberTest
    {

        [TestMethod]
        public void Parse_WithValidPhoneNumber_ReturnsCorrectParts()
        {
            var phone = PhoneNumber.Parse("0123456789");
            Assert.AreEqual("012", phone.Area);
            Assert.AreEqual("345", phone.Major);
            Assert.AreEqual("6789", phone.Minor);
        }

        [TestMethod]
        public void ToString_WithValidPhoneNumber_ReturnsExpectedFormat()
        {
            var phone = PhoneNumber.Parse("0123456789");
            Assert.AreEqual("(012)345-6789", phone.ToString());
        }

        [TestMethod]
        public void Parse_WithBlank_ThrowsArgumentException()
        {
            Assert.ThrowsException<ArgumentException>(() => PhoneNumber.Parse(""));
            Assert.ThrowsException<ArgumentException>(() => PhoneNumber.Parse("    "));
            Assert.ThrowsException<ArgumentException>(() => PhoneNumber.Parse(null));
        }

        [TestMethod]
        public void Parse_WithWrongLength_ThrowsArgumentException()
        {
            Assert.ThrowsException<ArgumentException>(() => PhoneNumber.Parse("01234"));
            Assert.ThrowsException<ArgumentException>(() => PhoneNumber.Parse("01234567890"));
        }
    }
}