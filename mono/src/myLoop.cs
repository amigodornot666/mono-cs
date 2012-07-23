// quick loop test
// myLoop.cs
using System;

public class MyLoop {
	public static void Main() {
		bool keepdoing = true;
		string input;

		while (keepdoing) {
			Console.Write("Input: ");
			input = Console.ReadLine();
			Console.WriteLine("Output: " + input);
			
			if (input.Length < 2) 
				keepdoing = false;
			}
	}
}

