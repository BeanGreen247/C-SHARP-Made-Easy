using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
class Program
    {
        static void Main(string[] args)
        {
			//declare a variable num with value of 0
			double num=0;
			
			//create a for loop
			//for (int i = 0; i<10;i++)
			//{
				//increase the num variable value by 1
			//	num+=1;
				//print out the current value
			//	Console.WriteLine("Current value of num="+num);
				//print out the number of increases
			//	Console.WriteLine("Number of increases:"+i);
			//}
			
			//proof of leaving for loop
			//Console.WriteLine("Left the for loop");
			
			do {
				//increase the num variable value by 1
				num+=1;
				//print out the current value
				Console.WriteLine("Current value of num="+num);
			}while(num<10);
			
			Console.ReadKey();
        }
    }
}
