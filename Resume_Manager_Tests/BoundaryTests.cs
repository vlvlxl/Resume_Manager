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
    public class BoundaryTests
    {
        [TestMethod]
        public void Resume_AddSkill_WithEmptyString_AddsEmpty()
        {
            var resume = new Resume("Test", "test@test.com", "Objective");
            resume.AddSkill("");
            Assert.AreEqual(1, resume.Skills.Count);
        }

        [TestMethod]
        public void Resume_AddSkill_WithNull_AddsNull()
        {
            var resume = new Resume("Test", "test@test.com", "Objective");
            resume.AddSkill(null);
            Assert.AreEqual(1, resume.Skills.Count);
        }

        [TestMethod]
        public void WorkExperience_ToString_WithEmptyFields_ReturnsFormatted()
        {
            var exp = new WorkExperience("", "", "", "");
            var result = exp.ToString();
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Education_ToString_WithEmptyFields_ReturnsFormatted()
        {
            var edu = new Education("", "", "");
            var result = edu.ToString();
            Assert.IsNotNull(result);
        }
    }
}