// first demo for compiling multiple files. file 1
// Human3.cs
using System;

public class Human {
	public Human() {
		Console.WriteLine("A child without a name... ");
	}

	public Human(string name) {
		Console.WriteLine(name + " is born...");
	}
}
