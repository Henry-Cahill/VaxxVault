using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VaxxVault_V0002.Dir.Python_;

namespace VaxxVault_V0002.Dir.Handle_
{
   internal class Anaconda
   {
      public static void Handle()
      {
         Console.WriteLine("Select One of the Following Options:");
         Console.WriteLine("-------------------------------------");
         Console.WriteLine("   1. Select");
         Console.WriteLine("   2. Definition");
         Console.WriteLine("   3. DataFrame");
         Console.WriteLine("   4. Validate");
         Console.WriteLine("   5. Exit");
         switch (Console.ReadLine())
         {
            case "Select":
               Vaccine_Py_Select.Python();
               break;
            case "Definition":
               Vaccine_Py_Def.Python();
               break;
            case "DataFrame":
               Vaccine_Py_DF.Python();
               break;
            case "Validate":
               Vaccine_Py_Val.Python();
               break;
            case "5":
               break;
            default:
               Console.WriteLine("Invalid choice. Please select a valid option.");
               break;
         }
      }
   }
}
