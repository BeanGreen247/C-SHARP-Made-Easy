using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCode
{
class Program
    {
        static void Main(string[] args)
        {
            ////single dimensional array
            //int[] sdarr = new int[] { 1,2,3,4,5,6 };
            ////printig out the values
            //for (int i=0; i<=5; i++)
            //{
            //    Console.WriteLine(sdarr[i]);
            //}

            //int[,] mdarr = new int[2, 3];
            ////multi dimensional array
            int[,] mdarr = { {1,2,3}, {4,5,6} };
            ////printig out the values
            for (int i=0; i<=1; i++)
            {
              for (int j=0; j<=2; j++)
              {
                  Console.WriteLine(mdarr[i,j]);
              }
            }

            ////waiting for input
            Console.ReadKey();
        }
    }
}
