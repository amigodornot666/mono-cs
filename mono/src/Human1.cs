// this is a slightly more advanced class demo
// Human1.cs
using System;

class Demo {
	public static void Main() {
		string name = "hugo";
		double weight = 89.2;

		Human hugo = new Human(name, weight);
		Console.WriteLine("name: " + hugo.name);
	}
}

class Human {
	public string name;
	double weight;

	public Human(string objname, double objweight) {
		this.name = objname;
		this.weight = objweight;
	}
}


