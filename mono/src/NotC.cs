// a demo to prove that the last demo isnt really like c or c++
// NotC.cs
using System;

public class Demo {
	public static void Main() {
		int a = 42;
		object b = a;
		Console.WriteLine("Before: " + a);

		Increment(b);
		int c = (int)b;
		Console.WriteLine("after: " + c);
	}

	static void Increment(Object x) {
		int y = (int)x;
		y++;
		x = y;
	}
}
