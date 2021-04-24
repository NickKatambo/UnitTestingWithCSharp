using Microsoft.VisualStudio.TestTools.UnitTesting;
using CoreClassLibrary;
using System;

namespace CoreClassLibraryTest
{
    [TestClass]
    public class FileProcessTest
    {
        [TestMethod]
        public void FileNameDoesExist()
        {
            //Arrange
            FileProcess fp = new FileProcess();
            bool fromCall;

            //Act
            fromCall = fp.FileExists(@"C:\Yann\Learning\CSharp\UnitTestingWithCSharp\TestFileCSharp.txt");

            //Assert
            Assert.IsTrue(fromCall);

        }

        [TestMethod]
        public void FileNameDoesNotExist()
        {
            //Arrange
            FileProcess fp = new FileProcess();
            bool fromCall;

            //Act
            fromCall = fp.FileExists(@"C:\Yann\Learning\CSharp\UnitTestingWithCSharp\CSharp.txt");

            //Assert
            Assert.IsFalse(fromCall);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void FileNameNullOrEmpty_UsingAttribute()
        {
            //Arrange
            FileProcess fp = new FileProcess();

            //Assert
            fp.FileExists("");
        }

        [TestMethod]
        public void FileNameNullOrEmpty_UsingTryCatch()
        {
            // Arrange
            FileProcess fp = new FileProcess();

            // Act
            try
            {
                fp.FileExists("");
            }
            catch (ArgumentNullException)
            {
                // Test was a success
                return;
            }

            // Fail the test
            Assert.Fail("Call to FileExists() did NOT throw an ArgumentNullException");
        }
    }
}
