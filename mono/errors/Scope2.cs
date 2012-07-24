// another scope test that will generate an error
// Scope2.cs
using System;

class Demo {
	public static void Main() {
		int i = 3;
		if 	(i == 3) {
			global int j = 25;
		}

		Console.WriteLine("j: " + j);
		}
}

