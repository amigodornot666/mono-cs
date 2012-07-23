// adding elements to an array
// daughter.cs
using System;

class Daughter {
	public static int Main() {
		String[] Daughter = new String[3] {
			"Paula", "Petra", "Maria"};
		Daughter[2] = "Eva-san-clara";
		Console.WriteLine("Daughter: " + Daughter[2]);

		return 1;
	}
}
