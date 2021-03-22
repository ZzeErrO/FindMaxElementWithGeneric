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
            //MaximumNumber<int> maximum = new MaximumNumber<int>();
            int[] array = { 5, 2, 1};
            //Act
            int result = MaximumNumber<int>.MaxNum( array[0], array[1], array[2] );
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
            int result = MaximumNumber<int>.MaxNum(array[0], array[1], array[2]);
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
            int result = MaximumNumber<int>.MaxNum(array[0], array[1], array[2]);
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
            double result = MaximumNumber<double>.MaxNum(array[0], array[1], array[2]);
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
            double result = MaximumNumber<double>.MaxNum(array[0], array[1], array[2]);
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
            double result = MaximumNumber<double>.MaxNum(array[0], array[1], array[2]);
            //Assert
            Assert.AreEqual(1011.1235, result);

        }

        [TestMethod]
        public void MaxString_At1st_Position()
        {
            //AAA
            //Arrange
            string[] array = { "11", "2", "2" };
            //Act
            string result = MaximumNumber<string>.MaxNum(array[0], array[1], array[2]);
            //Assert
            Assert.AreEqual("11", result);
        }

        [TestMethod]
        public void MaxString_At2nd_Position()
        {
            //AAA
            //Arrange
            string[] array = { "1", "22", "12" };
            //Act
            string result = MaximumNumber<string>.MaxNum(array[0], array[1], array[2]);
            //Assert
            Assert.AreEqual("22", result);
        }

        [TestMethod]
        public void MaxString_At3rd_Position()
        {
            //AAA
            //Arrange
            string[] array = { "10", "25", "30" };
            //Act
            string result = MaximumNumber<string>.MaxNum(array[0], array[1], array[2]);
            //Assert
            Assert.AreEqual("30", result);

        }
    }
}
