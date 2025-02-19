using System;
using Xunit;
using VaxxVault_V0004.Dir.Main_;

namespace VaxxVault_V0004.Tests
{
    public class AccountManagerTests
    {
        [Fact]
        public void ManageAccount_ValidAccountAndUsername_UpdatesUsername()
        {
            // Arrange
            var account = new Account("TestName", "OldUsername");
            var newUsername = "NewUsername";

            // Act
            AccountManager.ManageAccount(account, newUsername);

            // Assert
            Assert.Equal(newUsername, account.Username);
        }

        [Fact]
        public void ManageAccount_NullAccount_ThrowsArgumentNullException()
        {
            // Arrange
            Account account = null;
            var newUsername = "NewUsername";

            // Act & Assert
            var exception = Assert.Throws<ArgumentNullException>(() => AccountManager.ManageAccount(account, newUsername));
            Assert.Equal("vaxxVaultAccount", exception.ParamName);
        }

        [Fact]
        public void ManageAccount_NullOrWhitespaceUsername_ThrowsArgumentException()
        {
            // Arrange
            var account = new Account("TestName", "OldUsername");

            // Act & Assert
            Assert.Throws<ArgumentException>(() => AccountManager.ManageAccount(account, null));
            Assert.Throws<ArgumentException>(() => AccountManager.ManageAccount(account, ""));
            Assert.Throws<ArgumentException>(() => AccountManager.ManageAccount(account, " "));
        }

        [Fact]
        public void GetNewUsername_ReturnsEnteredUsername()
        {
            // Arrange
            var input = "NewUsername";
            var stringReader = new System.IO.StringReader(input);
            Console.SetIn(stringReader);

            // Act
            var result = AccountManager.GetNewUsername();

            // Assert
            Assert.Equal(input, result);
        }

        [Fact]
        public void GetNewUsername_EmptyInput_ReturnsEmptyString()
        {
            // Arrange
            var input = "";
            var stringReader = new System.IO.StringReader(input);
            Console.SetIn(stringReader);

            // Act
            var result = AccountManager.GetNewUsername();

            // Assert
            Assert.Equal(string.Empty, result);
        }
    }
}
