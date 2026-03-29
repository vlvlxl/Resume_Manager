using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Resume_Manager;

namespace Resume_Manager_Tests
{
    [TestClass]
    public class EducationTests
    {
        [TestMethod]
        public void Constructor_SetsAllProperties()
        {
            var institution = "МГУ";
            var degree = "Бакалавр";
            var period = "2020-2026";

            var education = new Education(institution, degree, period);

            Assert.AreEqual(institution, education.Institution);
            Assert.AreEqual(degree, education.Degree);
            Assert.AreEqual(period, education.Period);
        }

        [TestMethod]
        public void ToString_ReturnsFormattedString()
        {
            var education = new Education("МГУ", "Бакалавр", "2020-2024");

            var result = education.ToString();

            StringAssert.Contains(result, "МГУ");
            StringAssert.Contains(result, "Бакалавр");
        }
    }
}