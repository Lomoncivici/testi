
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject1
{
    [TestClass]
    public class PasswordCheckerTests
    {
        private PasswordChecker _checker;

        [TestInitialize]
        public void SetUp()
        {
            _checker = new PasswordChecker();
        }

        [TestMethod]
        public void TestPassword_1()
        {
            // Пустой пароль, не содержит ни одной из необходимых характеристик
            Assert.AreEqual(5, _checker.CheckPassword(""));
        }

        [TestMethod]
        public void TestPassword_2()
        {
            // Пароль содержит только цифры
            Assert.AreEqual(5, _checker.CheckPassword("12345678"));
        }

        [TestMethod]
        public void TestPassword_3()
        {
            // Пароль содержит только строчные буквы
            Assert.AreEqual(5, _checker.CheckPassword("abcdefgh"));
        }

        [TestMethod]
        public void TestPassword_4()
        {
            // Пароль содержит строчные и заглавные буквы
            Assert.AreEqual(5, _checker.CheckPassword("Abcdefgh"));
        }

        [TestMethod]
        public void TestPassword_5()
        {
            // Пароль содержит строчные и заглавные буквы, цифры
            Assert.AreEqual(5, _checker.CheckPassword("Abcd1234"));
        }

        [TestMethod]
        public void TestPassword_6()
        {
            // Пароль содержит строчные, заглавные буквы, цифры и спецсимволы, длина больше 7
            Assert.AreEqual(5, _checker.CheckPassword("Abcd1234!"));
        }
    }
}
