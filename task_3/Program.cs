using System;

namespace task_3
{
	public class MainClass
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Enter first value:");
			int minValue = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter second value:");
			int maxValue = Convert.ToInt32(Console.ReadLine());
			int[] numbers = Calculations.genarateArray(minValue, maxValue);
			Calculations.sumOfNumbers(numbers);
		}
	}
	public class Calculations
	{
		public static int[] genarateArray(int startValue, int endValue)
		{
			int lenght = endValue - startValue + 1;
			int[] tempArray = new int[lenght];
			for (int i = 0; i < lenght; i++)
			{
				tempArray[i] = startValue + i;
			}
			return tempArray;
		}
		public static void sumOfNumbers(int[] newArray)
		{
			int sum = 0;
			foreach (int el in newArray)
			{
				if (el % 3 == 0 && el % 5 != 0)
					{
						sum +=el;
					}
			}
			Console.WriteLine($"The sum of numbers is {sum}");
		}
	}
}

