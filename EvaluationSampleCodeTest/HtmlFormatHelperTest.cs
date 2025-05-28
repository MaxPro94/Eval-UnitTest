using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EvaluationSampleCode;


namespace EvaluationSampleCodeTest
{

    [TestClass]
    public class HtmlFormatHelperTest
    {

        private HtmlFormatHelper _htmlformathelper;

        [TestInitialize]
        public void Init()
        {
            _htmlformathelper = new HtmlFormatHelper();
        }

        [TestMethod]
        public void GetStrongFormat_WithString_ReturnStringStrong()
        {

            var stringToStrong = "Holla";

            var formatText = _htmlformathelper.GetStrongFormat(stringToStrong);

            Assert.AreEqual("<strong>Holla</strong>", formatText);
        }

        [TestMethod]
        public void GetItalicFormat_WithString_ReturnStringItalic()
        {

            var stringToItalic = "Holla";

            var formatText = _htmlformathelper.GetItalicFormat(stringToItalic);

            Assert.AreEqual("<i>Holla</i>", formatText);
        }

        [TestMethod]
        public void GetFormattedListElements_WithString_ReturnList()
        {
            var arrayToList = new List<string> { "Holla", "Holla2", "Holla3" };
            var formatText = _htmlformathelper.GetFormattedListElements(arrayToList);
            Assert.AreEqual("<ul><li>Holla</li><li>Holla2</li><li>Holla3</li></ul>", formatText);

        }
    }
}
