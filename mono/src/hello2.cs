// another hello world
// hello2.cs
using System;

public class HelloWorld {
				public static void Main(string[] args) {
								if (args.Length != 1) {
												Console.Error.WriteLine("ERROR: YOU MUST GIVE YOUR NAME!");
												Environment.Exit(-1);
								}

								string name = args[0];
								Console.WriteLine("Hello, {0}!", name);
				}
}

