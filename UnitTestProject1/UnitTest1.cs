using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using VinLibrary;

namespace VinLibrary.Tests
{
    // Класс для тестирования нашего DLL для VIN
    [TestClass]
    public class VINLibraryTester
    {
        // Проверка корректного заполнения поля FullVIN в классе VIN
        [TestMethod]
        public void FullVINTest()
        {
            var vin = new VIN("2B6HB11Y8WK101340");

            Assert.AreEqual("2B6HB11Y8WK101340", vin.FullVIN);
        }

        // Проверка корректного заполнения поля WMI в классе VIN
        [TestMethod]
        public void WMITest()
        {
            var vin = new VIN("2B6HB11Y8WK101340");

            Assert.AreEqual("2B6", vin.WMI);
        }

        // Проверка корректного заполнения поля VDS в классе VIN 
        [TestMethod]
        public void VDSTest()
        {
            var vin = new VIN("2B6HB11Y8WK101340");

            Assert.AreEqual("HB11Y8", vin.VDS);
        }

        // Проверка корректного заполнения поля VIS в классе VIN
        [TestMethod]
        public void VISTest()
        {
            var vin = new VIN("2B6HB11Y8WK101340");

            Assert.AreEqual("WK101340", vin.VIS);
        }

        // Валидация VIN происходит в конструкторе класса VIN
        // Дальнейшие методы теста будут проверять различные случаи валидации

        // Проверка валидации VIN, случай c корректным VIN 
        [TestMethod]
        public void ValidationTest_CorrectVIN1()
        {
            try
            {
                var vin = new VIN("2B6HB11Y8WK101340");
            }
            catch (ArgumentException exception)
            {
                Assert.Fail($"An unexpected ArgumentException thrown on a valid VIN. Exception message: {exception.Message}");
            }
        }

        // Проверка валидации VIN, случай c корректным VIN
        [TestMethod]
        public void ValidationTest_CorrectVIN2()
        {
            try
            {
                var vin = new VIN("1NXBU4EE5AZ307274");
            }
            catch (ArgumentException exception)
            {
                Assert.Fail($"An unexpected ArgumentException thrown on a valid VIN. Exception message: {exception.Message}");
            }
        }

        // Проверка валидации VIN, случай c корректным VIN 
        [TestMethod]
        public void ValidationTest_CorrectVIN3()
        {
            try
            {
                var vin = new VIN("2GCEC19C381150488");
            }
            catch (ArgumentException exception)
            {
                Assert.Fail($"An unexpected ArgumentException thrown on a valid VIN. Exception message: {exception.Message}");
            }
        }

        // Проверка валидации VIN, случай c корректным VIN 
        [TestMethod]
        public void ValidationTest_CorrectVIN4()
        {
            try
            {
                var vin = new VIN("1XKWDR9X7RS693240");
            }
            catch (ArgumentException exception)
            {
                Assert.Fail($"An unexpected ArgumentException thrown on a valid VIN. Exception message: {exception.Message}");
            }
        }

        // Проверка валидации VIN, случай c корректным VIN 
        [TestMethod]
        public void ValidationTest_CorrectVIN5()
        {
            try
            {
                var vin = new VIN("1B7GG22Y6XS265769");
            }
            catch (ArgumentException exception)
            {
                Assert.Fail($"An unexpected ArgumentException thrown on a valid VIN. Exception message: {exception.Message}");
            }
        }


        // Проверка валидации VIN по длине, случай с некорректной длиной
        [TestMethod]
        public void ValidationTest_Length()
        {
            try
            {
                var vin = new VIN("2B6HB11Y8WK10134");

                Assert.Fail("Expected an ArgumentException to be thrown.");
            }
            catch (ArgumentException exception)
            {
                var expectedMessage = "Incorrect length of VIN.";
                Assert.AreEqual(expectedMessage, exception.Message, "Expected exception message did not match the actual exception message.");
            }
        }

        // Проверка валидации VIN по разрешенным символам, случай с некорректными(-ым) символами(-ом)
        [TestMethod]
        public void ValidationTest_LegalCharacters1()
        {
            try
            {
                var vin = new VIN("2I6HB11Y8WK101340");
                Assert.Fail("Expected an ArgumentException to be thrown.");
            }
            catch (ArgumentException exception)
            {
                var expectedMessage = "VIN contains illegal characters.";
                Assert.AreEqual(expectedMessage, exception.Message, "Expected exception message did not match the actual exception message.");
            }
        }

        // Проверка валидации VIN по разрешенным символам, случай с некорректными(-ым) символами(-ом)
        [TestMethod]
        public void ValidationTest_LegalCharacters2()
        {
            try
            {
                var vin = new VIN("2O6HB11Y8WK101340");
                Assert.Fail("Expected an ArgumentException to be thrown.");
            }
            catch (ArgumentException exception)
            {
                var expectedMessage = "VIN contains illegal characters.";
                Assert.AreEqual(expectedMessage, exception.Message, "Expected exception message did not match the actual exception message.");
            }
        }

        // Проверка валидации VIN по разрешенным символам, случай с некорректными(-ым) символами(-ом)
        [TestMethod]
        public void ValidationTest_LegalCharacters3()
        {
            try
            {
                var vin = new VIN("2Q6HB11Y8WK101340");
                Assert.Fail("Expected an ArgumentException to be thrown.");
            }
            catch (ArgumentException exception)
            {
                var expectedMessage = "VIN contains illegal characters.";
                Assert.AreEqual(expectedMessage, exception.Message, "Expected exception message did not match the actual exception message.");
            }
        }

        // Проверка валидации VIN по разрешенным символам, случай с некорректными(-ым) символами(-ом)
        [TestMethod]
        public void ValidationTest_LegalCharacters4()
        {
            try
            {
                var vin = new VIN("2!6HB11Y8WK101340");
                Assert.Fail("Expected an ArgumentException to be thrown.");
            }
            catch (ArgumentException exception)
            {
                var expectedMessage = "VIN contains illegal characters.";
                Assert.AreEqual(expectedMessage, exception.Message, "Expected exception message did not match the actual exception message.");
            }
        }

        // Проверка валидации VIN по разрешенному символу контрольной суммы, случай с некорректным символом
        [TestMethod]
        public void ValidationTest_LegalCheckSumCharacter1()
        {
            try
            {
                var vin = new VIN("2B6HB11YHWK101340");
                Assert.Fail("Expected an ArgumentException to be thrown.");
            }
            catch (ArgumentException exception)
            {
                var expectedMessage = "VIN checksum character is illegal.";
                Assert.AreEqual(expectedMessage, exception.Message, "Expected exception message did not match the actual exception message.");
            }
        }

        // Проверка валидации VIN по разрешенному символу контрольной суммы, случай с некорректным символом
        [TestMethod]
        public void ValidationTest_LegalCheckSumCharacter2()
        {
            try
            {
                var vin = new VIN("2B6HB11YAWK101340");
                Assert.Fail("Expected an ArgumentException to be thrown.");
            }
            catch (ArgumentException exception)
            {
                var expectedMessage = "VIN checksum character is illegal.";
                Assert.AreEqual(expectedMessage, exception.Message, "Expected exception message did not match the actual exception message.");
            }
        }

        // Проверка валидации VIN по значению контрольной суммы, случай с некорректной контрольной суммой
        [TestMethod]
        public void ValidationTest_CheckSum1()
        {
            try
            {
                var vin = new VIN("2B6HB11Y7WK101340");
                Assert.Fail("Expected an ArgumentException to be thrown.");
            }
            catch (ArgumentException exception)
            {
                var expectedMessage = "VIN has invalid checksum.";
                Assert.AreEqual(expectedMessage, exception.Message, "Expected exception message did not match the actual exception message.");
            }
        }

        // Проверка валидации VIN по значению контрольной суммы, случай с некорректной контрольной суммой
        [TestMethod]
        public void ValidationTest_CheckSum2()
        {
            try
            {
                var vin = new VIN("2B6HB11Y8WK10134A");
                Assert.Fail("Expected an ArgumentException to be thrown.");
            }
            catch (ArgumentException exception)
            {
                var expectedMessage = "VIN has invalid checksum.";
                Assert.AreEqual(expectedMessage, exception.Message, "Expected exception message did not match the actual exception message.");
            }
        }

        // Проверка валидации VIN по значению контрольной суммы, случай с некорректной контрольной суммой
        [TestMethod]
        public void ValidationTest_CheckSum3()
        {
            try
            {
                var vin = new VIN("3B6HB11Y8WK101340");
                Assert.Fail("Expected an ArgumentException to be thrown.");
            }
            catch (ArgumentException exception)
            {
                var expectedMessage = "VIN has invalid checksum.";
                Assert.AreEqual(expectedMessage, exception.Message, "Expected exception message did not match the actual exception message.");
            }
        }

        // Проверка валидации VIN по значению контрольной суммы, случай с некорректной контрольной суммой
        [TestMethod]
        public void ValidationTest_CheckSum4()
        {
            try
            {
                var vin = new VIN("2B6HB01Y8WK101340");
                Assert.Fail("Expected an ArgumentException to be thrown.");
            }
            catch (ArgumentException exception)
            {
                var expectedMessage = "VIN has invalid checksum.";
                Assert.AreEqual(expectedMessage, exception.Message, "Expected exception message did not match the actual exception message.");
            }
        }

    }
}
