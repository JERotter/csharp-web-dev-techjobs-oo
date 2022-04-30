using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TechJobsTests
{
    [TestClass]
    public class JobTests
    {
        [TestMethod]//test Id constructor
        public void TestSettingJobId()
        {
            Job test_job1 = new Job();
            Job test_job2 = new Job();
            Assert.IsTrue(test_job1.Id != test_job2.Id && test_job2.Id == test_job1.Id +1);
        }


        [TestMethod]//test full constructor
        public void TestJobConstructorSetsAllFields()
        {
            Job test_job3 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Assert.AreEqual("Product tester", test_job3.Name);
            Assert.AreEqual("ACME",test_job3.EmployerName.Value);
            Assert.AreEqual("Desert", test_job3.EmployerLocation.Value);
            Assert.AreEqual("Quality control", test_job3.JobType.Value);
            Assert.AreEqual("Persistence", test_job3.JobCoreCompetency.Value);
        }


        [TestMethod]//test Equals() method
        public void TestJobsForEquality()
        {
            Job test_job4 = new Job("Web Developer", new Employer("LaunchCode"), new Location("St. Louis"), new PositionType("Front-end developer"), new CoreCompetency("JavaScript"));
            Job test_job5 = new Job("Web Developer", new Employer("LaunchCode"), new Location("St. Louis"), new PositionType("Front-end developer"), new CoreCompetency("JavaScript"));
            Assert.IsFalse(test_job4.Equals(test_job5));
        }

    }
}
