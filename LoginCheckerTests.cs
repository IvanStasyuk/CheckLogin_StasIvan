using Microsoft.VisualStudio.TestTools.UnitTesting;
using CheckLogin_StasIvan;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckLogin_StasIvan.Tests
{
    [TestClass()]
    public class LoginCheckerTests
    {
        //Практическая работа
        //От 4 символов TRUE
        [TestMethod()]
        public void Check4Symbols_ReturnsTrue()
        {
            //Arrange
            string login = "Alex";
            bool expected = true;

            //Act
            bool actual = LoginChecker.ValidateLogin(login);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        //От 2 символов FALSE
        [TestMethod()]
        public void Check2Symbols_ReturnsFalse()
        {
            //Arrange
            string login = "BH";

            //Act
            bool actual = LoginChecker.ValidateLogin(login);

            //Assert
            Assert.IsFalse(actual);
        }

        //От 15 символов FALSE
        [TestMethod()]
        public void Check15Symbols_ReturnsFalse()
        {
            //Arrange
            string login = "ChrissRashordLensi";
            bool expected = false;

            //Act
            bool actual = LoginChecker.ValidateLogin(login);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        //Специальные символы FALSE
        [TestMethod()]
        public void Check_LoginWithSpecSymbols_ReturnsFalse()
        {
            //Arrange
            string login = "Abram#";
            bool expected = false;

            //Act
            bool actual = LoginChecker.ValidateLogin(login);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        //Специальные символы TRUE
        [TestMethod()]
        public void Check_LoginWithSpecSymbols_ReturnsTrue()
        {
            //Arrange
            string login = "Abram";
            bool expected = true;

            //Act
            bool actual = LoginChecker.ValidateLogin(login);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestClass()]
        //Задание 4
        public class PasswordCheckerTests
        { 
        //Оригинальное имя
        [TestMethod()]
        public void CorrectPassword_ReturnsTrue()
        {
            //Arrange
            string password = "Gosha2003!#";

            //Act
            bool actual = PasswordChecker.ValidatePassword(password);

            //Assert
            Assert.IsFalse(actual);
        }

        //От 8 до 30 символов TRUE
        [TestMethod()]
        public void Correct8to30Symbols_ReturnsTrue()
        {
            //Arrange
            string password = "Goga3333@";

            //Act
            bool actual = PasswordChecker.ValidatePassword(password);

            //Assert
            Assert.IsFalse(actual);
        }

        //От 8 до 30 символов FALSE
        [TestMethod()]
        public void Correct8to30Symbols_ReturnsFalse()
        {
            //Arrange
            string password = "Goga2007Goga2007Goga2007###@!";

            //Act
            bool actual = PasswordChecker.ValidatePassword(password);

            //Assert
            Assert.IsTrue(actual);
        }

        //Специальные символы TRUE
        [TestMethod()]
        public void CorrectWithSpecSymbols_ReturnsTrue()
        {
            //Arrange
            string password = "Giga27022005#";

            //Act
            bool actual = PasswordChecker.ValidatePassword(password);

            //Assert
            Assert.IsFalse(actual);
        }

        //Специальные символы FALSE
        [TestMethod()]
        public void CorrectWithSpecSymbols_ReturnsFalse()
        {
            //Arrange
            string password = "Giga27022005";

            //Act
            bool actual = PasswordChecker.ValidatePassword(password);

            //Assert
            Assert.IsTrue(actual);
        }

        //Прописные символы TRUE
        [TestMethod()]
        public void CorrectWithPropisSymbols_ReturnsTrue()
        {
            //Arrange
            string password = "Grigor394!";

            //Act
            bool actual = PasswordChecker.ValidatePassword(password);

            //Assert
            Assert.IsFalse(actual);
        }

        //Прописные символы FALSE
        [TestMethod()]
        public void CorrectWithPropisSymbols_ReturnsFalse()
        {
            //Arrange
            string password = "grigor394!";

            //Act
            bool actual = PasswordChecker.ValidatePassword(password);

            //Assert
            Assert.IsTrue(actual);
        }

        //Строчные символы TRUE
        [TestMethod()]
        public void CorrectWithStrochSymbols_ReturnsTrue()
        {
            //Arrange
            string password = "GOGa2005#";

            //Act
            bool actual = PasswordChecker.ValidatePassword(password);

            //Assert
            Assert.IsFalse(actual);
        }

        //Специальные символы FALSE
        [TestMethod()]
        public void CorrectWithStrochSymbols_ReturnsFalse()
        {
            //Arrange
            string password = "GOGA2005#";

            //Act
            bool actual = PasswordChecker.ValidatePassword(password);

            //Assert
            Assert.IsTrue(actual);
        }
        }
    }
}