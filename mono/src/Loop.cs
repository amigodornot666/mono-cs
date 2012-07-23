// A LOOPING DEMo
// Loop.cs
using System;

class LooP {
				public static void Main() {
								bool keepdoing = true;
								string input;

								while (keepdoing == true) {
												Console.Write("Input: ");
												input = Console.ReadLine();
												Console.WriteLine("Output: " + input);

												if 	(input.Length < 2) 
																keepdoing = false;
								}
				}
}


