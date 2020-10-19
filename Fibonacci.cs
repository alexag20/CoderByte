using System;
					
public class Program
{
	public static void Main()
	{
		ulong firstNum = 0;
		ulong lastNum = 1;
		
		Console.WriteLine("The Fibonacci series is : ");
		
		for (int ctr = 2; ctr <= 200; ctr++)
		{
			if (ctr == 2)
			{
				Console.Write(firstNum);
				Console.Write(", " + lastNum);
			}
			else
			{
				ulong fiboNum = firstNum + lastNum;
				
				Console.Write(", " + fiboNum);
				
				firstNum = lastNum;
				lastNum = fiboNum;
			}
		}
		
		Console.WriteLine();
		Console.WriteLine("The 200th Fibonacci number is : " + lastNum);
	}
}
