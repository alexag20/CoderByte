using System;
					
public class Program
{
	public static void Main()
	{
		string varString;
		
		Console.Write("Enter a string : ");
		varString = Console.ReadLine();
		
		Console.WriteLine("You entered string : " + varString);
		Console.WriteLine();
		
		ReverseString(varString);
	}
	
	public static void ReverseString(string mainStr)
	{
		string[] words = mainStr.Split();
		Console.Write("Reversed string : ");
		for (int i = words.Length - 1; i >= 0; i--)
		{
			try
			{
				Console.Write(words[i] + " ");
			}
			catch (Exception ex)
			{
				Console.WriteLine("There was an error parsing the string. Error is : " + ex.ToString());
			}
		}
	}
}
