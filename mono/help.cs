// qucik swap data demo
// help.cs
using System;

public class Demo {
	public static void Main() {
		int x = 3;
		int y = 5;

		Swap(ref x, ref y);
		Console.WriteLine("x: {0} - y: {1}", x, y);
	}

	static void Swap(ref int a, ref int b) {
		int c = a;
		a = b;
		b =c;
		Console.WriteLine("a: {0} - b: {1}", a, b);
	}
}
