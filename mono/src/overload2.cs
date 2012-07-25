// OVERLOADING example 2
// overload2.cs
using System;

public class Demo {
	public static void Main() {
		Series r = new Series(1, 2, 3, 4,);
		Console.WriteLine("Result: " + r.avg);
	}
}

public class Series {
	public double avg;
	
	public Series(params int[] zah1) {
		double sum = 0;
		for (int i = 0; i < zah1.Length; i++) {
			Sum += zah1[1];
		}
		
		avg = Sum / zah1.Length;
	}
}

