// testing more multis
// multi.cs
using System;

class Multi {
	public static int Main() {
		string[ , ] a = new string[2,2];
		string[ ,,, ] b = new string[2,2,2,2];

		Console.WriteLine("a: " + a.Rank);
		Console.WriteLine("b: " + b.Rank);

		return 1;
	}
}
