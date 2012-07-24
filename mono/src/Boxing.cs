// quick ref/value type demo about "boxing"
// Boxing.cs
using System;

public class Demo {
	public static void Main() {
		int a = 42;
		object b = a;
		int c = (int)b;

		Console.WriteLine("c: " + c);
		Console.WriteLine("b: " + b);
		Console.WriteLine("a: " + a);
	}
}
