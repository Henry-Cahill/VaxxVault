using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaxxVault_V0002.Dir.Handle
{
   internal class Maintenance
   {
      public static void Handle()
      {
         Console.WriteLine("Select One of the Following Options:");
         Console.WriteLine("-------------------------------------");
         Console.WriteLine("   1. XML");
         Console.WriteLine("   2. Database");
         Console.WriteLine("   3. Tables");
         Console.WriteLine("   4. Privacy");
         Console.WriteLine("   5. System");

         switch (Console.ReadLine())
         {
            case "XML":
               XML.Handle();
               break;
            case "2":

               break;
            default:
               Console.WriteLine("Invalid choice. Please select a valid option.");
               break;
         }
      }
   }
}
//Declaration of Intellectual Property Ownership: I, Henry Lawrence Cahill, declare exclusive rights and ownership of all intellectual property associated with VaxxVault. Unauthorized use, reproduction, distribution, or modification is strictly prohibited. For inquiries, contact me at henrycahill97@gmail.com. Any infringement will be pursued to the fullest extent of the law. Signed on January 29, 2023. 
