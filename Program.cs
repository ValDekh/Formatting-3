using System;
using System.Globalization;

namespace Formatting_3
{
   class Program
   {
      static void Main(string[] args)
      {
         double ittialDouble = 0.6822871999174;
         string valueString = ittialDouble.ToString("R", CultureInfo.InvariantCulture);
         double reversInittialDouble = double.Parse(valueString, CultureInfo.InvariantCulture);
         System.Console.WriteLine(format: "{0:R}= {1:R}:{2}\n",
                                arg0: ittialDouble,
                                arg1: reversInittialDouble,
                                arg2: ittialDouble.Equals(reversInittialDouble));
         string valueString17 = ittialDouble.ToString("G17", CultureInfo.InvariantCulture);
         double reversInittialDouble17 = double.Parse(valueString17, CultureInfo.InvariantCulture);
         Console.WriteLine(format: "{0:G17} = {1:G17}:{2}",
         arg0: ittialDouble,
         arg1: valueString17,
         arg2: ittialDouble.Equals(reversInittialDouble17));
         Console.WriteLine($"New one");
         Console.WriteLine($"New one branch");
         
         
         

      }
   }
}
