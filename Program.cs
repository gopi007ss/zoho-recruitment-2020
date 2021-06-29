using System;

namespace ConsoleApp1
{
	public class Program
	{
		public static void Main()
		{
			int i, j, n;
			string str = Console.ReadLine();
			n = str.Length;
			int midindex = n/2;
			char[] arr = str.ToCharArray();
			for (i = 1; i <= n; i++)
			{
				for (j = i; j < n; j++)
					Console.Write(" ");
				int k = 0;
				for (j = 0; j < i; j++)
                {					
					if(j > midindex)
                    {
						Console.Write(arr[k]);
						k++;
					}					
					else
						Console.Write(arr[n-midindex + j -1]);
				}
					
				
				Console.WriteLine();
			}
		}
	}
}
