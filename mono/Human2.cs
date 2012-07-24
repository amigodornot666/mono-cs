// this is a more complex example with a class and functions
// Human2.cs
using System;

class Demo {
	public static void Main() {
		Human hugo = new Human("hugo");
		hugo.GrowUp();
	}
}

public class Human {
	public Human(string name) {
		Console.WriteLine(name + " is born!!");
	}

	public void GrowUp() {
		this.LearnToRead();
		this.LearnToWrite();
	}

	private void LearnToRead() {
		Console.WriteLine("Reading is simple (shh im privae)");
	}

	private void LearnToWrite() {
		Console.WriteLine("Writing is fun...(private too)");
	}
}
