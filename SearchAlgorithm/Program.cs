using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchAlgorithm
{
    class Program
    {
        //Array to be searched
        int[] arr = new int[20];
        //number of elements in the array
        int n;
        //get the number of elements to store in the array
        int i;

        public void input()
        {
            while(true)
            {
                Console.Write("Enter the number of elements in the array: ");
                string s = Console.ReadLine(); 
                n = int.Parse(s);
                if ((n > 0) && (n <= 20))
                    break;
                else
                    Console.WriteLine("\nArray should have minimum 1 and maximum 20 elements");
            }
            //accept array elements 
            Console.WriteLine("");
            Console.WriteLine("----------------------");
            Console.WriteLine(" Enter Array elements ");
            Console.WriteLine("----------------------");
            for (i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + ">");
                String s1 = Console.ReadLine();
                arr[i] = int.Parse(s1);

            }
        }



        static void Main(string[] args)
        {
        }
    }
}
