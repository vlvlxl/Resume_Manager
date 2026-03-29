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
    public class ResumeTests
    {
        [TestMethod]
        public void Constructor_WithValidData_InitializesProperties()
        {
            var name = "Иван Иванов";
            var contact = "ivan@email.com";
            var objective = "Ищу работу";

            var resume = new Resume(name, contact, objective);

            Assert.AreEqual(name, resume.Name);
            Assert.AreEqual(contact, resume.ContactInfo);
            Assert.AreEqual(objective, resume.Objective);
            Assert.IsNotNull(resume.Skills);
            Assert.IsNotNull(resume.WorkExperiences);
            Assert.IsNotNull(resume.Educations);
            Assert.AreEqual(0, resume.Skills.Count);
            Assert.AreEqual(0, resume.WorkExperiences.Count);
            Assert.AreEqual(0, resume.Educations.Count);
        }

        [TestMethod]
        public void AddSkill_AddsSkillToList()
        {
            var resume = new Resume("Test", "test@test.com", "Objective");
            var skill = "C#";

            resume.AddSkill(skill);

            Assert.AreEqual(1, resume.Skills.Count);
            Assert.AreEqual(skill, resume.Skills[0]);
        }

        [TestMethod]
        public void AddWorkExperience_AddsExperienceToList()
        {
            var resume = new Resume("Test", "test@test.com", "Objective");
            var position = "Developer";
            var company = "Company";

            resume.AddWorkExperience(position, company, "2023-2024", "Description");

            Assert.AreEqual(1, resume.WorkExperiences.Count);
            Assert.AreEqual(position, resume.WorkExperiences[0].Position);
            Assert.AreEqual(company, resume.WorkExperiences[0].Company);
        }

        [TestMethod]
        public void AddEducation_AddsEducationToList()
        {
            var resume = new Resume("Test", "test@test.com", "Objective");
            var institution = "МГУ";
            var degree = "Бакалавр";

            resume.AddEducation(institution, degree, "2020-2024");

            Assert.AreEqual(1, resume.Educations.Count);
            Assert.AreEqual(institution, resume.Educations[0].Institution);
            Assert.AreEqual(degree, resume.Educations[0].Degree);
        }

        [TestMethod]
        public void AddSkill_MultipleSkills_AddsAll()
        {
            var resume = new Resume("Test", "test@test.com", "Objective");

            resume.AddSkill("C#");
            resume.AddSkill("Git");
            resume.AddSkill("SQL");

            Assert.AreEqual(3, resume.Skills.Count);
        }
    }
}