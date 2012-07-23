// quick hello world (that says hi to you)
// csharp-hello.cs

public class HelloWorld {
				public static void Main(string[] args) {
								if (args.Length != 1) {
												System.Console.Error.WriteLine("You must tell me your name!");
												System.Environment.Exit(-1);
								}

								string name = args[0];
								System.Console.WriteLine("Hello, {0}!", name);
				}
}
	
