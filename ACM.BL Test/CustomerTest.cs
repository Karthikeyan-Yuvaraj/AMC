using System;
using AMC.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace ACM.BL_Test
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            //Arrange
            var customer = new Customer()
            {
                FirstName = "Bilbo",
                LastName = "Baggins"
            };
            string expected = "Baggins, Bilbo";

            //Act
            string actual = customer.FullName;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameLastNameEmpty()
        {
            //Arrange
            var customer = new Customer()
            {
                FirstName = "Bilbo"
            };
            string expected = "Bilbo";

            //Act
            string actual = customer.FullName;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameFirstNameEmpty()
        {
            //Arrange
            var customer = new Customer()
            {
                LastName = "Baggins"
            };
            string expected = "Baggins";

            //Act
            string actual = customer.FullName;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StaticTest()
        {
            // Arrange
            var c1 = new Customer() {FirstName = "Bilbo"};
            Customer.InstanceCount += 1;
            var c2 = new Customer() {FirstName = "Frodo"};
            Customer.InstanceCount += 1;
            var c3 = new Customer() {FirstName = "Rosie"};
            Customer.InstanceCount += 1;

            //Act
            var expected = 3;

            //Assert
            Assert.AreEqual(expected, Customer.InstanceCount);
        }

        [TestMethod]
        public void ValidateValid()
        {
            // Arrange
            var customer = new Customer()
            {
                LastName = "Baggins",
                EmailAddress = "fbaggins@hobbiton.me"
            };
            var expect = true;

            // Act
            var actual = customer.Validate();

            // Assert
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void ValidateMissingLastName()
        {
            // Arrange
            var customer = new Customer()
            {
                EmailAddress = "fbaggins@hobbiton.me"
            };
            var expect = false;

            // Act
            var actual = customer.Validate();

            // Assert
            Assert.AreEqual(expect, actual);
        }
    }
}
