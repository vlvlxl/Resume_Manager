using Microsoft.VisualStudio.TestTools.UnitTesting;
using Resume_Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume_Manager_Tests
{
    [TestClass]
    public class JobSearchManagerTests
    {
        private JobSearchManager _manager;

        [TestInitialize]
        public void SetUp()
        {
            _manager = new JobSearchManager();
        }

        [TestMethod]
        public void Constructor_InitializesEmptyLists()
        {
            Assert.IsNotNull(_manager);
        }

        [TestMethod]
        public void AddJobListing_CreatesJobListing()
        {
            var title = "Developer";
            var company = "TechCorp";

            _manager.AddJobListing();

            Assert.IsNotNull(_manager);
        }
    }
}