using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TechJobsTests
{
    [TestClass]
    public class JobTests
    {
        [TestMethod]// #1 test Id constructor
        public void TestSettingJobId()
        {
            Job test_job1 = new Job();
            Job test_job2 = new Job();
            Assert.IsTrue(test_job1.Id != test_job2.Id && test_job2.Id == test_job1.Id +1);
        }


        [TestMethod]// #2 test full constructor
        public void TestJobConstructorSetsAllFields()
        {
            Job test_job3 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Assert.AreEqual("Product tester", test_job3.Name);
            Assert.AreEqual("ACME",test_job3.EmployerName.Value);
            Assert.AreEqual("Desert", test_job3.EmployerLocation.Value);
            Assert.AreEqual("Quality control", test_job3.JobType.Value);
            Assert.AreEqual("Persistence", test_job3.JobCoreCompetency.Value);
        }


        [TestMethod]// #3 test Equals() method
        public void TestJobsForEquality()
        {
            Job test_job4 = new Job("Web Developer", new Employer("LaunchCode"), new Location("St. Louis"), new PositionType("Front-end developer"), new CoreCompetency("JavaScript"));
            Job test_job5 = new Job("Web Developer", new Employer("LaunchCode"), new Location("St. Louis"), new PositionType("Front-end developer"), new CoreCompetency("JavaScript"));
            Assert.IsFalse(test_job4.Equals(test_job5));
        }

        [TestMethod]// #4 test ToString() method/TDD build
        public void TestToStringMethod()
        {
            Job test_job6 = new Job("Ice cream tester", new Employer("fake"), new Location("Home"), new PositionType("UX"), new CoreCompetency("Tasting ability"));
            Assert.IsTrue(test_job6.ToString() == "ID: " +6+ " " + "\nName: Ice cream tester \nEmployer: fake \nLocation: Home \nPosition Type: UX \nCore Competency: Tasting ability \n");
        }

        [TestMethod]// #5 test ToString() method conditional/TDD build
        public void TestToStringMethodCondition()
        {
            Job test_job7 = new Job("Ice cream tester", new Employer(""), new Location("Home"), new PositionType("UX"), new CoreCompetency("Tasting ability"));
            Assert.IsTrue(test_job7.ToString() == "ID: " + 7 + " " + "\nName: Ice cream tester \nEmployer: Data not available \nLocation: Home \nPosition Type: UX \nCore Competency: Tasting ability \n");
        }

        [TestMethod]// #6 test ToString() for missing data/TDD build
        public void TestMissingFields()
        {
            Job test_job8 = new Job("", new Employer(""), new Location("Home"), new PositionType("UX"), new CoreCompetency("Tasting ability"));
            Assert.IsTrue(test_job8.ToString() == "ID: " + 8 + " " + "\nName: Data not available \nEmployer: Data not available \nLocation: Home \nPosition Type: UX \nCore Competency: Tasting ability \n");
        }

        [TestMethod]// #7 test ToString() Id only/TDD build
        public void TestHasIdOnly()
        {
            Job test_job9 = new Job("", new Employer(""), new Location(""), new PositionType(""), new CoreCompetency(""));
            Assert.IsTrue(test_job9.ToString() == "ID: " + 9 + " " + "\nOOPS! This job does not seem to exist.");
        }

    }
}
