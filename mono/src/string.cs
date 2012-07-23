// this is a test/demo of arrays and strings
// strings.cs
using System;

class Strings {
	public static int Main() {
		String[] son = {"Hans", "Peter", "Olaf"};
		Console.WriteLine("Son: " + son[0]);

		String[] daughter = new string[3] {
			"Paula", "Petra", "Clara"};
		Console.WriteLine("Daughter: " + daughter[2]);
		return 1;
	}
}
