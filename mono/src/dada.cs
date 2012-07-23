// now testing multi-dimensional arrays
// dada.cs
using System;

class Dada {
	public static int Main() {
		string[ , ] data = new string[2, 2];
		data[0,0] = "Paul"; data[0,1] = "rudi";
		data[1,0] = "Chris"; data[1,1] = "John";

		Console.WriteLine("Value: " + data[0,1]);

		return 1;
	}
}

	
