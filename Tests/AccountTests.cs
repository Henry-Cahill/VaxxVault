using System;
using VaxxVault_V0004.Dir.Main_;
using Xunit;

namespace VaxxVault_V0004.Tests
{
    public class AccountTests
    {
        [Fact]
        public void Constructor_ShouldInitializeProperties_WhenValidArguments()
        {
            // Arrange
            var name = "John Doe";
            var username = "johndoe";

            // Act
            var account = new Account(name, username);

            // Assert
            Assert.Equal(name, account.Name);
            Assert.Equal(username, account.Username);
        }

        [Fact]
        public void Constructor_ShouldThrowArgumentNullException_WhenNameIsNull()
        {
            // Arrange
            string name = null;
            var username = "johndoe";

            // Act & Assert
            var exception = Assert.Throws<ArgumentNullException>(() => new Account(name, username));
            Assert.Equal("name", exception.ParamName);
        }

        [Fact]
        public void Constructor_ShouldThrowArgumentNullException_WhenUsernameIsNull()
        {
            // Arrange
            var name = "John Doe";
            string username = null;

            // Act & Assert
            var exception = Assert.Throws<ArgumentNullException>(() => new Account(name, username));
            Assert.Equal("username", exception.ParamName);
        }

        [Fact]
        public void ToString_ShouldReturnCorrectFormat()
        {
            // Arrange
            var name = "John Doe";
            var username = "johndoe";
            var account = new Account(name, username);

            // Act
            var result = account.ToString();

            // Assert
            Assert.Equal("Name: John Doe, Username: johndoe", result);
        }

        [Fact]
        public void Equals_ShouldReturnTrue_WhenAccountsAreEqual()
        {
            // Arrange
            var account1 = new Account("John Doe", "johndoe");
            var account2 = new Account("John Doe", "johndoe");

            // Act
            var result = account1.Equals(account2);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void Equals_ShouldReturnFalse_WhenAccountsAreNotEqual()
        {
            // Arrange
            var account1 = new Account("John Doe", "johndoe");
            var account2 = new Account("Jane Doe", "janedoe");

            // Act
            var result = account1.Equals(account2);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void GetHashCode_ShouldReturnSameHashCode_WhenAccountsAreEqual()
        {
            // Arrange
            var account1 = new Account("John Doe", "johndoe");
            var account2 = new Account("John Doe", "johndoe");

            // Act
            var hashCode1 = account1.GetHashCode();
            var hashCode2 = account2.GetHashCode();

            // Assert
            Assert.Equal(hashCode1, hashCode2);
        }

        [Fact]
        public void GetHashCode_ShouldReturnDifferentHashCode_WhenAccountsAreNotEqual()
        {
            // Arrange
            var account1 = new Account("John Doe", "johndoe");
            var account2 = new Account("Jane Doe", "janedoe");

            // Act
            var hashCode1 = account1.GetHashCode();
            var hashCode2 = account2.GetHashCode();

            // Assert
            Assert.NotEqual(hashCode1, hashCode2);
        }
    }
}
