using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UserRegistration;

namespace UserRegistrationTestings
{
    [TestClass]
    public class UnitTest1
    {
        //Happy Test Cases(Test Cases Pass The Entries)
        [TestMethod]
        public void GivenUserFistName_WhenValidate_ShouldReturnTrue()
        {
            //Arrange
            ValidateUserRegistration user = new ValidateUserRegistration();
            string firstName = "Piyush";
            //Act
            bool result = user.ValidateFirstName(firstName);
            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void GivenUserLastName_WhenValidate_ShouldReturnTrue()
        {
            //Arrange
            ValidateUserRegistration user = new ValidateUserRegistration();
            string lastName = "Gupta";
            //Act
            bool result = user.ValidateFirstName(lastName);
            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void GivenEmailId_WhenValidate_ShouldReturnTrue()
        {
            //Arrange
            ValidateUserRegistration user = new ValidateUserRegistration();
            string email = "piyushgupta1234@gmail.com";
            //Act
            bool result = user.ValidateEmail(email);
            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void GivenMobileNumber_WhenValidate_ShouldReturnTrue()
        {
            //Arrange
            ValidateUserRegistration user = new ValidateUserRegistration();
            string mobileNumber = "91 6234517890";
            //Act
            bool result = user.ValidateMobileNo(mobileNumber);
            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void GivenPassword_WhenValidate_ShouldReturnTrue()
        {
            //Arrange
            ValidateUserRegistration user = new ValidateUserRegistration();
            string password = "Qwerty@123";
            //Act
            bool result = user.ValidatePassword(password);
            //Assert
            Assert.IsTrue(result);
        }
        //Sad Test Cases(Test Cases Fail The Entry)
        [TestMethod]
        public void GivenUserFistName_WhenValidate_Should_Throw_URCustomException_Indicating_Invalid_FirstName()
        {
            try
            {
                //Arrange
                ValidateUserRegistration user = new ValidateUserRegistration();
                string firstName = "piyush";
                //Act
                bool result = user.ValidateFirstName(firstName);
            }
            catch (URCustomException e)
            {
                //Assert
                Assert.AreEqual("Invalid first name.", e.Message);
            }
        }
        [TestMethod]
        public void GivenUserLastName_WhenValidate_Should_Throw_URCustomException_Indicating_Invalid_LastName()
        {
            try
            {
                //Arrange
                ValidateUserRegistration user = new ValidateUserRegistration();
                string lastName = "gupta";
                //Act
                bool result = user.ValidateLastName(lastName);
            }
            catch (URCustomException e)
            {
                //Assert
                Assert.AreEqual("Invalid last name.", e.Message);
            }
        }
        [TestMethod]
        public void GivenUserEmail_WhenValidate_Should_Throw_URCustomException_Indicating_Invalid_Email()
        {
            try
            {
                //Arrange
                ValidateUserRegistration user = new ValidateUserRegistration();
                string email = "piyushguptagmail.com";
                //Act
                bool result = user.ValidateEmail(email);
            }
            catch (URCustomException e)
            {
                //Assert
                Assert.AreEqual("Invalid email address.", e.Message);
            }
        }
        [TestMethod]
        public void GivenUserMobileNumber_WhenValidate_Should_Throw_URCustomException_Indicating_Invalid_MobileNo()
        {
            try
            {
                //Arrange
                ValidateUserRegistration user = new ValidateUserRegistration();
                string mobileNumber = "11 1123453214";
                //Act
                bool result = user.ValidateMobileNo(mobileNumber);
            }
            catch (URCustomException e)
            {
                //Assert
                Assert.AreEqual("Invalid mobile number.", e.Message);
            }
        }
        [TestMethod]
        public void GivenUserPassword_WhenValidate_Should_Throw_URCustomException_Indicating_Invalid_Password()
        {
            try
            {
                //Arrange
                ValidateUserRegistration user = new ValidateUserRegistration();
                string password = "pqwert@123";
                //Act
                bool result = user.ValidatePassword(password);
            }
            catch (URCustomException e)
            {
                //Assert
                Assert.AreEqual("Invalid password.", e.Message);
            }
        }
        [TestMethod]
        [DataRow("abc@yahoo.com")]
        [DataRow("abc-100@yahoo.com")]
        [DataRow("abc.100@yahoo.com")]
        [DataRow("abc111@abc.com")]
        [DataRow("abc.100@abc.com.au")]
        [DataRow("abc-100@abc.net")]
        [DataRow("abc@1.com")]
        [DataRow("abc@gmail.com.com")]
        [DataRow("abc+100@gmail.com")]
        public void GivenEmailIds_WhenValidate_ShouldReturnTrue(string email)
        {
            //Arrange
            ValidateUserRegistration user = new ValidateUserRegistration();
            //Act
            bool result = user.ValidateEmail2(email);
            //Assert
            Assert.IsTrue(result);
        }
    }
}
