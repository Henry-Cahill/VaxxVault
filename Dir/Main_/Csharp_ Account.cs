using System;

namespace VaxxVault_V0004.Dir.Main_
{
   /// <summary>
   /// Represents an account with a name and username.
   /// </summary>
   public class Account : IEquatable<Account>
   {
      /// <summary>
      /// Gets or sets the name of the account.
      /// </summary>
      /// <exception cref="ArgumentNullException">Thrown when the value is null.</exception>
      public string Name { get; set; }

      /// <summary>
      /// Gets or sets the username of the account.
      /// </summary>
      /// <exception cref="ArgumentNullException">Thrown when the value is null.</exception>
      public string Username { get; set; }

      /// <summary>
      /// Initializes a new instance of the <see cref="Account"/> class.
      /// </summary>
      /// <param name="name">The name of the account.</param>
      /// <param name="username">The username of the account.</param>
      public Account(string name, string username)
      {
         Name = name ?? throw new ArgumentNullException(nameof(name), "Name cannot be null");
         Username = username ?? throw new ArgumentNullException(nameof(username), "Username cannot be null");
      }

      /// <summary>
      /// Returns a string that represents the current object.
      /// </summary>
      /// <returns>A string that represents the current object.</returns>
      public override string ToString()
      {
         return $"Name: {Name}, Username: {Username}";
      }

      /// <summary>
      /// Determines whether the specified object is equal to the current object.
      /// </summary>
      /// <param name="obj">The object to compare with the current object.</param>
      /// <returns>true if the specified object is equal to the current object; otherwise, false.</returns>
      public override bool Equals(object? obj)
      {
         return Equals(obj as Account);
      }

      /// <summary>
      /// Determines whether the specified <see cref="Account"/> is equal to the current <see cref="Account"/>.
      /// </summary>
      /// <param name="other">The <see cref="Account"/> to compare with the current <see cref="Account"/>.</param>
      /// <returns>true if the specified <see cref="Account"/> is equal to the current <see cref="Account"/>; otherwise, false.</returns>
      public bool Equals(Account? other)
      {
         return other != null &&
                Name == other.Name &&
                Username == other.Username;
      }

      /// <summary>
      /// Serves as the default hash function.
      /// </summary>
      /// <returns>A hash code for the current object.</returns>
      public override int GetHashCode()
      {
         return HashCode.Combine(Name, Username);
      }
   }
}
//Declaration of Intellectual Property Ownership: I, Henry Lawrence Cahill, declare exclusive rights and ownership of all intellectual property associated with VaxxVault. Unauthorized use, reproduction, distribution, or modification is strictly prohibited. For inquiries, contact me at henrycahill97@gmail.com. Any infringement will be pursued to the fullest extent of the law. Signed on January 29, 2023. 