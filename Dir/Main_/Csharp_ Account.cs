using System;

namespace VaxxVault_V0002.Dir.Main_
{
   /// <summary>
   /// Represents an account with a name and username.
   /// </summary>
   public class Account
   {
      private string _name;
      private string _username;

      /// <summary>
      /// Gets or sets the name of the account.
      /// </summary>
      /// <exception cref="ArgumentNullException">Thrown when the value is null.</exception>
      public string Name
      {
         get => _name;
         set => _name = value ?? throw new ArgumentNullException(nameof(value), "Name cannot be null");
      }

      /// <summary>
      /// Gets or sets the username of the account.
      /// </summary>
      /// <exception cref="ArgumentNullException">Thrown when the value is null.</exception>
      public string Username
      {
         get => _username;
         set => _username = value ?? throw new ArgumentNullException(nameof(value), "Username cannot be null");
      }

      /// <summary>
      /// Initializes a new instance of the <see cref="Account"/> class.
      /// </summary>
      /// <param name="name">The name of the account.</param>
      /// <param name="username">The username of the account.</param>
      public Account(string name, string username)
      {
         _name = name ?? throw new ArgumentNullException(nameof(name), "Name cannot be null");
         _username = username ?? throw new ArgumentNullException(nameof(username), "Username cannot be null");
      }

      /// <summary>
      /// Returns a string that represents the current object.
      /// </summary>
      /// <returns>A string that represents the current object.</returns>
      public override string ToString()
      {
         return $"Name: {Name}, Username: {Username}";
      }
   }
}
//Declaration of Intellectual Property Ownership: I, Henry Lawrence Cahill, declare exclusive rights and ownership of all intellectual property associated with VaxxVault. Unauthorized use, reproduction, distribution, or modification is strictly prohibited. For inquiries, contact me at henrycahill97@gmail.com. Any infringement will be pursued to the fullest extent of the law. Signed on January 29, 2023. 