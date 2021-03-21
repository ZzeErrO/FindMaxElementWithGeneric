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
        public void MaxInteger_At2st_Position()
        {
            //AAA
            //Arrange
            int[] array = { 5, 20, 1 };
            //Act
            int result = Program.MaximumIntegerNumber(array[0], array[1], array[2]);
            //Assert
            Assert.AreEqual(20, result);

        }

     
    }
}
