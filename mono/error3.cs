// first error handling demo
// error3.cs
using System;

class Demo {
	public static void Main() {
		int i = 2, j = 0;
		double result;

		try {
			result = i / j;
			Console.WriteLine("Result: " + result);
		}
		catch {
			Console.WriteLine("Wrong Division");
		}
	}
}

