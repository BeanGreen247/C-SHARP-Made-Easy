using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculations
{
class Program
    {
        static void Main(string[] args)
        {
			//declaring our variables
			double number1, number2;
			
			//assigned values to variables
			number1=2;
			number2=4;
			
			//addition
			Console.WriteLine(number1+number2);
			//subtration
			Console.WriteLine(number1-number2);
			//multiplication
			Console.WriteLine(number1*number2);
			//division
			Console.WriteLine(number1/number2);
			
			Console.ReadKey();
        }
    }
}
