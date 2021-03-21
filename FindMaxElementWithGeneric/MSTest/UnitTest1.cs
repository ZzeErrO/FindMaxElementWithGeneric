using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FindMaxElement;

namespace MSTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void MaxInteger_At1st_Position()
        {
            //AAA
            //Arrange
            int[] array = { 5, 2, 1};
            //Act
            int result = Program.MaximumIntegerNumber(array[0], array[1], array[2]);
            //Assert
            Assert.AreEqual(5,result);
            
        }

        [TestMethod]
        public void MaxInteger_At2nd_Position()
        {
            //AAA
            //Arrange
            int[] array = { 5, 20, 1 };
            //Act
            int result = Program.MaximumIntegerNumber(array[0], array[1], array[2]);
            //Assert
            Assert.AreEqual(20, result);

        }

        [TestMethod]
        public void MaxInteger_At3rd_Position()
        {
            //AAA
            //Arrange
            int[] array = { 5, 20, 100 };
            //Act
            int result = Program.MaximumIntegerNumber(array[0], array[1], array[2]);
            //Assert
            Assert.AreEqual(100, result);

        }

        [TestMethod]
        public void MaxDouble_At1st_Position()
        {
            //AAA
            //Arrange
            double[] array = { 50.2, 20.25, 10.1235 };
            //Act
            double result = Program.MaximumDoubleNumber(array[0], array[1], array[2]);
            //Assert
            Assert.AreEqual(50.2, result);

        }

        [TestMethod]
        public void MaxDouble_At2nd_Position()
        {
            //AAA
            //Arrange
            double[] array = { 50.2, 200.25, 10.1235 };
            //Act
            double result = Program.MaximumDoubleNumber(array[0], array[1], array[2]);
            //Assert
            Assert.AreEqual(200.25, result);

        }

        [TestMethod]
        public void MaxDouble_At3rd_Position()
        {
            //AAA
            //Arrange
            double[] array = { 50.2, 200.25, 1011.1235 };
            //Act
            double result = Program.MaximumDoubleNumber(array[0], array[1], array[2]);
            //Assert
            Assert.AreEqual(1011.1235, result);

        }

        [TestMethod]
        public void MaxString_At1st_Position()
        {
            //AAA
            //Arrange
            string[] array = { "Alpha1", "Beta", "Delta" };
            //Act
            string result = Program.MaximumStringNumber(array[0], array[1], array[2]);
            //Assert
            Assert.AreEqual("Alpha1", result);
        }

        [TestMethod]
        public void MaxString_At2nd_Position()
        {
            //AAA
            //Arrange
            string[] array = { "Alpha", "Beta22", "Delta" };
            //Act
            string result = Program.MaximumStringNumber(array[0], array[1], array[2]);
            //Assert
            Assert.AreEqual("Beta22", result);
        }

        [TestMethod]
        public void MaxString_At3rd_Position()
        {
            //AAA
            //Arrange
            string[] array = { "Alpha", "Beta", "Delta3" };
            //Act
            string result = Program.MaximumStringNumber(array[0], array[1], array[2]);
            //Assert
            Assert.AreEqual("Delta3", result);

        }
    }
}
