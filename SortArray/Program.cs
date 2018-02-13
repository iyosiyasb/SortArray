using System;

namespace SortArray
{
    class Program
    {
        static void Main(string[] args)
        {
			int[]n = { -4, 5, 2, -6, 45, 34, -12, 56, 20 };			
				Array.Sort(n);
			 int i= 0;
			for(i = 0; i < n.Length; i++)  
			
				Console.WriteLine(n[i]);
				Console.ReadLine();
			
			
        }
    }
}
