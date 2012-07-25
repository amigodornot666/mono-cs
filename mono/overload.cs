// a function overloading example
// OVERLOAD.CS
using System;

class Demo {
	public static void Main() {
		Human paul = new Human();
		Human hugo = new Human("Hugo");
	}
}

public class Human {
	public Human() {
		Console.WriteLine("a child without a name ...");
	}
	public Human(string name) {
		Console.WriteLine(name + " is born ...");
	}
}

