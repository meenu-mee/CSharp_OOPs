using System;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameValidTest()
        {
            //Arrange
            Customer customer = new Customer();
            customer.FirstName = "Daniel";
            customer.LastName = "Caesar";
            string expected = "Caesar, Daniel";

            //Act
            string actual = customer.FullName;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void FullNameFirstNameEmpty()
        {
            //Arrange
            Customer customer = new Customer();
            customer.LastName = "Caesar";
            string expected = "Caesar";

            //Act
            string actual = customer.FullName;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void FullNameLastNameEmpty()
        {
            //Arrange
            Customer customer = new Customer();
            customer.FirstName = "Daniel";
            string expected = "Daniel";

            //Act
            string actual = customer.FullName;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void StaticTest()
        {
            //Arrange
            Customer c1 = new Customer();
            c1.FirstName = "cf1";
            Customer.InstanceCount += 1;

            Customer c2 = new Customer();
            c1.FirstName = "cf2";
            Customer.InstanceCount += 1;

            Customer c3 = new Customer();
            c1.FirstName = "cf3";
            Customer.InstanceCount += 1;           

            //Assert
            Assert.AreEqual(3,Customer.InstanceCount);
        }

        [TestMethod]
        public void ValidateValid()
        {
            //Arrange
            var customer = new Customer
            {
                LastName = "Daniel",
                EmailAddress = "daniel@gmail.com"
            };
            var expected = true;
        
            //Act
            var actual = customer.Validate();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateMissingLastName()
        {
            //Arrange
            var customer = new Customer
            {
               EmailAddress = "daniel@gmail.com"
            };
            var expected = false;

            //Act
            var actual = customer.Validate();

            //Assert
            Assert.AreEqual(expected, actual);
        }


    }
}
