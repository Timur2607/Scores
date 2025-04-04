using Microsoft.VisualStudio.TestTools.UnitTesting;
using Scores;
using System;
using System.Windows;


namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {

        [TestInitialize]
        public void Setup()
        {
            window = new MainWindow();
        }

        private MainWindow window;
        [TestMethod]
        public void GetGrade_ShouldReturnExcellent()
        {
            string result = window.GetGrade(56);
            Assert.AreEqual("5 (отлично)", result);
        }

        [TestMethod]
        public void GetGrade_ShouldReturnGood()
        {
            string result = window.GetGrade(40);
            Assert.AreEqual("4 (хорошо)", result);
        }

        [TestMethod]
        public void GetGrade_ShouldReturnSatisfactory()
        {
            string result = window.GetGrade(20);
            Assert.AreEqual("3 (удовлетворительно)", result);
        }

        [TestMethod]
        public void GetGrade_ShouldReturnUnsatisfactory()
        {
            string result = window.GetGrade(10);
            Assert.AreEqual("2 (неудовлетворительно)", result);
        }

    }
}
