using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ZealandBioXp
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ListTest()
        {
            var expectedtresult = 3;
            var classUnderTest = new Films();
            var actualresult = classUnderTest.GetAll();
            Assert.AreEqual(expectedtresult, actualresult.Count);
        }

        [TestMethod]
        public void SpecielDayTest()
        {
            var expectedtresult = 3;
            var classUnderTest = new Films();
            var actualresult = classUnderTest.GetAll();
            Assert.AreEqual(expectedtresult, actualresult.Count);
            expectedtresult = 1;
            actualresult = classUnderTest.GetFromDate(DateTime.Today.AddDays(2));
            Assert.AreEqual(expectedtresult, actualresult.Count);
            expectedtresult = 3;
            actualresult = classUnderTest.GetFromDate(DateTime.Today);
            Assert.AreEqual(expectedtresult, actualresult.Count);
        }

        [TestMethod]
        public void DateCheckTest()
        {
            var expectedtresult = 3;
            var classUnderTest = new Films();
            var actualresult = classUnderTest.GetAll();
            Assert.AreEqual(expectedtresult, actualresult.Count);
            List<DateTime> expectedtresult2 = new List<DateTime>();
            expectedtresult2.Add(DateTime.Today);
            expectedtresult2.Add(DateTime.Today.AddDays(2));
            List<DateTime> actualresult2 = classUnderTest.CheckDates("film 1");
            Assert.AreEqual(expectedtresult2.Count, actualresult2.Count);
        }

        [TestMethod]
        public void CreateDeleteTest()
        {
            var expectedtresult = 3;
            var classUnderTest = new Films();
            var actualresult = classUnderTest.GetAll();
            Assert.AreEqual(expectedtresult, actualresult.Count);

            bool actualresult2 = classUnderTest.Create(new Films("testfilm", "test sal", TimeSpan.FromHours(1.5),
                new List<DateTime>() {DateTime.Today.AddDays(10)}));
            bool expectedresult2 = true;
            Assert.AreEqual(expectedresult2, actualresult2);
            Films actualresult3 = classUnderTest.Delete("testfilm");
            string expectedresult3 = "testfilm";
            Assert.AreEqual(expectedresult3, actualresult3.Title);
        }

        [TestMethod]
        public void DatetimeUpdateTest()
        {
            var expectedtresult = 3;
            var classUnderTest = new Films();
            var actualresult = classUnderTest.GetAll();
            Assert.AreEqual(expectedtresult, actualresult.Count);
            bool expectedresult2 = true;
            var actualresult2 = classUnderTest.CreateDate("film 1", DateTime.Today.AddDays(23));
            Assert.AreEqual(expectedresult2, actualresult2);
            Assert.AreEqual(3, classUnderTest.CheckDates("film 1").Count);
            bool expectedresult3 = true;
            var actualresult3 = classUnderTest.DeleteDate("film 1", DateTime.Today.AddDays(23));
            Assert.AreEqual(expectedresult3, actualresult3);
            Assert.AreEqual(2, classUnderTest.CheckDates("film 1").Count);
        }
    }
}