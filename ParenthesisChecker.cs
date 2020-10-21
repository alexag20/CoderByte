using System;
using System.Collections.Generic;
					
public class Program
{
	public static void Main()
	{
		Console.Write("Enter expression to check if parenthesis are balanced : ");
		string str = Console.ReadLine();
		
		char[] chrExp = str.ToCharArray();
		if (isBalanced(chrExp))
			Console.WriteLine("Expression is Balanced ");
		else
			Console.WriteLine("Expression is Not Balanced ");
	}
	
	public static Boolean isMatchingPairs(char chr1, char chr2)
	{
		if (chr1 == '(' && chr2 == ')')
			return true;
		else if (chr1 == '{' && chr2 == '}')
			return true;
		else if (chr1 == '[' && chr2 == ']')
			return true;
		else
			return false;
	}
	
	public static Boolean isAParenthesis(char chr)
	{
		char[] parenthesisList = {'(', ')', '{', '}', '[', ']'};
		foreach (char c in parenthesisList)
		{
			if (c == chr)
				return true;
		}
		
		return false;
	}
	
	public static Boolean isBalanced(char[] exp)
	{
		Stack<char> pList = new Stack<char>();
		
		for (int i = 0; i < exp.Length; i++)
		{
			//check if it is a parenthesis
			if (isAParenthesis(exp[i]) == false)
			{
				throw new Exception("There are some invalid characters in the expression.");
				//return false;
			}
			
			if (exp[i] == '(' || exp[i] == '{' || exp[i] == '[')
				pList.Push(exp[i]);
			
			if (exp[i] == ')' || exp[i] == '}' || exp[i] == ']')
			{
				if (pList.Count == 0)
					return false;
				else if (!isMatchingPairs(pList.Pop(), exp[i]))
					return false;
			}
		}
		
		if (pList.Count == 0)
			return true;
		else
			return false;
	}
}
