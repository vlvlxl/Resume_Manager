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
    public class WorkExperienceTests
    {
        [TestMethod]
        public void Constructor_SetsAllProperties()
        {
            var position = "Developer";
            var company = "TechCorp";
            var period = "2023-2026";
            var description = "Developed features";

            var experience = new WorkExperience(position, company, period, description);

            Assert.AreEqual(position, experience.Position);
            Assert.AreEqual(company, experience.Company);
            Assert.AreEqual(period, experience.Period);
            Assert.AreEqual(description, experience.Description);
        }

        [TestMethod]
        public void ToString_ReturnsFormattedString()
        {
            var experience = new WorkExperience("Developer", "TechCorp", "2023-2024", "Code");

            var result = experience.ToString();

            StringAssert.Contains(result, "Developer");
            StringAssert.Contains(result, "TechCorp");
            StringAssert.Contains(result, "2023-2024");
        }
    }
}