using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCode
{
class Program
    {
		public static void calc()
		{
			int sw=0;
			float num1=1, num2=1, res=0;
			Console.Write("Enter the value of num1:");
			num1=Convert.ToInt32(Console.ReadLine());
			Console.Write("Enter the value of num2:");
			num2=Convert.ToInt32(Console.ReadLine());
			Console.Write("\nPick an operation:"+"\n0-Addition"+"\n1-Subtraction"+"\n2-Multiplycation"+"\n3-Division"+"\nYour pick:");
			sw=Convert.ToInt32(Console.ReadLine());
			switch (sw)
			{
				case 0: 
				res=num1+num2;
				Console.WriteLine(num1+"+"+num2+"="+res);
				break;
				case 1: 
				res=num1-num2;
				Console.WriteLine(num1+"-"+num2+"="+res);
				break;
				case 2: 
				res=num1*num2;
				Console.WriteLine(num1+"*"+num2+"="+res);
				break;
				case 3: 
				res=num1/num2;
				Console.WriteLine(num1+"/"+num2+"="+res);
				break;
				default: 
				res=num1+num2;
				Console.WriteLine(num1+"+"+num2+"="+res);
				break;
			}
		}
		
        static void Main(string[] args)
        {
			int exit=0, newnum=0;
			do {
				calc();
				Console.Write("\nDo you wan to enter new numbers? 1=YES 0=NO ");
				newnum=Convert.ToInt32(Console.ReadLine());
				if (newnum==1)
				{
					calc();
				}
				Console.Write("\nDo you want to exit the app? 1=YES 0=NO ");
				exit=Convert.ToInt32(Console.ReadLine());
			}while(exit!=1);
			Console.WriteLine("Thank you for using my calculator.");
			Console.ReadKey();
		}
    }
}