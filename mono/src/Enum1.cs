// a quick enumerator demo
// Enum1.cs
using System;

class Demo {
	public enum Days : byte {
		monday, tuesday, wednesday, thursday,
		friday, saturday, sunday
	}

	public static void Main() {
		Days MyDay;
		Array DayArray = Enum.GetValues(typeof(Demo.Days));
		foreach (Days Day in DayArray) {
			Console.WriteLine((Day + 1) + " = "
			+ Day.ToString("d"));
		}
	}
}
