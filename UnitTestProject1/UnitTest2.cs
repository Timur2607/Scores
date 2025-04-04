using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Scores;
using System.Windows;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest2
    {

        [TestInitialize]
        public void Setup()
        {
            window = new MainWindow();
        }

        private MainWindow window;
        [TestMethod]
        public void CalculateButton_Click_ShouldShowError_WhenInputIsNotNumber()
        {
            // Arrange
            var window = new MainWindow();
            window.Module1ScoreText = "abc"; // Теперь через свойство
            window.Module2ScoreText = "10";
            window.Module3ScoreText = "5";

            // Act
            window.CalculateButton_Click(null, null);

            // Assert
            Assert.AreEqual("Ошибка: введите числовые значения!", window.LastMessage);
        }

    }
}
