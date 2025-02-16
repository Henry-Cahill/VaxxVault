using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Threading.Tasks;
using VaxxVault_V0004.Dir.Main_;
using VaxxVault_V0004.Dir.Main_.Handle_;
using VaxxVault_V0004.Dir.Main_.Handle_.Switchs_;
using VaxxVault_V0004.Dir.Main_.Workflow_Alpha_.Vaccines_;

namespace VaxxVault_V0004.Tests
{
   /// <summary>
   /// Contains unit tests for the VaxxVault application.
   /// </summary>
   [TestClass]
   public class UnitTests
   {
      /// <summary>
      /// Tests the ToString method of the Account class.
      /// </summary>
      [TestMethod]
      public void TestAccountToString()
      {
         // Arrange
         var account = new Account("TestName", "TestUsername");

         // Act
         var result = account.ToString();

         // Assert
         Assert.AreEqual("Name: TestName, Username: TestUsername", result);
      }

      /// <summary>
      /// Tests the Execute method of the LoadAll class.
      /// </summary>
      [TestMethod]
      public void TestLoadAllExecute()
      {
         // Act
         LoadAll.Execute();

         // Assert
         // No exception means success
      }

      /// <summary>
      /// Tests the HandleAsync method of the Maintenance class.
      /// </summary>
      [TestMethod]
      public async Task TestMaintenanceHandleAsync()
      {
         // Act
         await Maintenance.HandleAsync();

         // Assert
         // No exception means success
      }

      /// <summary>
      /// Tests various data calculations.
      /// </summary>
      [TestMethod]
      public void TestDataCalculations()
      {
         // Arrange
         var data = new Data("John", "Doe", 30, "Male", 2025, 70, 180, 1, 15, 1995);

         // Act & Assert
         Assert.AreEqual(30, data.Age);
         data.DisplayDate();
         data.DisplayHeartRates();
         data.DisplayBMI();
      }

      /// <summary>
      /// Tests the EnsureDirectoryExists method of the DirectoryHelper class.
      /// </summary>
      [TestMethod]
      public void TestDirectoryHelperEnsureDirectoryExists()
      {
         // Arrange
         string filePath = "testDir/testFile.txt";

         // Act
         DirectoryHelper.EnsureDirectoryExists(filePath);

         // Assert
         Assert.IsTrue(Directory.Exists(Path.GetDirectoryName(filePath)));
      }
   }
}
