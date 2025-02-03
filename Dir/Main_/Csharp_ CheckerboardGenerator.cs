using System;

namespace VaxxVault_V0002.Dir.Handle
{
   public static class CheckerboardGenerator
   {
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
