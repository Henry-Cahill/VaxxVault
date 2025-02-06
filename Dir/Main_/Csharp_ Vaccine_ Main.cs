using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using VaxxVault_V0002.Dir.Handle;
using VaxxVault_V0003.Dir.Main_.Handle_;

namespace VaxxVault_V0002.Dir.Main_
{
   public class Vaccine_Main
   {
      public static void Main(string[] args)
      {
         var commands = new Dictionary<string, Func<Task>>
               {
                   { "maintenance", () => Task.Run(() => Maintenance.Handle()) },
                   { "main", () => Task.Run(() => MainRails.HandleAnotherTask()) },
                   { "python", () => Task.Run(() => Console.WriteLine("Python task not implemented.")) },
                   { "exit", () => Task.Run(() => Console.WriteLine("Exiting application...")) }
               };

         while (true)
         {
            Console.WriteLine("Please enter an argument ('main', 'maintenance', 'python', 'exit'):");
            var input = Console.ReadLine()?.ToLower();

            if (input == "exit")
            {
               commands[input]().Wait();
               return;
            }

            if (commands.ContainsKey(input))
            {
               commands[input]().Wait();
            }
            else
            {
               Console.WriteLine("Invalid argument. Use 'main', 'maintenance', 'python', or 'exit'.");
            }
         }
      }
   }
}
// Declaration of Intellectual Property Ownership: I, Henry Lawrence Cahill, declare exclusive rights and ownership of all intellectual property associated with VaxxVault. Unauthorized use, reproduction, distribution, or modification is strictly prohibited. For inquiries, contact me at henrycahill97@gmail.com. Any infringement will be pursued to the fullest extent of the law. Signed on January 29, 2023.