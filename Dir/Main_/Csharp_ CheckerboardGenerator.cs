using System;

namespace VaxxVault_V0002.Dir.Handle
{
   /// <summary>
   /// Provides methods to generate a checkerboard pattern.
   /// </summary>
   public static class CheckerboardGenerator
   {
      /// <summary>
      /// Generates and prints a checkerboard pattern to the console.
      /// </summary>
      public static void GenerateCheckerboard()
      {
         int W = 78;
         int H = 3;
         for (var i = 0; i < H / 2; i++)
         {
            for (var j = 0; j < W / 2; j++)
            {
               Console.Write("* ");
            }
            Console.WriteLine();
            for (var j = 0; j < W / 2; j++)
            {
               Console.Write(" *");
            }
            Console.WriteLine();
         }

         Console.WriteLine(
         "\n                                                             .::.          \r" +
         "\n                                                            -%%%% +.       \r" +
         "\n                                                            =% *:=#%-.     \r" +
         "\n                                                            :#%%*.+%#:     \r" +
         "\n                                                          :*% *.-#%=.+%*.  \r" +
         "\n                                                ..:..   .*%%. ..#%%%#%#.   \r" +
         "\n                                              -%%#%#:.+%#:  .*%#:.--:.     \r" +
         "\n                                               =%#..#%%#:  .=%#-.          \r" +
         "\n                                              .=%%% *.:%%#.=%#-.           \r" +
         "\n                                            .-%#= -#%+.-#%%+.              \r" +
         "\n                                           :%%=.    -%%=.-%%=.             \r" +
         "\n                                         :#%*#%*.     =%%-.=%+             \r" +
         "\n                                       .#%*.  .%%+    .+%%%%%=             \r" +
         "\n                                     .+%#%*:    :.  .=%#-.--.              \r" +
         "\n                                   .=%% - .*% *.    .:%%=                  \r" +
         "\n                                 .=%%% +.   .-.   :#%=.                    \r" +
         "\n                               .-%%=.=%%=     .:#%+.                       \r" +
         "\n                             .#%#:   .=%.   .#%*.                          \r" +
         "\n                            .#%+:*%*.      .+%#:                           \r" +
         "\n                           .%%.  .:#%-   .+%#:                             \r" +
         "\n                           .%%         .=%#-                               \r" +
         "\n                          .. %%#       :%%=.                               \r" +
         "\n                        .#%#%#-:+-. :#%+.                                  \r" +
         "\n                      .-%%%% -#%%%%%%%+                                    \r" +
         "\n                      =% +..+%#%#:                                         \r" +
         "\n                      =% +.:#%#-.                                          \r" +
         "\n                     .*##%%*:.                                             \r" +
         "\n                   .+#:                                                    \r" +
         "\n                 .=% -.                                                    \r" +
         "\n               .=%=.                                                       \r" +
         "\n              :%=.                                                         \r" +
         "\n            :**.                                                           \r" +
         "\n          .:#.                                                             \r" +
         "\n          ..                                                               \r");

         for (var i = 0; i < H / 2; i++)
         {
            for (var j = 0; j < W / 2; j++)
            {
               Console.Write("* ");
            }
            Console.WriteLine();
            for (var j = 0; j < W / 2; j++)
            {
               Console.Write(" *");
            }
            Console.WriteLine();
         }
      }
   }
}
//Declaration of Intellectual Property Ownership: I, Henry Lawrence Cahill, declare exclusive rights and ownership of all intellectual property associated with VaxxVault. Unauthorized use, reproduction, distribution, or modification is strictly prohibited. For inquiries, contact me at henrycahill97@gmail.com. Any infringement will be pursued to the fullest extent of the law. Signed on January 29, 2023. 