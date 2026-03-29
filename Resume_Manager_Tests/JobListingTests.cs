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
    public class JobListingTests
    {
        [TestMethod]
        public void Constructor_SetsAllProperties()
        {
            var title = "Developer";
            var company = "TechCorp";
            var description = "Write code";
            var requirements = "C#, Git";

            var job = new JobListing(title, company, description, requirements);

            Assert.AreEqual(title, job.JobTitle);
            Assert.AreEqual(company, job.Company);
            Assert.AreEqual(description, job.Description);
            Assert.AreEqual(requirements, job.Requirements);
        }

        [TestMethod]
        public void ToString_ReturnsFormattedString()
        {
            var job = new JobListing("Developer", "TechCorp", "Code", "C#");

            var result = job.ToString();

            StringAssert.Contains(result, "Developer");
            StringAssert.Contains(result, "TechCorp");
        }
    }
}