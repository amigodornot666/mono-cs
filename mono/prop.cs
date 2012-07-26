// propertie demo
// prop.cs
using System;

class Point {
	public int x {
		get {
			return x;
		}
		set {
			x = value;
		}
	}

	public int y {
		get {
			return y;
		}
		set {
			y = value;
		}
	}
}

class Demo {
	public static void Main() {
		Point MyPoint = new Point();
		MyPoint.x = 10;
		MyPoint.y = MyPoint.x + 5;
		Console.WriteLine("({0} / {1})",
			MyPoint.x, MyPoint.y);
	}
}
