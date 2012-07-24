// Another class demo
// Demo3.cs
using System;

class Demo {
	public static void Main() {
		Human hugo = new Human();
		hugo.GrowUp();
		hugo.DrinkBeer();
	}
}

public class Human {
	public Human () {
		Console.WriteLine("Howdy World...");
	}

	public void GrowUp() {
		Console.WriteLine("Now i am old enough :) ");
	}

	public void DrinkBeer() {
		Console.WriteLine("I am drinking beer!!!");
	}
}
