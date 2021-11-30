using System;

public class Demo
{

	public static void Main(string[] args)
	{
		Console.WriteLine("Total Memory:" + GC.GetTotalMemory(false));

		Demo obj = new Demo();

		Console.WriteLine("The generation number of object obj is: "
										+ GC.GetGeneration(obj));

		Console.WriteLine("Total Memory:" + GC.GetTotalMemory(false));
	}
}
