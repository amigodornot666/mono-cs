// a scope demo
// Scope1.cs
using System;

class Demo {
	public static void Main() {
		string name = "Hugo";
		Human hugo = new Human(name);
	}
}

class Human {
	public Human(string objname) {
		Console.WriteLine("I am " + objname);
		Console.WriteLine("I am " + name);
	}
}
