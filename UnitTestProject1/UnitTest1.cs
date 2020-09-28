using Microsoft.Extensions.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NFluent;
using RepositoryTest.Models;
using RepositoryTest.Repository;
using System.Collections.Generic;
using System.IO;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        public void TestMethod1()
        {
            IConfigurationBuilder builder = new ConfigurationBuilder();
            var dburl = TestContext.Properties["JsonUrl"].ToString();
            Check.That(dburl).IsNotNull();
            builder.AddJsonFile(dburl);
            IConfigurationRoot config = builder.Build();
            IGradesRepository gradesRepository = new GradesRepository(config);
            IEnumerable<Grades> grades = gradesRepository.GetGrades();
            Check.That(grades).IsNotNull();
        }
    }
}
