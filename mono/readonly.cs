// quick readonly variable demo
// readonly.cs
using System;

class Operation {
				public readonly double pi = 3.141;
				public readonly double e = 2.718;
				
				public Operation() {
								Console.WriteLine("Pi: " + pi);
								Console.WriteLine("e: " + e);
				}
}

class Demo {
				public static void Main() {
								Operation x = new Operation();
				}
}

					
